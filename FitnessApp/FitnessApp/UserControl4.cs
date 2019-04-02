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
    public partial class UserControl4 : UserControl
    {
        private OleDbConnection connection = new OleDbConnection();
        public UserControl4()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Edmond\Desktop\DEVELOPMENT\FitnessApp\FitnessApp\bin\Debug\Database\UscClass.accdb;
            Persist Security Info=False;";

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from UscClass";
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

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";


        }

        private void inserting()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into UscClass(ClassID, ClassTime, ClassDate) values('" + textBox4.Text + "','" + textBox3.Text + "','" + textBox2.Text + "')";
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
                cmd.CommandText = "delete from RoutineList where UscClass =" + i + "";
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inserting();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleting();
        }
    }
}
