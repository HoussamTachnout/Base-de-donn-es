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
            Update.Enabled = true;
            Insert.Enabled = false;
            Delete.Enabled = false;
            labelage.Enabled = false;
            labelprenom.Enabled = false;
            age.Enabled = false;
            prenom.Enabled = false;
            labelnom.Enabled = true;
            nom.Enabled = true;

        }

        private void Insert_click(object sender, EventArgs e)
        {
            Update.Enabled = false;
            Insert.Enabled = true;
            Delete.Enabled = false;
            labelage.Enabled = true;
            labelprenom.Enabled = true;
            age.Enabled = true;
            prenom.Enabled = true;
            labelnom.Enabled = true;
            nom.Enabled = true;

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Update.Enabled = false;
            Insert.Enabled = false;
            Delete.Enabled = true;
            labelage.Enabled = false;
            labelprenom.Enabled = false;
            labelnom.Enabled = false;
            age.Enabled = false;
            prenom.Enabled = false;
            nom.Enabled = false;
        }

        private void valide_Click(object sender, EventArgs e)
        {
            if(Insert.Enabled==true)
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
            else if(Update.Enabled==true)
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
            else if(Delete.Enabled==true)
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
        }

        private void annule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel");
            this.Close();
        }
    }
}
