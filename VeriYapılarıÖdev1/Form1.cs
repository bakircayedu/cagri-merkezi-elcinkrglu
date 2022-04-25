using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapılarıÖdev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //Arama yap butonu tıklandığında Arama Listesine elemanı ekler.
        private void btnAramaYap_Click(object sender, EventArgs e)
        {   
            
            Arama arama  = new Arama(1000);
            arama.Enqueue(txtMusteriID.Text);
            lbAramaListesi.Items.Add(arama.Display());
           
        }

        //Çağrı Ata butonu tıklandığında bireysel veya ticari kontrolü sağlandıktan sonra listeleri çağrıları ekler.
        private void btnCagriAta_Click(object sender, EventArgs e)
        {   
            Arama cagri = new Arama(1000);
            Cagri cgr = new Cagri();
            if (cbBireysel.Checked)
            {
                lbBireyselCagriListesi.Items.Clear();
                cagri.Enqueue(txtMusteriID2.Text);
                cgr.BaslamaZamanı = DateTime.Now;
                lbBireyselCagriListesi.Items.Add(cagri.Display());
                cgr.Cagri++;
                
            }
            else if (cbTicari.Checked)
            {
                lbticariCagriListesi.Items.Clear();
                cagri.Enqueue(txtMusteriID2.Text);
                cgr.BaslamaZamanı = DateTime.Now;
                lbticariCagriListesi.Items.Add(cagri.Display());
                cgr.Cagri++;
                
            }

            else
                MessageBox.Show("Seçim yapın");
            
        }
        // Çağrıyı bitirir.
        private void btnCagriBitir_Click(object sender, EventArgs e)
        {
            Cagri cgr = new Cagri();
            cgr.BitisZamanı = DateTime.Now;
            MessageBox.Show("Çağrı Sonlandı.");
            lbticariCagriListesi.Items.Clear();
            lbBireyselCagriListesi.Items.Clear();





        }
        // Girilen son çağrının ayrıntılarını listboxa yazar.
        private void btnCagriBilgileri_Click(object sender, EventArgs e)
        {

            Cagri cgr = new Cagri();
            cgr.Musteri = txtMusteriID.Text;
            if (cbBireysel.Checked)
                cgr.MusteriTuru = "Bireysel";
            if (cbTicari.Checked)
                cgr.MusteriTuru = "Ticari";
            
            lbCagriBilgileri.Items.Add(cgr.MusteriTuru);
            lbCagriBilgileri.Items.Add(cgr.Musteri);
            lbCagriBilgileri.Items.Add("Cagri Sayisi Toplam" +cgr.Cagri);
        }
        //Girilen notu ekler.
        private void btnNotlar_Click(object sender, EventArgs e)
        {
            Arama arama = new Arama(1000);
            Notlar not = new Notlar();
            not.Not= txtNotlar.ToString();
            arama.NotEkle(not);

        }
        //eklenen notlar arasında arama yapar.
        private void btnNotAra_Click(object sender, EventArgs e)
        {
            {
                List<Notlar> arama = new List<Notlar>();
                string Aranan= arama.ToString();
                string ara =txtAranan.Text;
                int sonuc;
                sonuc = Aranan.IndexOf(ara ,0, Aranan.Length - 1);
                if (sonuc == -1)
                {
                    MessageBox.Show("Aradığınız Değer Bulunamadı");
                }
                else
                {
                    MessageBox.Show(sonuc.ToString() );
                }
            }
        }
    }
}
    
        
 
    

