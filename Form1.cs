using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taş_Kağıt_Makas_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }
             
        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.SteelBlue;
        }
        int playerskor = 0;
        int pcskor = 0;
        Random x = new Random();
        string sonuc;

        private void oyna (string playersecim)
        {
            string[] seceneklerss = { "Taş", "Kağıt", "Makas" };
            string pcsecim = seceneklerss[x.Next(0, 3)];
            string ad = Convert.ToString(textBox1.Text);


            if (pcsecim == playersecim) {
                sonuc = "Berabere";

            }
            else if ((playersecim == "Taş" && pcsecim == "Makas") ||
                    (playersecim == "Kağıt" && pcsecim == "Taş") ||
                    (playersecim == "Makas" && pcsecim == "Kağıt"))

            {
                sonuc = "Kazandın";
                playerskor=playerskor+1;
            }


            else
            {
                sonuc = "Aİ Kazandı";
                pcskor = pcskor + 1;
            }

            label2.Text = ad + " :" + playersecim + " | Aİ : " + pcsecim + " | " + sonuc;
            label3.Text = ad + " :" + playerskor + " | Aİ : " + pcskor + " | " + sonuc;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            oyna("Taş");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oyna("Kağıt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oyna("Makas");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            playerskor = 0;
            pcskor = 0;
            label3.Text = "Oyun sıfırlandı";
            label2.Text = "RESET";
            
        }     
    }
}
