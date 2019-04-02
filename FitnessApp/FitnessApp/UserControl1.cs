using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class UserControl1 : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        public UserControl1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Edmond\Desktop\DEVELOPMENT\FitnessApp\FitnessApp\bin\Debug\Database\UscClass.accdb;
Persist Security Info=False;";
        }

        private void cleartext()
        {
            //Clear Text in UserControl 1 Text feids

            textBox6.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";


        }

        private void inserting()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string dayTime = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt");

                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into RoutineList(UserName, Gender, Height, Weight, UserSchool, Routine, RoutineDate) values('"+ textBox6.Text + "','" + comboBox1.Text + "','" + textBox4.Text.Replace("'", "''") + "','" + 
                textBox5.Text + "','" + textBox2.Text + "','" + textBox1.Text + "','" + dayTime + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Info inserted into database successfully");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            cleartext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Insertion of data into Database
            inserting();
        }
    }
}
