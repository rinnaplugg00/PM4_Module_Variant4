using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordCheckerApp
{
    partial class Form1
    {
        private TextBox textBoxPassword;
        private Button btnCheck;
        private Button btnTogglePassword;
        private Label labelResult;
        private Label labelStrength;
        private Label labelTitle;

        private void InitializeComponent()
        {
            this.textBoxPassword = new TextBox();
            this.btnCheck = new Button();
            this.btnTogglePassword = new Button();
            this.labelResult = new Label();
            this.labelStrength = new Label();
            this.labelTitle = new Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.labelTitle.ForeColor = Color.WhiteSmoke;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new Point(100, 25);
            this.labelTitle.Text = "🔒 Проверка пароля";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new Font("Segoe UI", 11F);
            this.textBoxPassword.Location = new Point(50, 85);
            this.textBoxPassword.Size = new Size(210, 27);
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxPassword.TextChanged += new EventHandler(this.textBoxPassword_TextChanged);
            // 
            // btnTogglePassword
            // 
            this.btnTogglePassword.Font = new Font("Segoe UI Emoji", 10F);
            this.btnTogglePassword.Location = new Point(265, 85);
            this.btnTogglePassword.Size = new Size(35, 27);
            this.btnTogglePassword.Text = "👁";
            this.btnTogglePassword.FlatStyle = FlatStyle.Flat;
            this.btnTogglePassword.FlatAppearance.BorderSize = 0;
            this.btnTogglePassword.BackColor = Color.FromArgb(60, 63, 81);
            this.btnTogglePassword.ForeColor = Color.White;
            this.btnTogglePassword.Cursor = Cursors.Hand;
            this.btnTogglePassword.Click += new EventHandler(this.btnTogglePassword_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCheck.Location = new Point(305, 85);
            this.btnCheck.Size = new Size(100, 27);
            this.btnCheck.Text = "Проверить";
            this.btnCheck.BackColor = Color.MediumSlateBlue;
            this.btnCheck.ForeColor = Color.White;
            this.btnCheck.FlatStyle = FlatStyle.Flat;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.Cursor = Cursors.Hand;
            this.btnCheck.Click += new EventHandler(this.btnCheck_Click);
            // 
            // labelResult
            // 
            this.labelResult.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.labelResult.ForeColor = Color.WhiteSmoke;
            this.labelResult.Location = new Point(50, 135);
            this.labelResult.AutoSize = true;
            // 
            // labelStrength
            // 
            this.labelStrength.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            this.labelStrength.ForeColor = Color.LightGray;
            this.labelStrength.Location = new Point(50, 165);
            this.labelStrength.AutoSize = true;
            this.labelStrength.Text = "Сложность: —";
            // 
            // Form1
            // 
            this.ClientSize = new Size(460, 220);
            this.BackColor = Color.FromArgb(35, 38, 50);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.btnTogglePassword);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelStrength);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Password Checker";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
