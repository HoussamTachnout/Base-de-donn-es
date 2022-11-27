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
                string cmdText = "UPDATE table1 SET Nom = @Nom WHERE CIN = @CIN";
                MySqlCommand cmd = new MySqlCommand(cmdText, mcon);
                cmd.Parameters.Add("@Nom", nom.Text);
                cmd.Parameters.Add("@CIN", cin.Text);
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

                string cmdText = "INSERT INTO table1(Nom , Age , Prenom , CIN) VALUES (@Nom,@Age,@Prenom,@CIN)";
                MySqlCommand cmd = new MySqlCommand(cmdText, mcon);
                cmd.Parameters.Add("@Nom", nom.Text);
                cmd.Parameters.Add("@Age", age.Text);
                cmd.Parameters.Add("@Prenom", prenom.Text);
                cmd.Parameters.Add("@CIN", cin.Text);
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

            string cmdText = "DELETE from table1 WHERE CIN = @CIN";
            MySqlCommand cmd = new MySqlCommand(cmdText, mcon);
            cmd.Parameters.Add("@cin", cin.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void inse_CheckedChanged(object sender, EventArgs e)
        {
            Insert.Visible = true;
            Update.Visible = false;
            Delete.Visible = false;
            labelage.Visible = true;
            labelprenom.Visible = true;
            age.Visible = true;
            prenom.Visible = true;
            labelnom.Visible = true;
            nom.Visible = true;
        }

        private void upda_CheckedChanged(object sender, EventArgs e)
        {
            Update.Visible = true;
            Insert.Visible = false;
            Delete.Visible = false;
            labelage.Visible = false;
            labelprenom.Visible = false;
            age.Visible = false;
            prenom.Visible = false;
            labelnom.Visible = true;
            nom.Visible = true;
        }

        private void dele_CheckedChanged(object sender, EventArgs e)
        {
            Delete.Visible = true;
            Insert.Visible = false;
            Update.Visible = false;
            labelage.Visible = false;
            labelprenom.Visible = false;
            labelnom.Visible = false;
            age.Visible = false;
            prenom.Visible = false;
            nom.Visible = false;

        }

        private void cin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
