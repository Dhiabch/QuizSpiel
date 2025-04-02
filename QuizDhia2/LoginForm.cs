using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuizDhia2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Neue Instanz von RegisterForm erstellen
            SignUpForm registerForm = new SignUpForm();
            // Berechne die Position des RegisterForm, um es neben LoginForm zu öffnen
            // LoginForm.Location gibt die aktuelle Position von LoginForm zurück
            // Wir fügen z.B. 10 Pixel zum X-Wert hinzu, um es rechts daneben zu platzieren
            registerForm.StartPosition = FormStartPosition.Manual; // Manuelle Positionierung
            registerForm.Location = new Point(this.Location.X + this.Width, this.Location.Y); // Direkt neben LoginForm

            // Zeige RegisterForm
            registerForm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbViewPasswort_CheckedChanged(object sender, EventArgs e)
        {
            if (cbViewPassword.CheckState == CheckState.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
