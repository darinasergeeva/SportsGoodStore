
namespace SportsGoodsStore
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            PnMain = new Panel();
            buttonGuest = new Button();
            buttonLogin = new Button();
            tbPassword = new TextBox();
            lbPassword = new Label();
            tbLogin = new TextBox();
            labelLogin = new Label();
            PbLogo = new PictureBox();
            PnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbLogo).BeginInit();
            SuspendLayout();
            // 
            // PnMain
            // 
            PnMain.Controls.Add(buttonGuest);
            PnMain.Controls.Add(buttonLogin);
            PnMain.Controls.Add(tbPassword);
            PnMain.Controls.Add(lbPassword);
            PnMain.Controls.Add(tbLogin);
            PnMain.Controls.Add(labelLogin);
            PnMain.Location = new Point(23, 134);
            PnMain.Name = "PnMain";
            PnMain.Size = new Size(334, 215);
            PnMain.TabIndex = 1;
            // 
            // buttonGuest
            // 
            buttonGuest.BackColor = Color.FromArgb(233, 245, 255);
            buttonGuest.FlatAppearance.BorderSize = 0;
            buttonGuest.FlatStyle = FlatStyle.Flat;
            buttonGuest.Location = new Point(92, 162);
            buttonGuest.Name = "buttonGuest";
            buttonGuest.Size = new Size(150, 30);
            buttonGuest.TabIndex = 5;
            buttonGuest.Text = "Войти как гость";
            buttonGuest.UseVisualStyleBackColor = false;
            buttonGuest.Click += button2_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(67, 97, 238);
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Location = new Point(92, 128);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(150, 30);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = false;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(42, 98);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(250, 26);
            tbPassword.TabIndex = 3;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(138, 75);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(59, 19);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Пароль";
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(42, 45);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(250, 26);
            tbLogin.TabIndex = 1;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(142, 22);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(50, 19);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Логин";
            // 
            // PbLogo
            // 
            PbLogo.Image = (Image)resources.GetObject("PbLogo.Image");
            PbLogo.Location = new Point(142, 12);
            PbLogo.Name = "PbLogo";
            PbLogo.Size = new Size(100, 100);
            PbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PbLogo.TabIndex = 2;
            PbLogo.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 361);
            Controls.Add(PbLogo);
            Controls.Add(PnMain);
            Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход в систему";
            PnMain.ResumeLayout(false);
            PnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PbLogo;

        public PictureBox PbLogo { get; private set; }

        private Panel PnMain;
        private TextBox tbPassword;
        private Label lbPassword;
        private TextBox tbLogin;
        private Label labelLogin;
        private Button buttonGuest;
        private Button buttonLogin;

        public EventHandler textBox2_TextChanged { get; private set; }
        public EventHandler label2_Click { get; private set; }
        public EventHandler textBox1_TextChanged { get; private set; }
        public EventHandler labelLogin_Click { get; private set; }
        public EventHandler button1_Click { get; private set; }
    }
}