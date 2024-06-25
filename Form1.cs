using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiet_attic_films_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (txt_un.Text == "admin" && txt_pw.Text == "123")
            {
                main_menu main = new main_menu();
                MessageBox.Show("Login Successful");
                main.Show();
                this.Hide();

            }
            else
                MessageBox.Show("Incorrect username & password");
        }
    }
}
