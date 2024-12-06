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
using System;
using PBO_Gymly.CRUD;

namespace PBO_Gymly
{
    public partial class ChangeFasilitasGym : Form
    {
        private int idFasilitas; // To store the facility ID
        public event Action RefreshData; // Event to signal the main form to refresh data

        // Constructor that takes 5 parameters
        public ChangeFasilitasGym(int idFasilitas, string namaFasilitas, int jumlahFasilitas, int fasilitasBaik, int fasilitasRusak)
        {
            InitializeComponent();
            this.idFasilitas = idFasilitas;

            // Pre-fill the form fields with current values
            TextBoxNamaFasilitas.Text = namaFasilitas;
            textjumlahfasilitas.Text = jumlahFasilitas.ToString();
            textjumlahfasilitasbaik.Text = fasilitasBaik.ToString();
            textjumlahfasilitasrusak.Text = fasilitasRusak.ToString();
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            string newNamaFasilitas = TextBoxNamaFasilitas.Text;
            int newJumlahFasilitas = Convert.ToInt32(textjumlahfasilitas.Text);
            int newFasilitasBaik = Convert.ToInt32(textjumlahfasilitasbaik.Text);
            int newFasilitasRusak = Convert.ToInt32(textjumlahfasilitasrusak.Text);

            try
            {
                // Update the facility in the database
                BagianFasilitasGym.UpdateFasilitas(idFasilitas, newNamaFasilitas, newJumlahFasilitas, newFasilitasBaik, newFasilitasRusak);
                MessageBox.Show("Data fasilitas berhasil diubah.");

                // Trigger the RefreshData event
                RefreshData?.Invoke();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
