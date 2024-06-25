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
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
        }

        private void bt_client_Click(object sender, EventArgs e)
        {
            client_form client = new client_form();
            client.Show();
            this.Hide();
        }
    }
}
