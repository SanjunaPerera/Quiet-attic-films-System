using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quiet_attic_films_GUI
{
    public partial class client_form : Form
    {
        public client_form()
        {
            InitializeComponent();
        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-84GU7NV\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO client(client_id,client_name,contact_no) VALUES (@client_id,@client_name,@contact_no)", con);
            cmd.Parameters.AddWithValue("@client_id", int.Parse(txt_clientid.Text));
            cmd.Parameters.AddWithValue("@client_name",txt_clientname.Text);
            cmd.Parameters.AddWithValue("@contact_no", txt_clientno.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Inserted!");
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-84GU7NV\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE client SET client_name=@client_name, contact_no=@contact_no WHERE client_id=@client_id", con);
            cmd.Parameters.AddWithValue("@client_id", int.Parse(txt_clientid.Text));
            cmd.Parameters.AddWithValue("@client_name",txt_clientname.Text);
            cmd.Parameters.AddWithValue("@contact_no", txt_clientno.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Updated!");
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-84GU7NV\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE client WHERE client_id=@client_id", con);
            cmd.Parameters.AddWithValue("@client_id", int.Parse(txt_clientid.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Deleted!");
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-84GU7NV\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM client WHERE client_id=@client_id", con);
            cmd.Parameters.AddWithValue("@client_id", int.Parse(txt_clientid.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("The searched details are shown in grid view successfully!");

        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            main_menu main = new main_menu();
            main.Show();
            this.Hide();
        }

        private void client_form_Load(object sender, EventArgs e)
        {

        }

        private void bt_view_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-84GU7NV\SQLEXPRESS;Initial Catalog=Quiet_Attic_Films;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM client", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("All details are shown in grid view successfully!");
        }
    }
}
