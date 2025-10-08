using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PasswordCheckerApp
{
    public partial class Form1 : Form
    {
        private readonly string correctPassword = "Admin123";
        private bool passwordVisible = false;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(45, 48, 65),   
                Color.FromArgb(25, 27, 40),   
                90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Equals(correctPassword))
            {
                labelResult.Text = "✅ Пароль верный!";
                labelResult.ForeColor = Color.MediumSeaGreen;
            }
            else
            {
                labelResult.Text = "❌ Пароль неверный!";
                labelResult.ForeColor = Color.IndianRed;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text ?? string.Empty;
            int score = 0;

            if (password.Length >= 6) score++;
            if (Regex.IsMatch(password, @"[A-Z]")) score++;
            if (Regex.IsMatch(password, @"[a-z]")) score++;
            if (Regex.IsMatch(password, @"[0-9]")) score++;
            if (Regex.IsMatch(password, @"[\W_]")) score++;

            if (score <= 1)
            {
                labelStrength.Text = "Сложность: очень слабый";
                labelStrength.ForeColor = Color.IndianRed;
            }
            else if (score <= 3)
            {
                labelStrength.Text = "Сложность: средний";
                labelStrength.ForeColor = Color.DarkOrange;
            }
            else
            {
                labelStrength.Text = "Сложность: надёжный";
                labelStrength.ForeColor = Color.MediumSeaGreen;
            }
        }

        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            textBoxPassword.UseSystemPasswordChar = !passwordVisible;
            btnTogglePassword.Text = passwordVisible ? "🙈" : "👁";
        }
    }
}
