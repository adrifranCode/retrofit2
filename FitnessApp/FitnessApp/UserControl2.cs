using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Write Goals to text file

            StreamWriter sw = File.AppendText(Application.StartupPath + "\\Goals\\" + "Goals.txt");
            sw.WriteLine(textBox1.Text);
            textBox1.Text = string.Empty;
            sw.Close();

            StreamReader sr = new StreamReader(Application.StartupPath + "\\Goals\\" + "Goals.txt");
            textBox2.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
