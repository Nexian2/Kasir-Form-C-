using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kasir
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void MasukkanBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = MasukkanBarang.Text;

            bool apakahHargaValid = int.TryParse(MasukkanHarga.Text, out int harga);
            bool apakahJumlahValid = int.TryParse(JumlahBarang.Text, out int jumlah);

            if (item != "" && apakahHargaValid && apakahJumlahValid)
            {
                int total = harga * jumlah;

                listBox1.Items.Add("Barang: " + item + ", Harga: Rp " + harga.ToString("N0") + ", Jumlah: " + jumlah + ", Total: Rp " + total.ToString("N0"));

                MasukkanBarang.Clear();
                MasukkanHarga.Clear();
                JumlahBarang.Clear();
            }
            else
            {
                MessageBox.Show("Masukkan barang, harga, dan jumlah terlebih dahulu.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Pilih item yang ingin dihapus.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string item = MasukkanBarang.Text;

            bool apakahHargaValid = int.TryParse(MasukkanHarga.Text, out int harga);
            bool apakahJumlahValid = int.TryParse(JumlahBarang.Text, out int jumlah);

            if (item != "" && apakahHargaValid && apakahJumlahValid)
            {
                int total = harga * jumlah;

                listBox1.Items.Add("Barang: " + item + ", Harga: Rp " + harga.ToString("N0") + ", Jumlah: " + jumlah + ", Total: Rp " + total.ToString("N0"));

                MasukkanBarang.Clear();
                MasukkanHarga.Clear();
                JumlahBarang.Clear();
            }
            else
            {
                MessageBox.Show("Masukkan barang, harga, dan jumlah terlebih dahulu.");
            }
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            bool apakahHargaValid = int.TryParse(MasukkanHarga.Text, out int harga);
            bool apakahJumlahValid = int.TryParse(JumlahBarang.Text, out int jumlah);

            if (apakahHargaValid && apakahJumlahValid)
            {
                int total = harga * jumlah;

                TotalBarang.Text = "Rp " + total.ToString("N0");
            }
            else
            {
                MessageBox.Show("Masukkan harga dan jumlah barang dahulu.");
            }
        }
    }
}