using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMahasiswa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportBarang012 reportBarang = new ReportBarang012();
            reportBarang.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MasterBarang022 reportBarang = new MasterBarang022();
            reportBarang.Show();
        }
    }
}
