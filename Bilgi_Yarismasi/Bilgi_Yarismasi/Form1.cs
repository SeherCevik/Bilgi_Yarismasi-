using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //değişkenleri global alanda tanımlarız,her yerden erişilebilir olması için.
        //ve ilk değerleri olan sıfır ı değişkenlere atarız.

        int SoruNo=0, Dogru=0, Yanlis=0;

        private void sonrakiBtn_Click(object sender, EventArgs e)
        {
            //sonrakiBtn butonuna her tıklandığında cevap butonlarının tekraraktif olması için;
            Abtn.Enabled = true;
            Bbtn.Enabled = true;
            Cbtn.Enabled = true;
            Dbtn.Enabled = true;
            //cevap butonları aktif olduğunda da bir sonraki soruya geçilmemesi için;
            sonrakiBtn.Enabled = false;

            //sonraki butonuna her tıklandığında soruno kısmının bir artması için;
            SoruNo++;
            SoruNolbl.Text = SoruNo.ToString();
            //soruları belirlemeye başlarız;
            //büyük küçük harf duyarlılığı var.
            if (SoruNo==1)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi zararlı yazılımlar arasındadır?";
                Abtn.Text = "Microsoft Office PowerPoint";
                Bbtn.Text = "Trojan (Truva Atı)";
                Cbtn.Text = "Microsoft Office Word";
                Dbtn.Text = "Google Chrome";
                //doğru değerin ataması için;
                //label4 sorunun doğru cevabını temsil ediyor.
                label4.Text = "Trojan (Truva Atı)";
               
            }
            if (SoruNo == 2)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi bir sistem yazılımıdır?";
                Abtn.Text = "Adobe Photoshop";
                Bbtn.Text = "Windows 10";
                Cbtn.Text = "İnternet Explorer";
                Dbtn.Text = "Google Chrome";
                label4.Text = "Windows 10";
            }
            if (SoruNo == 3)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi yazılıma örnek değildir?";
                Abtn.Text = "Windows";
                Bbtn.Text = "Windows Media Player";
                Cbtn.Text = "Fare";
                Dbtn.Text = "Anti virüs Programı";
                label4.Text = "Fare";
            }
            if (SoruNo==4)
            {
                richTextBox1.Text = "Yazılımın ilk sürümündeki hataları görmek ve eksiklikleri test etmek için yayımlanan haline ne denir?";
                Abtn.Text = "Lisanslı Yazılım";
                Bbtn.Text = "Freeware";
                Cbtn.Text = "Beta Yazılım";
                Dbtn.Text = " Ücretsiz Yazılım";
                label4.Text = "Beta Yazılım";
            }
            if (SoruNo==5)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi uygulama yazılımı türlerinden değildir?";
                Abtn.Text = "Sunum Programları";
                Bbtn.Text = " Sürücüler (Drivers)";
                Cbtn.Text = "Media Oynatıcılar (Players)";
                Dbtn.Text = "Anti virüs Programları";
                label4.Text = "Sürücüler (Drivers)";

                //5 soru olduğu için 6. soruya geçilemez bu nedenle sorular bittikten sonta sonraki butonun yerini sonuçlar almalı.
                sonrakiBtn.Text = "SONUÇLAR";
            }
            if (SoruNo==6)
            {
                //6.soru olmadığı için tüm şıkların artık tıklanmaz olması gerekir.
                Abtn.Enabled = false;
                Bbtn.Enabled = false;
                Cbtn.Enabled = false;
                Dbtn.Enabled = false;
                sonrakiBtn.Enabled = false;
                MessageBox.Show("DOĞRU SAYISI: " + Dogru + "\n" + "YANLIŞ SAYISI: " + Yanlis);
            }
        }

        private void Abtn_Click(object sender, EventArgs e)
        {
            //butona tıklandıktan sonra birdaha hicbir cevap butonuna tıklanmaması için tüm butonların enabled olması gerekir. tıklanmaya devam edilirse doğru ve yanlış sayısı gereksiz artmaya devam eder.
            Abtn.Enabled = false;
            Bbtn.Enabled = false;
            Cbtn.Enabled = false;
            Dbtn.Enabled = false;
            //cevap butonları pasif olduğunda bir sonraki soruya geçilebilmesi için;
            sonrakiBtn.Enabled = true;
            //label5 bizim soruya vereceğimiz cevabı temsil ediyor.
            //Eger a butonuna tıklarsak üstündeki değeri label5 e aktarması için;
            label5.Text = Abtn.Text;
            //Eğer sorunun doğru cevabı benim verdiğim cevaba eşit ise doğru sayısı 1 artsın.;
            if (label4.Text==label5.Text)
            {
                Dogru++;
                //istatistik panelinde doğru sayısının artması için;
                Dogrulbl.Text = Dogru.ToString();
                //sonuç doğru cıkarsa doğru gif i çalışmaya başlasın.
                dogrugif.Visible = true;
                yanlisGif.Visible = false;

            }
            else
            {
                Yanlis++;
                Yanlislbl.Text = Yanlis.ToString();
                yanlisGif.Visible = true;
                dogrugif.Visible = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Abtn.Enabled = false;
            Bbtn.Enabled = false;
            Cbtn.Enabled = false;
            Dbtn.Enabled = false;
            sonrakiBtn.Enabled = true;

            label5.Text = Bbtn.Text;
            if (label4.Text == label5.Text)
            {
                Dogru++;
                Dogrulbl.Text = Dogru.ToString();
                dogrugif.Visible = true;
                yanlisGif.Visible = false;


            }
            else
            {
                Yanlis++;
                Yanlislbl.Text = Yanlis.ToString();
                yanlisGif.Visible = true;
                dogrugif.Visible = false;
            }
        }


        private void Cbtn_Click(object sender, EventArgs e)
        {
            Abtn.Enabled = false;
            Bbtn.Enabled = false;
            Cbtn.Enabled = false;
            Dbtn.Enabled = false;
            sonrakiBtn.Enabled = true;

            label5.Text = Cbtn.Text;

            if (label4.Text==label5.Text)
            {
                Dogru++;
                Dogrulbl.Text = Dogru.ToString();
                dogrugif.Visible = true;
                yanlisGif.Visible = false;
            }
            else
            {
                Yanlis++;
                Yanlislbl.Text = Yanlis.ToString();
                yanlisGif.Visible = true;
                dogrugif.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Abtn.Enabled = false;
            Bbtn.Enabled = false;
            Cbtn.Enabled = false;
            Dbtn.Enabled = false;
            sonrakiBtn.Enabled = true;
            label5.Text = Dbtn.Text;

            if (label4.Text == label5.Text)
            {
                Dogru++;
                Dogrulbl.Text = Dogru.ToString();
                dogrugif.Visible = true;
                yanlisGif.Visible = false;
            }
            else
            {
                Yanlis++;
                Yanlislbl.Text = Yanlis.ToString();
                yanlisGif.Visible = true;
                dogrugif.Visible = false;
            }
        }
    }
}
