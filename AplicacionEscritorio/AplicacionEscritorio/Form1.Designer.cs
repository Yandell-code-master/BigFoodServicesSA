namespace AplicacionEscritorio
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ── Main Container Panel ──
            this.panelCardContainer = new System.Windows.Forms.Panel();
            // ── Left Column ──
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelInfoCard = new System.Windows.Forms.Panel();
            this.lblInfoIcon = new System.Windows.Forms.Label();
            this.lblInfoTitle = new System.Windows.Forms.Label();
            this.lblInfoBody = new System.Windows.Forms.Label();
            // ── Right Column ──
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblUsernameLabel = new System.Windows.Forms.Label();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.lblUserIcon = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPasswordLabel = new System.Windows.Forms.Label();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.lblLockIcon = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblTogglePassword = new System.Windows.Forms.Label();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.lnkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblRegisterText = new System.Windows.Forms.Label();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();

            // ═══════════════════════════════════════════
            //  panelCardContainer
            // ═══════════════════════════════════════════
            this.panelCardContainer.Size = new System.Drawing.Size(850, 550);
            this.panelCardContainer.BackColor = System.Drawing.Color.FromArgb(32, 27, 17);

            // ═══════════════════════════════════════════
            //  panelLeft (Image + Branding side)
            // ═══════════════════════════════════════════
            this.panelLeft.Size = new System.Drawing.Size(425, 550);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);

            // panelInfoCard (acrylic floating card)
            this.panelInfoCard.Size = new System.Drawing.Size(330, 140);
            this.panelInfoCard.Location = new System.Drawing.Point(48, 362);
            this.panelInfoCard.BackColor = System.Drawing.Color.FromArgb(100, 58, 52, 40);

            // lblInfoIcon (restaurant / food icon)
            this.lblInfoIcon.Text = "\U0001F37D";
            this.lblInfoIcon.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblInfoIcon.ForeColor = System.Drawing.Color.FromArgb(255, 226, 171);
            this.lblInfoIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoIcon.Size = new System.Drawing.Size(40, 32);
            this.lblInfoIcon.Location = new System.Drawing.Point(18, 18);

            // lblInfoTitle "Elevating the Gastronomy Experience"
            this.lblInfoTitle.Text = "Elevating the Gastronomy Experience";
            this.lblInfoTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.lblInfoTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoTitle.Size = new System.Drawing.Size(294, 46);
            this.lblInfoTitle.Location = new System.Drawing.Point(18, 52);

            // lblInfoBody "Precision-engineered management..."
            this.lblInfoBody.Text = "Precision-engineered management for the modern hospitality industry.";
            this.lblInfoBody.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblInfoBody.ForeColor = System.Drawing.Color.FromArgb(212, 197, 171);
            this.lblInfoBody.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoBody.Size = new System.Drawing.Size(294, 72);
            this.lblInfoBody.Location = new System.Drawing.Point(18, 74);

            // ── Assemble panelLeft ──
            this.panelLeft.Controls.Add(this.panelInfoCard);
            this.panelInfoCard.Controls.Add(this.lblInfoIcon);
            this.panelInfoCard.Controls.Add(this.lblInfoTitle);
            this.panelInfoCard.Controls.Add(this.lblInfoBody);

            // ═══════════════════════════════════════════
            //  panelRight (Login form side)
            // ═══════════════════════════════════════════
            this.panelRight.Size = new System.Drawing.Size(425, 550);
            this.panelRight.Location = new System.Drawing.Point(425, 0);
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(36, 31, 20);

            // lblWelcome "Welcome Back"
            this.lblWelcome.Text = "Welcome Back";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Size = new System.Drawing.Size(280, 40);
            this.lblWelcome.Location = new System.Drawing.Point(40, 60);

            // lblSubtitle
            this.lblSubtitle.Text = "Sign in to manage your kitchen operations.";
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(212, 197, 171);
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Size = new System.Drawing.Size(340, 24);
            this.lblSubtitle.Location = new System.Drawing.Point(40, 106);

            // lblUsernameLabel
            this.lblUsernameLabel.Text = "Username or Email";
            this.lblUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsernameLabel.ForeColor = System.Drawing.Color.FromArgb(212, 197, 171);
            this.lblUsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameLabel.Size = new System.Drawing.Size(200, 18);
            this.lblUsernameLabel.Location = new System.Drawing.Point(40, 160);

            // panelUsername (container with bottom border accent)
            this.panelUsername.Size = new System.Drawing.Size(345, 48);
            this.panelUsername.Location = new System.Drawing.Point(40, 182);
            this.panelUsername.BackColor = System.Drawing.Color.FromArgb(32, 27, 17);
            this.panelUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblUserIcon (person icon)
            this.lblUserIcon.Text = "\U0001F464";
            this.lblUserIcon.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblUserIcon.ForeColor = System.Drawing.Color.FromArgb(156, 143, 120);
            this.lblUserIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblUserIcon.Size = new System.Drawing.Size(30, 46);
            this.lblUserIcon.Location = new System.Drawing.Point(8, 0);
            this.lblUserIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // txtUsername
            this.txtUsername.Text = "";
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(32, 27, 17);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Size = new System.Drawing.Size(290, 22);
            this.txtUsername.Location = new System.Drawing.Point(42, 13);
            this.txtUsername.Text = "";

            // ── Assemble panelUsername ──
            this.panelUsername.Controls.Add(this.lblUserIcon);
            this.panelUsername.Controls.Add(this.txtUsername);

            // lblPasswordLabel
            this.lblPasswordLabel.Text = "Password";
            this.lblPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(212, 197, 171);
            this.lblPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordLabel.Size = new System.Drawing.Size(200, 18);
            this.lblPasswordLabel.Location = new System.Drawing.Point(40, 244);

            // panelPassword
            this.panelPassword.Size = new System.Drawing.Size(345, 48);
            this.panelPassword.Location = new System.Drawing.Point(40, 266);
            this.panelPassword.BackColor = System.Drawing.Color.FromArgb(32, 27, 17);
            this.panelPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblLockIcon
            this.lblLockIcon.Text = "\U0001F512";
            this.lblLockIcon.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblLockIcon.ForeColor = System.Drawing.Color.FromArgb(156, 143, 120);
            this.lblLockIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblLockIcon.Size = new System.Drawing.Size(30, 46);
            this.lblLockIcon.Location = new System.Drawing.Point(8, 0);
            this.lblLockIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // txtPassword
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(237, 225, 208);
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(32, 27, 17);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Size = new System.Drawing.Size(260, 22);
            this.txtPassword.Location = new System.Drawing.Point(42, 13);
            this.txtPassword.UseSystemPasswordChar = true;

            // lblTogglePassword (eye icon — visual only, no logic)
            this.lblTogglePassword.Text = "\U0001F441";
            this.lblTogglePassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTogglePassword.ForeColor = System.Drawing.Color.FromArgb(156, 143, 120);
            this.lblTogglePassword.BackColor = System.Drawing.Color.Transparent;
            this.lblTogglePassword.Size = new System.Drawing.Size(30, 46);
            this.lblTogglePassword.Location = new System.Drawing.Point(310, 0);
            this.lblTogglePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── Assemble panelPassword ──
            this.panelPassword.Controls.Add(this.lblLockIcon);
            this.panelPassword.Controls.Add(this.txtPassword);
            this.panelPassword.Controls.Add(this.lblTogglePassword);

            // chkRememberMe
            this.chkRememberMe.Text = "Remember me";
            this.chkRememberMe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.chkRememberMe.ForeColor = System.Drawing.Color.FromArgb(212, 197, 171);
            this.chkRememberMe.BackColor = System.Drawing.Color.Transparent;
            this.chkRememberMe.Size = new System.Drawing.Size(140, 24);
            this.chkRememberMe.Location = new System.Drawing.Point(40, 330);
            this.chkRememberMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkRememberMe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(80, 69, 50);

            // lnkForgotPassword
            this.lnkForgotPassword.Text = "Forgot password?";
            this.lnkForgotPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lnkForgotPassword.LinkColor = System.Drawing.Color.FromArgb(255, 226, 171);
            this.lnkForgotPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(255, 226, 171);
            this.lnkForgotPassword.VisitedLinkColor = System.Drawing.Color.FromArgb(255, 226, 171);
            this.lnkForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lnkForgotPassword.Size = new System.Drawing.Size(140, 24);
            this.lnkForgotPassword.Location = new System.Drawing.Point(255, 330);
            this.lnkForgotPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;

            // btnLogin
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(109, 80, 0);
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(255, 191, 0);
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Size = new System.Drawing.Size(345, 52);
            this.btnLogin.Location = new System.Drawing.Point(40, 370);
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Text = "Login  \u2192";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // lblRegisterText "Don't have an account?"
            this.lblRegisterText.Text = "Don\u2019t have an account?";
            this.lblRegisterText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblRegisterText.ForeColor = System.Drawing.Color.FromArgb(212, 197, 171);
            this.lblRegisterText.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterText.Size = new System.Drawing.Size(180, 20);
            this.lblRegisterText.Location = new System.Drawing.Point(110, 490);

            // lnkRegister
            this.lnkRegister.Text = "Register";
            this.lnkRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lnkRegister.LinkColor = System.Drawing.Color.FromArgb(255, 226, 171);
            this.lnkRegister.ActiveLinkColor = System.Drawing.Color.FromArgb(255, 226, 171);
            this.lnkRegister.VisitedLinkColor = System.Drawing.Color.FromArgb(255, 226, 171);
            this.lnkRegister.BackColor = System.Drawing.Color.Transparent;
            this.lnkRegister.Size = new System.Drawing.Size(80, 20);
            this.lnkRegister.Location = new System.Drawing.Point(286, 490);

            // ── Assemble panelRight ──
            this.panelRight.Controls.Add(this.lblWelcome);
            this.panelRight.Controls.Add(this.lblSubtitle);
            this.panelRight.Controls.Add(this.lblUsernameLabel);
            this.panelRight.Controls.Add(this.panelUsername);
            this.panelRight.Controls.Add(this.lblPasswordLabel);
            this.panelRight.Controls.Add(this.panelPassword);
            this.panelRight.Controls.Add(this.chkRememberMe);
            this.panelRight.Controls.Add(this.lnkForgotPassword);
            this.panelRight.Controls.Add(this.btnLogin);
            this.panelRight.Controls.Add(this.lblRegisterText);
            this.panelRight.Controls.Add(this.lnkRegister);

            // ═══════════════════════════════════════════
            //  Assemble panelCardContainer
            // ═══════════════════════════════════════════
            this.panelCardContainer.Controls.Add(this.panelLeft);
            this.panelCardContainer.Controls.Add(this.panelRight);

            // ═══════════════════════════════════════════
            //  Form1
            // ═══════════════════════════════════════════
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);

            this.Controls.Add(this.panelCardContainer);

            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
        }

        // ── Control Declarations ──
        private System.Windows.Forms.Panel panelCardContainer;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelInfoCard;
        private System.Windows.Forms.Label lblInfoIcon;
        private System.Windows.Forms.Label lblInfoTitle;
        private System.Windows.Forms.Label lblInfoBody;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsernameLabel;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Label lblUserIcon;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPasswordLabel;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Label lblLockIcon;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblTogglePassword;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.LinkLabel lnkForgotPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblRegisterText;
        private System.Windows.Forms.LinkLabel lnkRegister;
    }
}
