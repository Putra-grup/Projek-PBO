using PBO_Gymly.CRUD;
using PBO_Gymly.StrukturData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_Gymly
{
    public partial class FasilitasGym : Form
    {
        public FasilitasGym()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();

            homepage.Show();

            this.Hide();
        }

        private void ButtonAddFasilitasGym_Click(object sender, EventArgs e)
        {
            AddFasilitasGym addfasilitasgym = new AddFasilitasGym(this);

            addfasilitasgym.Show();
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
           
            if (DataGridView_FasilitasGym.SelectedRows.Count > 0)
            {
                var row = DataGridView_FasilitasGym.SelectedRows[0];
                int idFasilitas = Convert.ToInt32(row.Cells["id_fasilitas_gym"].Value);
                string namaFasilitas = row.Cells["nama_fasilitas"].Value.ToString();
                int jumlahFasilitas = Convert.ToInt32(row.Cells["jumlah_fasilitas"].Value);
                int fasilitasBaik = Convert.ToInt32(row.Cells["fasilitas_baik"].Value);
                int fasilitasRusak = Convert.ToInt32(row.Cells["fasilitas_rusak"].Value);
                ChangeFasilitasGym changefasilitasgym = new ChangeFasilitasGym(idFasilitas, namaFasilitas, jumlahFasilitas, fasilitasBaik, fasilitasRusak);
                changefasilitasgym.Show();
            }
            else
            {
                MessageBox.Show("Silahkan pilih fasilitas yang ingin diubah");
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            // Ambil ID fasilitas yang dipilih untuk dihapus dari DataGridView
            if (DataGridView_FasilitasGym.SelectedRows.Count > 0)
            {
                var row = DataGridView_FasilitasGym.SelectedRows[0];
                int idFasilitas = Convert.ToInt32(row.Cells["id_fasilitas_gym"].Value);

                // Konfirmasi penghapusan
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus fasilitas ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Panggil fungsi untuk menghapus fasilitas dan memperbarui ID
                        BagianFasilitasGym.DeleteMahasiswa(idFasilitas);

                        // Refresh data setelah penghapusan
                        LoadDataFasilitasGym();
                        MessageBox.Show("Fasilitas berhasil dihapus.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting data: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih fasilitas yang ingin dihapus.");
            }
        }

        private void FasilitasGym_Load(object sender, EventArgs e)
        {
            LoadDataFasilitasGym();
        }

        public void LoadDataFasilitasGym()
        {
            try
            {
                DataTable data = BagianFasilitasGym.All();
                DataGridView_FasilitasGym.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

    }
}
