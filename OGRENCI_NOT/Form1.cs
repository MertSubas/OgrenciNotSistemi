using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITIYLAYER;
using FACADLAYER1;
using BUSINESSLOGICLAYER;



namespace OGRENCI_NOT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void OgrenciListesi()
        {
            List<ENTITIYOGRENCI> Ogrlist = BLLOGRENCI.LISTELE();
            dataGridView1.DataSource=Ogrlist;
            this.Text = "Öğrenci Listesi";
        }
        void NotListesi()
        {
            List<ENTITYNOTLAR> EntNot = BLLNOTLAR.LISTELE();
            dataGridView1.DataSource = EntNot;
            this.Text = "Not Listesi";
        }
        void Kuluplistesi()
        {
            List<ENTITYKULUP> Klplst=BLLKULUP.LISTELE();
            CmbKulup.DisplayMember = "KULUPAD";
            CmbKulup.ValueMember = "KULUPID";
            CmbKulup.DataSource = Klplst ;
            dataGridView1.DataSource=Klplst;
            this.Text = "Kulüp Listesi";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OgrenciListesi();
            Kuluplistesi();
            //NotListesi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Text == "Öğrenci Listesi")
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                
                txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                txtAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                TXTSOYAD.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                txtFOTO.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            }
            if (this.Text=="Not Listesi")
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                TxtnotID.Text=dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                txtAD.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
                TXTSOYAD.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
                txtSINAV1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                txtSINAV2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                txtSINAV3.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                txtProje.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                TxtORTALAMA.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
                TxtDURUM.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            }
        }

        private void btnKAYDET_Click(object sender, EventArgs e)
        {
            ENTITIYOGRENCI ent = new ENTITIYOGRENCI();
            ent.AD=txtAD.Text;
            ent.SOYAD = TXTSOYAD.Text;
            ent.FOTOGRAF = txtFOTO.Text;
            ent.KULUPID = Convert.ToInt16(CmbKulup.SelectedValue);
            BLLOGRENCI.EKLE(ent);
            MessageBox.Show("Öğrenci Kaydı Yapıldı");
            OgrenciListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            OgrenciListesi();
        }


        private void BtnGuncelle_Click (object sender, EventArgs e)
        {
            
                ENTITIYOGRENCI ent = new ENTITIYOGRENCI();

                ent.AD = txtAD.Text;
                ent.SOYAD = TXTSOYAD.Text;
                ent.FOTOGRAF = txtFOTO.Text;
                ent.KULUPID = Convert.ToInt16(CmbKulup.SelectedValue);
                ent.ID = Convert.ToInt16(txtID.Text);
                MessageBox.Show("Öğrenci Bilgileri Güncellendi");
                BLLOGRENCI.GUNCELLE(ent);
                OgrenciListesi(); 

            
        }

        private void btnnotliste_Click(object sender, EventArgs e)
        {
            NotListesi();
        }

        private void btnnotguncel_Click(object sender, EventArgs e)
        {
            ENTITYNOTLAR ent = new ENTITYNOTLAR();
            ent.OGRENCIID = Convert.ToInt16(TxtnotID.Text);
            ent.SINAV1=Convert.ToInt16(txtSINAV1.Text);
            ent.SINAV2 = Convert.ToInt16(txtSINAV2.Text);
            ent.SINAV3 = Convert.ToInt16(txtSINAV3.Text);
            ent.PROJE = Convert.ToInt16(txtProje.Text);
            ent.ORTALAMA = Convert.ToInt16(TxtORTALAMA.Text);
            ent.DURUM= TxtDURUM.Text;
            BLLNOTLAR.GUNCELLE(ent);
            MessageBox.Show("Notlar Güncellendi");
            NotListesi();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, proje;
            double ortalama;
            string durum;
            s1 = Convert.ToInt16(txtSINAV1.Text);
            s2 = Convert.ToInt16(txtSINAV2.Text);
            s3= Convert.ToInt16(txtSINAV3.Text);
            proje = Convert.ToInt16(txtProje.Text);
            ortalama = (s1 + s2 + s3 + proje) / 4;
            TxtORTALAMA.Text=ortalama.ToString();
            if (ortalama > 50)
            {
                durum = "true";
            }
            else
            {
                durum = "false";
            }

            TxtDURUM.Text = durum;
        }

        private void btnkulupliste_Click(object sender, EventArgs e)
        {
            Kuluplistesi();
        }

        private void btnkulupguncelle_Click(object sender, EventArgs e)
        {
            ENTITYKULUP ent = new ENTITYKULUP();
            ent.KULUPAD = txtkulupad.Text;
            ent.KULUPID=Convert.ToInt16(txtkulupID.Text);
            BLLKULUP.GUNCELLE(ent);
            Kuluplistesi();


        }

        private void btnkulupkaydet_Click(object sender, EventArgs e)
        {
            ENTITYKULUP ent= new ENTITYKULUP();
         
            ent.KULUPAD = txtkulupad.Text;
            BLLKULUP.EKLE(ent);
            Kuluplistesi();
                
        }

        private void btnkulupsil_Click(object sender, EventArgs e)
        {
            ENTITYKULUP ent = new ENTITYKULUP();
            ent.KULUPID=Convert.ToInt16(txtkulupID.Text);
            BLLKULUP.SIL(ent.KULUPID);
            Kuluplistesi();



        }
    }
}
