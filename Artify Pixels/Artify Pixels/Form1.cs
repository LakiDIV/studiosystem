using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artify_Pixels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            // Greeting 
            greetingLbl.Text = "Good Day !";
            this.Controls.Add(greetingLbl);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Promt a dialog box before exit the program
            const string message = "Do you want to exit?";
            const string caption = "EXIT";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void greetingLbl_Click(object sender, EventArgs e)
        { }
        private void pictureBox1_Click(object sender, EventArgs e)
        { }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            
            if (userNameTxt.Text == "user" && passwordTxt.Text == "pass")
            {
                Label loginLab = new Label();
                loginLab.Text = "You loged in !";
                this.Controls.Add(loginLab);
            }
            else
            {
                Label loginLab = new Label();
                loginLab.Text = "Invalid username or password !";
                this.Controls.Add(loginLab);
            }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                isCaps.Text = "Caps Lock is ON";
                this.Controls.Add(isCaps);
            }
            else
            {
                isCaps.Text = "";
                this.Controls.Add(isCaps);
            }
        }
    }
}