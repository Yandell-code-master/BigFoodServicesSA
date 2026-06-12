using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using AplicacionEscritorio.Services;

namespace AplicacionEscritorio
{
    public partial class Form1 : Form
    {
        private PrivateFontCollection _fonts;
        private Image _backgroundImage;

        public Form1()
        {
            InitializeComponent();
            LoadFonts();
            LoadBackgroundImage();
            panelLeft.Paint += PanelLeft_Paint;
            SetRoundedRegion();
            CenterCard();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterCard();
            ApplyInterFonts();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterCard();
        }

        private void CenterCard()
        {
            panelCardContainer.Location = new Point(
                (ClientSize.Width - panelCardContainer.Width) / 2,
                (ClientSize.Height - panelCardContainer.Height) / 2
            );
        }

        private void LoadFonts()
        {
            _fonts = new PrivateFontCollection();
            string fontPath = Path.Combine(Application.StartupPath, "Resources", "Inter.ttf");

            if (File.Exists(fontPath))
            {
                _fonts.AddFontFile(fontPath);
            }
        }

        private Font GetInterFont(float size, FontStyle style)
        {
            if (_fonts != null && _fonts.Families.Length > 0)
            {
                return new Font(_fonts.Families[0], size, style);
            }
            return new Font("Segoe UI", size, style);
        }

        private void ApplyInterFonts()
        {
            lblInfoIcon.Font = GetInterFont(18F, FontStyle.Regular);
            lblInfoTitle.Font = GetInterFont(16F, FontStyle.Bold);
            lblInfoBody.Font = GetInterFont(10F, FontStyle.Regular);
            lblWelcome.Font = GetInterFont(22F, FontStyle.Bold);
            lblSubtitle.Font = GetInterFont(12F, FontStyle.Regular);
            lblUsernameLabel.Font = GetInterFont(10F, FontStyle.Bold);
            lblPasswordLabel.Font = GetInterFont(10F, FontStyle.Bold);
            txtUsername.Font = GetInterFont(12F, FontStyle.Regular);
            txtPassword.Font = GetInterFont(12F, FontStyle.Regular);
            chkRememberMe.Font = GetInterFont(10F, FontStyle.Regular);
            lnkForgotPassword.Font = GetInterFont(10F, FontStyle.Regular);
            btnLogin.Font = GetInterFont(16F, FontStyle.Bold);
            lblRegisterText.Font = GetInterFont(10F, FontStyle.Regular);
            lnkRegister.Font = GetInterFont(10F, FontStyle.Bold);
        }

        private void LoadBackgroundImage()
        {
            string imagePath = Path.Combine(Application.StartupPath, "Resources", "BigFoodSA_kitchen.jpg");

            if (File.Exists(imagePath))
            {
                _backgroundImage = Image.FromFile(imagePath);
            }
        }

        private void PanelLeft_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = panelLeft.ClientRectangle;
            Graphics g = e.Graphics;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            if (_backgroundImage != null)
            {
                DrawImageCover(g, _backgroundImage, rect);
            }

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(180, 18, 19, 9),
                Color.FromArgb(40, 18, 19, 9),
                LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, rect);
            }

            using (Font titleFont = new Font("Segoe UI", 32F, FontStyle.Bold))
            {
                TextRenderer.DrawText(g, "BigFoodSA", titleFont,
                    new Point(48, 48), Color.FromArgb(255, 226, 171),
                    TextFormatFlags.NoPadding);
            }

            using (Font subFont = new Font("Segoe UI", 12F, FontStyle.Regular))
            {
                TextRenderer.DrawText(g, "MANAGEMENT PORTAL", subFont,
                    new Point(48, 94), Color.FromArgb(204, 180, 136),
                    TextFormatFlags.NoPadding);
            }
        }

        private void DrawImageCover(Graphics g, Image image, Rectangle targetRect)
        {
            float imgAspect = (float)image.Width / image.Height;
            float rectAspect = (float)targetRect.Width / targetRect.Height;

            RectangleF srcRect;

            if (imgAspect > rectAspect)
            {
                float srcWidth = image.Height * rectAspect;
                float srcX = (image.Width - srcWidth) / 2f;
                srcRect = new RectangleF(srcX, 0, srcWidth, image.Height);
            }
            else
            {
                float srcHeight = image.Width / rectAspect;
                float srcY = (image.Height - srcHeight) / 2f;
                srcRect = new RectangleF(0, srcY, image.Width, srcHeight);
            }

            g.DrawImage(image, targetRect, srcRect, GraphicsUnit.Pixel);
        }

        private void SetRoundedRegion()
        {
            int radius = 12;
            Rectangle rect = new Rectangle(0, 0, panelCardContainer.Width, panelCardContainer.Height);
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
                path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
                path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
                path.CloseFigure();
                panelCardContainer.Region = new Region(path);
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Ingrese usuario y contrase\u00f1a.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "Conectando...";

            var success = await ApiService.LoginAsync(txtUsername.Text.Trim(), txtPassword.Text);

            if (success)
            {
                Form2 billing = new Form2();
                billing.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se pudo conectar con el servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLogin.Enabled = true;
                btnLogin.Text = "Login  \u2192";
            }
        }
    }
}
