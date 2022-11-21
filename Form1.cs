using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Base_de_données
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Server=localhost;Database=table;Uid=root;Pwd=;";
                MySqlConnection mcon = new MySqlConnection(connString);
                mcon.Open();
                string cmdText = "UPDATE table1 SET nom = @nom WHERE age = @age";
                MySqlCommand cmd = new MySqlCommand(cmdText, mcon);
                cmd.Parameters.Add("@nom", forupdate.Text);
                cmd.Parameters.Add("@age", age.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data changed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Insert_click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Server=localhost;Database=table;Uid=root;Pwd=;";
                MySqlConnection mcon = new MySqlConnection(connString);
                mcon.Open();

                string cmdText = "INSERT INTO table1(nom , age) VALUES (@nom,@age)";
                MySqlCommand cmd = new MySqlCommand(cmdText, mcon);
                cmd.Parameters.Add("@nom", forinsert.Text);
                cmd.Parameters.Add("@age", age.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Server=localhost;Database=table;Uid=root;Pwd=;";
            MySqlConnection mcon = new MySqlConnection(connString);
            mcon.Open();

            string cmdText = "DELETE from table1 WHERE nom = @nom";
            MySqlCommand cmd = new MySqlCommand(cmdText, mcon);
            cmd.Parameters.Add("@nom", fordelete.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Valid_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {

        }

        private void forinsert_TextChanged(object sender, EventArgs e)
        {
            forupdate.Visible = false;
            fordelete.Visible = false;
            Update.Visible = false;
            Delete.Visible = false;
        }

        private void forupdate_TextChanged(object sender, EventArgs e)
        {
            forinsert.Visible = false;
            fordelete.Visible = false;
            Insert.Visible = false;
            Delete.Visible = false;
        }

        private void fordelete_TextChanged(object sender, EventArgs e)
        {
            forupdate.Visible = false;
            forinsert.Visible = false;
            Update.Visible = false;
            Insert.Visible = false;
        }
    }
}
