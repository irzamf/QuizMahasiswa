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

        private void masterBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterBarang022 masterBarang = new MasterBarang022();
            masterBarang.TopLevel = false;
            masterBarang.Parent = this;
            masterBarang.Show();
        }

        private void reportBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportBarang012 reportBarang = new ReportBarang012();
            reportBarang.TopLevel = false;
            reportBarang.Parent = this;
            reportBarang.Show();
        }
    }
}
