using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace angkringankece
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tombolHitung_Click(object sender, EventArgs e)
        {
            double bpnasiGoreng, bpnasiAyam, bpnasiTelor, bpnasiSoto, bpnasiTongkol, bpindomieRebus, bpindomieGoreng, bpkentangGoreng, bpjamurCryspy;
            double bpTeh, bpJeruk, bpSusu, bpKopiHitam, bpCapucino;
            double bptotalBiaya, bpUang, bpPajak, bptotalPembayaran, bpKembalian;

            double hargaNg, hargaNa, hargaNtel, hargaNs, hargaNtong, hargaIndomR, hargaIndomG, hargaKg, hargaJc;
            double hargaTh, hargaJr, hargaSS, hargaKH, hargaCap;

            bpnasiGoreng = double.Parse(nasiGoreng.Text);
            bpnasiAyam = double.Parse(nasiAyam.Text);
            bpnasiTelor = double.Parse(nasiTelor.Text);
            bpnasiSoto = double.Parse(nasiSoto.Text);
            bpnasiTongkol = double.Parse(nasiTongkol.Text);
            bpindomieRebus = double.Parse(indomieRebus.Text);
            bpindomieGoreng = double.Parse(IndomieGoreng.Text);
            bpkentangGoreng = double.Parse(kentangGoreng.Text);
            bpjamurCryspy = double.Parse(jamurCryspy.Text);

            bpTeh = double.Parse(Teh.Text);
            bpJeruk = double.Parse(jeruk.Text);
            bpSusu = double.Parse(susu.Text);
            bpKopiHitam = double.Parse(kopiHitam.Text);
            bpCapucino = double.Parse(capucino.Text);

            bpUang = double.Parse(uang.Text);

            hargaNg = bpnasiGoreng * 15000;
            hargaNa = bpnasiAyam * 12000;
            hargaNtel = bpnasiTelor * 8000;
            hargaNs = bpnasiSoto * 9000;
            hargaNtong = bpnasiTongkol * 10000;
            hargaIndomR = bpindomieRebus * 6000;
            hargaIndomG = bpindomieGoreng * 6500;
            hargaKg = bpkentangGoreng * 5000;
            hargaJc = bpjamurCryspy * 7000;

            hargaTh = bpTeh * 3000;
            hargaJr = bpJeruk * 4000;
            hargaSS = bpSusu * 5000;
            hargaKH = bpKopiHitam * 4500;
            hargaCap = bpCapucino * 6000;

            bptotalBiaya = hargaNg + hargaNa + hargaNtel + hargaNs + hargaNtong + hargaIndomR + hargaIndomG + hargaKg + hargaJc + hargaTh + hargaJc + hargaSS + hargaKH + hargaCap;
            bpPajak = bptotalBiaya * 0.1;
            bptotalPembayaran = bptotalBiaya + bpPajak;
            bpKembalian = bpUang - bptotalPembayaran;

            totalBiaya.Text = "Rp." + bptotalBiaya.ToString("N");
            pajak.Text = "Rp." + bpPajak.ToString("N");
            totalBayar.Text = "Rp." + bptotalPembayaran.ToString("N");
            Kembalian.Text = "Rp." + bpKembalian.ToString("N");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
