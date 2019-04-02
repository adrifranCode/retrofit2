using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class Homepage : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Homepage()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Edmond\Desktop\DEVELOPMENT\FitnessApp\FitnessApp\bin\Debug\Database\UscClass.accdb;
Persist Security Info=False;";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //connection.Open();
                // checkConnection.Text = "Connection Successful";


                //connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl32.Hide();
            userControl41.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Display pages according to which buttons are clicked

            userControl21.Hide();
            userControl31.Hide();
            userControl32.Hide();
            userControl41.Hide();

            userControl11.Show();
            userControl11.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Display pages according to which buttons are clicked

            userControl11.Hide();
            userControl31.Hide();
            userControl32.Hide();
            userControl41.Hide();

            userControl21.Show();
            userControl21.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Display pages according to which buttons are clicked

            userControl21.Hide();
            userControl11.Hide();
            userControl41.Hide();

            userControl31.Show();
            userControl32.Show();

            userControl31.BringToFront();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Display pages according to which buttons are clicked

            userControl21.Hide();
            userControl31.Hide();
           
            userControl11.Hide();

            userControl41.Show();
            userControl41.BringToFront();
        }

        private void userControl32_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void userControl32_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
