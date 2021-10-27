using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_uygulamasi_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++)
            {
                comboBox1.Items.Add(i);

            }
            for (int i = 1; i <= 30; i++)
            {
                comboBox2.Items.Add(i);
            }


        }


        int[] koltuklar;
        int[] salonlar;
        
        int fiyat,koltuk,bakiye;
        bool indirimli=false;
        string koltuksayi;


        private void button4_Click(object sender, EventArgs e)
        {
            bakiye_lbl.Text = bakiye.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bakiye <= 0 || koltuk <= 0)
            {
                MessageBox.Show("Satıcak bir biletiniz yok");
            }
            else
            {
                if (indirimli == true)
                {
                    bakiye = bakiye - 10;
                }
                else
                {
                    bakiye = bakiye - 15;

                }
                koltuk = koltuk + 1;
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            koltuk_lbl.Text = koltuk.ToString();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                fiyat = 10;
                indirimli = true;
            }
            else
            {
                fiyat = 15;
            }
            koltuk = koltuk - 1;
            bakiye = bakiye + fiyat;
            button2.Enabled = true;
            button4.Enabled = true;
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            salonlar = new int[int.Parse(comboBox1.Text)];
            koltuklar = new int[int.Parse(comboBox2.Text)];
            koltuksayi = comboBox2.Text;
            koltuk = int.Parse(koltuksayi);

            button1.Enabled = true;
            button3.Enabled = true;
        }
    }
}
