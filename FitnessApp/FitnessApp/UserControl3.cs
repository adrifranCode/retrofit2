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
    public partial class UserControl3 : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        public UserControl3()
        {
            InitializeComponent();

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Edmond\Desktop\DEVELOPMENT\FitnessApp\FitnessApp\bin\Debug\Database\UscClass.accdb;
            Persist Security Info=False;";
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from RoutineList";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void cleartext()
        {
            //Clear Text in UserControl 1 Text feids

            //textBox6.Text = "";


        }

        private void inserting()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                //OleDbCommand cmd = connection.CreateCommand();
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "insert into RoutineList(WorkoutFocus) values('" + textBox6.Text + "')";
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("Info inserted into database successfully");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            cleartext();
        }

        private void deleting()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                int i = Convert.ToInt32(textBox1.Text);

                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from RoutineList where RoutineID =" + i + "";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Routine deleted from database successfully! Please restart the app to see all your changes.");


                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            cleartext();



        }

        /*private void updating()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }


                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update RoutineList set Routine =" + textBox1.Text + "";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data updated successfully! Please restart the app to see all your changes.");


                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            cleartext();



        } */

        private void button1_Click(object sender, EventArgs e)
        {
            //Insertion of data into Database
            inserting();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleting();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //updating();
        }
    }
}
