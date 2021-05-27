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

namespace QuizMahasiswa
{
    public partial class MasterBarang022 : Form
    {

        SqlConnection con = new SqlConnection("integrated security=true; data source=.;initial catalog=quizmahasiswa");
        DataClasses1DataContext db = new DataClasses1DataContext();
        public MasterBarang022()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                string nama_brg = txtNama.Text;
                int hrg = int.Parse(txtHarga.Text);
                int stck = int.Parse(txtStock.Text);
                string nama_sup = txtSupplier.Text;

                var data = new tbl_barang
                {
                    id_barang = id,
                    nama_barang = nama_brg,
                    harga = hrg,
                    stock = stck,
                    nama_supplier = nama_sup
                };

                db.tbl_barangs.InsertOnSubmit(data);
                db.SubmitChanges();
                MessageBox.Show("Save Successfully");
                txtHarga.Clear();
                txtNama.Clear();
                txtStock.Clear();
                txtSupplier.Clear();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
            
        private void MasterBarang022_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select isnull(max (cast (id_barang as int)),0) +1 from tbl_barang", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                txtID.Text = dt.Rows[0][0].ToString();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        void LoadData()
        {
            try
            {
                var st = from tb in db.tbl_barangs select tb;
                dataGridView1.DataSource = st;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

    }
}
