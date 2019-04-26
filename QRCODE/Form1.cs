using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCODE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklık, ikinciatsolauzaklık, ucuncuatsolauzaklık;

        Random rastgele = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label7.Text);
            derece++;
            label7.Text = derece.ToString();


            int birinciatgenislik = pictureBox1.Width;
            int ikinciiatgenislik = pictureBox2.Width;
            int ucuncuatgenislik = pictureBox3.Width;

            int bitisuzaklıgı = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "1 numaralı at yarısı önde götürüyor";
            }
            if(pictureBox2.Left>pictureBox1.Left+5 &&pictureBox2.Left>pictureBox3.Left+5)
            {
                label6.Text = "2 NUMARALI ATAK YAPTI VE ÖNE GEÇTİ";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox2.Left + 5)
            {
                label6.Text = "3. NUMAARLI AT LİDERLİĞİ ELE GEÇİRDİ";
            }

            if(birinciatgenislik+pictureBox1.Left>=bitisuzaklıgı)
            {
                timer1.Enabled = false;
                label6.Text="1 numaralı at yarısı kazandı";
            }
            if (birinciatgenislik + pictureBox2.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                label6.Text = "2 numaralı at yarısı kazandı";
            }
            if (birinciatgenislik + pictureBox3.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                label6.Text = "3 numaralı at yarısı kazandı";
            }
       


        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            int süre = 0;
            label6.Text = "";
            label7.Text = süre.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklık = pictureBox1.Left;
            ikinciatsolauzaklık = pictureBox2.Left;
            ucuncuatsolauzaklık = pictureBox3.Left;
        }
    }
}
