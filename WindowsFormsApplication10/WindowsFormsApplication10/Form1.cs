using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap black_screen = Properties.Resources.mqdefault;
        Bitmap crown = Properties.Resources.crown_no_bg;
        Bitmap dot = Properties.Resources.primitive_dot;
        int total_queen = 0;
        int queens_left = 8;
        public void winner() {

            if (total_queen == 8)
            {
                MessageBox.Show("you win!!! well done");

            }
            else {

                queens_left = queens_left - total_queen;
                MessageBox.Show(queens_left + " queens left to go");
                 queens_left = 8;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = black_screen;
            pictureBox2.Image = black_screen;
            pictureBox3.Image = black_screen;
            pictureBox4.Image = black_screen;
            pictureBox5.Image = black_screen;
            pictureBox6.Image = black_screen;
            pictureBox7.Image = black_screen;
            pictureBox8.Image = black_screen;
            pictureBox9.Image = black_screen;
            pictureBox10.Image = black_screen;
            pictureBox11.Image = black_screen;
            pictureBox12.Image = black_screen;
            pictureBox13.Image = black_screen;
            pictureBox14.Image = black_screen;
            pictureBox15.Image = black_screen;
            pictureBox16.Image = black_screen;
            pictureBox17.Image = black_screen;
            pictureBox18.Image = black_screen;
            pictureBox19.Image = black_screen;
            pictureBox20.Image = black_screen;
            pictureBox21.Image = black_screen;
            pictureBox22.Image = black_screen;
            pictureBox23.Image = black_screen;
            pictureBox24.Image = black_screen;
            pictureBox25.Image = black_screen;
            pictureBox26.Image = black_screen;
            pictureBox27.Image = black_screen;
            pictureBox27.Image = black_screen;
            pictureBox28.Image = black_screen;
            pictureBox29.Image = black_screen;
            pictureBox30.Image = black_screen;
            pictureBox31.Image = black_screen;
            pictureBox32.Image = black_screen;
            pictureBox33.Image = black_screen;
            pictureBox34.Image = black_screen;
            pictureBox35.Image = black_screen;
            pictureBox36.Image = black_screen;
            pictureBox37.Image = black_screen;
            pictureBox38.Image = black_screen;
            pictureBox39.Image = black_screen;
            pictureBox40.Image = black_screen;
            pictureBox41.Image = black_screen;
            pictureBox42.Image = black_screen;
            pictureBox43.Image = black_screen;
            pictureBox44.Image = black_screen;
            pictureBox45.Image = black_screen;
            pictureBox46.Image = black_screen;
            pictureBox47.Image = black_screen;
            pictureBox48.Image = black_screen;
            pictureBox49.Image = black_screen;
            pictureBox50.Image = black_screen;
            pictureBox51.Image = black_screen;
            pictureBox52.Image = black_screen;
            pictureBox53.Image = black_screen;
            pictureBox54.Image = black_screen;
            pictureBox55.Image = black_screen;
            pictureBox56.Image = black_screen;
            pictureBox57.Image = black_screen;
            pictureBox58.Image = black_screen;
            pictureBox59.Image = black_screen;
            pictureBox60.Image = black_screen;
            pictureBox61.Image = black_screen;
            pictureBox62.Image = black_screen;
            pictureBox63.Image = black_screen;
            pictureBox64.Image = black_screen;
            total_queen = 0;
        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == dot)
            {

                MessageBox.Show("you cant put queen here");


            }
            else {
                pictureBox1.Image = crown;
                pictureBox11.Image = dot;
                pictureBox9.Image = dot;
                pictureBox10.Image = dot;
                pictureBox12.Image = dot;
                pictureBox13.Image = dot;
                pictureBox14.Image = dot;
                pictureBox57.Image = dot;
                pictureBox15.Image = dot;
                pictureBox21.Image = dot;
                pictureBox29.Image = dot;
                pictureBox36.Image = dot;
                pictureBox43.Image = dot;
                pictureBox50.Image = dot;
                pictureBox7.Image = dot;
                pictureBox24.Image = dot;
                pictureBox16.Image = dot;
                pictureBox32.Image = dot;
                pictureBox40.Image = dot;
                pictureBox48.Image = dot;
                pictureBox56.Image = dot;
                pictureBox64.Image = dot;
                total_queen++;
                winner();
            
            }
            
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = crown;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = crown;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = crown;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = crown;
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = crown;
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = crown;
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = crown;
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Image == dot)
            {
                MessageBox.Show("you cant put queen here");
                

            }
            else
            {
                pictureBox9.Image = crown;
                pictureBox1.Image = dot;
                pictureBox11.Image = dot;
                pictureBox15.Image = dot;
                pictureBox10.Image = dot;
                pictureBox12.Image = dot;
                pictureBox13.Image = dot;
                pictureBox14.Image = dot;
                pictureBox57.Image = dot;
                pictureBox15.Image = dot;
                pictureBox23.Image = dot;
                pictureBox30.Image = dot;
                pictureBox37.Image = dot;
                pictureBox44.Image = dot;
                pictureBox51.Image = dot;
                pictureBox8.Image = dot;
                pictureBox24.Image = dot;
                pictureBox17.Image = dot;
                pictureBox25.Image = dot;
                pictureBox33.Image = dot;
                pictureBox41.Image = dot;
                pictureBox49.Image = dot;
                pictureBox63.Image = dot;
                total_queen++;
                winner();

            }
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox10.Image == dot)
            {
                MessageBox.Show("you cant put queen here");


            }
            else
            {
                pictureBox10.Image= crown;
                pictureBox1.Image = dot;
                pictureBox11.Image = dot;
                pictureBox12.Image = dot;
                pictureBox13.Image = dot;
                pictureBox14.Image = dot;
                pictureBox57.Image = dot;
                pictureBox24.Image = dot;
                pictureBox21.Image = dot;
                pictureBox17.Image = dot;
                pictureBox16.Image = dot;
                pictureBox31.Image = dot;
                pictureBox9.Image = dot;
                pictureBox45.Image = dot;
                pictureBox52.Image = dot;
                pictureBox6.Image = dot;
                pictureBox18.Image = dot;
                pictureBox26.Image = dot;
                pictureBox34.Image = dot;
                pictureBox42.Image = dot;
                pictureBox62.Image = dot;
                pictureBox38.Image = dot;
                total_queen++;
                winner();

            }
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (pictureBox11.Image == dot)
            {
                MessageBox.Show("you cant put queen here");


            }
            else
            {
                pictureBox11.Image = crown;
                pictureBox1.Image = dot;
                pictureBox9.Image = dot;
                pictureBox10.Image = dot;
                pictureBox19.Image = dot;
                pictureBox12.Image = dot;
                pictureBox13.Image = dot;
                pictureBox14.Image = dot;
                pictureBox57.Image = dot;
                pictureBox18.Image = dot;
                pictureBox25.Image = dot;
                pictureBox39.Image = dot;
                pictureBox46.Image = dot;
                pictureBox53.Image = dot;
                pictureBox3.Image = dot;
                pictureBox17.Image = dot;
                pictureBox23.Image = dot;
                pictureBox29.Image = dot;
                pictureBox19.Image = dot;
                pictureBox27.Image = dot;
                pictureBox35.Image = dot;
                pictureBox61.Image = dot;
                pictureBox32.Image = dot;
                total_queen++;
                winner();
            }
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image == dot)
            {
                MessageBox.Show("you cant put queen here");


            }
            else
            {
                pictureBox12.Image = crown;
                pictureBox1.Image = dot;
                pictureBox9.Image = dot;
                pictureBox10.Image = dot;
                pictureBox19.Image = dot;
                pictureBox11.Image = dot;
                pictureBox13.Image = dot;
                pictureBox14.Image = dot;
                pictureBox57.Image = dot;
                pictureBox26.Image = dot;
                pictureBox40.Image = dot;
                pictureBox47.Image = dot;
                pictureBox54.Image = dot;
                pictureBox2.Image = dot;
                pictureBox18.Image = dot;
                pictureBox16.Image = dot;
                pictureBox30.Image = dot;
                pictureBox36.Image = dot;
                pictureBox20.Image = dot;
                pictureBox28.Image = dot;
                pictureBox60.Image = dot;
                pictureBox33.Image = dot;
                total_queen++;
                winner();

            }
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (pictureBox13.Image == dot)
            {
                MessageBox.Show("you cant put queen here");


            }
            else
            {
                pictureBox13.Image = crown;
                pictureBox1.Image = dot;
                pictureBox9.Image = dot;
                pictureBox10.Image = dot;
                pictureBox11.Image = dot;
                pictureBox19.Image = dot;
                pictureBox25.Image = dot;
                pictureBox31.Image = dot;
                pictureBox37.Image = dot;
                pictureBox43.Image = dot;
                pictureBox14.Image = dot;
                pictureBox57.Image = dot;
                pictureBox20.Image = dot;
                pictureBox27.Image = dot;
                pictureBox34.Image = dot;
                pictureBox41.Image = dot;
                pictureBox48.Image = dot;
                pictureBox55.Image = dot;
                pictureBox5.Image = dot;
                pictureBox22.Image = dot;
                pictureBox59.Image = dot;
                pictureBox12.Image = dot;
                total_queen++;
                winner();
            }
        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (pictureBox14.Image == dot)
            {
                MessageBox.Show("you cant put queen here");


            }
            else
            {
                pictureBox14.Image = crown;
                pictureBox1.Image = dot;
                pictureBox9.Image = dot;
                pictureBox10.Image = dot;
                pictureBox11.Image = dot;
                pictureBox12.Image = dot;
                pictureBox57.Image = dot;
                pictureBox22.Image = dot;
                pictureBox28.Image = dot;
                pictureBox35.Image = dot;
                pictureBox42.Image = dot;
                pictureBox49.Image = dot;
                pictureBox56.Image = dot;
                pictureBox4.Image = dot;
                pictureBox58.Image = dot;
                pictureBox20.Image = dot;
                pictureBox26.Image = dot;
                pictureBox32.Image = dot;
                pictureBox38.Image = dot;
                pictureBox44.Image = dot;
                pictureBox50.Image = dot;
                pictureBox13.Image = dot;
                total_queen++;
                winner();
            }
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (pictureBox15.Image == dot)
            {
                MessageBox.Show("you cant put queen here");


            }
            else
            {
                pictureBox15.Image = crown;
                pictureBox24.Image = dot;
                pictureBox17.Image = dot;
                pictureBox18.Image = dot;
                pictureBox19.Image = dot;
                pictureBox20.Image = dot;
                pictureBox22.Image = dot;
                pictureBox58.Image = dot;
                pictureBox21.Image = dot;
                pictureBox29.Image = dot;
                pictureBox36.Image = dot;
                pictureBox43.Image = dot;
                pictureBox50.Image = dot;
                pictureBox7.Image = dot;
                pictureBox1.Image = dot;
                pictureBox9.Image = dot;
                pictureBox23.Image = dot;
                pictureBox31.Image = dot;
                pictureBox39.Image = dot;
                pictureBox47.Image = dot;
                pictureBox55.Image = dot;
                pictureBox4.Image = dot;
                total_queen++;
                winner();
            }
        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Image = crown;
        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Image == dot)
            {
                MessageBox.Show("you cant put queen here");


            }
            else
            {
                pictureBox17.Image = crown;
                pictureBox15.Image = dot;
                pictureBox24.Image = dot;
                pictureBox18.Image = dot;
                pictureBox19.Image = dot;
                pictureBox20.Image = dot;
                pictureBox22.Image = dot;
                pictureBox58.Image = dot;
                pictureBox10.Image = dot;
                pictureBox16.Image = dot;
                pictureBox31.Image = dot;
                pictureBox38.Image = dot;
                pictureBox45.Image = dot;
                pictureBox52.Image = dot;
                pictureBox6.Image = dot;
                pictureBox11.Image = dot;
                pictureBox23.Image = dot;
                pictureBox29.Image = dot;
                pictureBox9.Image = dot;
                pictureBox25.Image = dot;
                pictureBox33.Image = dot;
                pictureBox41.Image = dot;
                pictureBox49.Image = dot;
                pictureBox63.Image = dot;
                total_queen++;
                winner();
            }
        }
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (pictureBox18.Image == dot)
            {
                MessageBox.Show("you cant put queen here");


            }
            else
            {
                pictureBox18.Image = crown;
                pictureBox24.Image = dot;
                pictureBox17.Image = dot;
                pictureBox15.Image = dot;
                pictureBox19.Image = dot;
                pictureBox20.Image = dot;
                pictureBox22.Image = dot;
                pictureBox58.Image = dot;
                pictureBox11.Image = dot;
                pictureBox25.Image = dot;
                pictureBox32.Image = dot;
                pictureBox39.Image = dot;
                pictureBox46.Image = dot;
                pictureBox53.Image = dot;
                pictureBox3.Image = dot;
                pictureBox12.Image = dot;
                pictureBox16.Image = dot;
                pictureBox30.Image = dot;
                pictureBox36.Image = dot;
                pictureBox10.Image = dot;
                pictureBox26.Image = dot;
                pictureBox34.Image = dot;
                pictureBox42.Image = dot;
                pictureBox62.Image = dot;
                total_queen++;
                winner();
            }
        }
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (pictureBox19.Image == dot)
            {
                MessageBox.Show("you cant put queen here");


            }
            else
            {
                pictureBox19.Image = crown;
                pictureBox24.Image = dot;
                pictureBox17.Image = dot;
                pictureBox15.Image = dot;
                pictureBox18.Image = dot;
                pictureBox20.Image = dot;
                pictureBox22.Image = dot;
                pictureBox58.Image = dot;
                pictureBox12.Image = dot;
                pictureBox26.Image = dot;
                pictureBox33.Image = dot;
                pictureBox40.Image = dot;
                pictureBox47.Image = dot;
                pictureBox54.Image = dot;
                pictureBox2.Image = dot;
                pictureBox11.Image = dot;
                pictureBox27.Image = dot;
                pictureBox35.Image = dot;
                pictureBox61.Image = dot;
                pictureBox13.Image = dot;
                pictureBox25.Image = dot;
                pictureBox31.Image = dot;
                pictureBox37.Image = dot;
                pictureBox43.Image = dot;
                total_queen++;
                winner();
            }
        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (pictureBox20.Image == dot)
            {
                MessageBox.Show("you cant put queen here");


            }
            else
            {
                pictureBox20.Image = crown;
                pictureBox24.Image = dot;
                pictureBox17.Image = dot;
                pictureBox15.Image = dot;
                pictureBox18.Image = dot;
                pictureBox19.Image = dot;
                pictureBox22.Image = dot;
                pictureBox58.Image = dot;
                pictureBox13.Image = dot;
                pictureBox27.Image = dot;
                pictureBox34.Image = dot;
                pictureBox41.Image = dot;
                pictureBox48.Image = dot;
                pictureBox55.Image = dot;
                pictureBox5.Image = dot;
                pictureBox12.Image = dot;
                pictureBox28.Image = dot;
                pictureBox60.Image = dot;
                pictureBox14.Image = dot;
                pictureBox26.Image = dot;
                pictureBox32.Image = dot;
                pictureBox38.Image = dot;
                pictureBox44.Image = dot;
                pictureBox50.Image = dot;
                total_queen++;
                winner();
            }
        }
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            pictureBox21.Image = crown;
        }
        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (pictureBox20.Image == dot)
            {
                MessageBox.Show("you cant put queen here");


            }
            else
            {
                pictureBox22.Image = crown;
                pictureBox24.Image = dot;
                pictureBox17.Image = dot;
                pictureBox15.Image = dot;
                pictureBox18.Image = dot;
                pictureBox19.Image = dot;
                pictureBox20.Image = dot;
                pictureBox58.Image = dot;
                pictureBox14.Image = dot;
                pictureBox28.Image = dot;
                pictureBox35.Image = dot;
                pictureBox42.Image = dot;
                pictureBox49.Image = dot;
                pictureBox56.Image = dot;
                pictureBox4.Image = dot;
                pictureBox13.Image = dot;
                pictureBox59.Image = dot;
                pictureBox57.Image = dot;
                pictureBox14.Image = dot;
                pictureBox26.Image = dot;
                pictureBox32.Image = dot;
                pictureBox38.Image = dot;
                pictureBox44.Image = dot;
                pictureBox50.Image = dot;
                total_queen++;
                winner();
            }
        }
        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pictureBox23.Image = crown;
        }
        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (pictureBox24.Image == dot)
            {
                MessageBox.Show("you cant put queen here");


            }
            else
            {
                pictureBox24.Image = crown;
                pictureBox15.Image = dot;
                pictureBox17.Image = dot;
                pictureBox18.Image = dot;
                pictureBox19.Image = dot;
                pictureBox20.Image = dot;
                pictureBox22.Image = dot;
                pictureBox58.Image = dot;
                pictureBox21.Image = dot;
                pictureBox10.Image = dot;
                pictureBox1.Image = dot;
                pictureBox16.Image = dot;
                pictureBox32.Image = dot;
                pictureBox40.Image = dot;
                pictureBox40.Image = dot;
                pictureBox48.Image = dot;
                pictureBox56.Image = dot;
                pictureBox64.Image = dot;
                pictureBox9.Image = dot;
                pictureBox23.Image = dot;
                pictureBox30.Image = dot;
                pictureBox37.Image = dot;
                pictureBox44.Image = dot;
                pictureBox51.Image = dot;
                pictureBox8.Image = dot;
                total_queen++;
                winner();
            }
        }
        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pictureBox25.Image = crown;
        }
        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pictureBox26.Image = crown;
        }
        private void pictureBox27_Click(object sender, EventArgs e)
        {
            pictureBox27.Image = crown;
        }
        private void pictureBox28_Click(object sender, EventArgs e)
        {
            pictureBox28.Image = crown;
        }
        private void pictureBox29_Click(object sender, EventArgs e)
        {
            pictureBox29.Image = crown;
        }
        private void pictureBox30_Click(object sender, EventArgs e)
        {
            pictureBox30.Image = crown;
        }
        private void pictureBox31_Click(object sender, EventArgs e)
        {
            pictureBox31.Image = crown;
        }
        private void pictureBox32_Click(object sender, EventArgs e)
        {
            pictureBox32.Image = crown;
        }
        private void pictureBox33_Click(object sender, EventArgs e)
        {
            pictureBox33.Image = crown;
        }
        private void pictureBox34_Click(object sender, EventArgs e)
        {
            pictureBox34.Image = crown;
        }
        private void pictureBox35_Click(object sender, EventArgs e)
        {
            pictureBox35.Image = crown;
        }
        private void pictureBox36_Click(object sender, EventArgs e)
        {
            pictureBox36.Image = crown;
        }
        private void pictureBox37_Click(object sender, EventArgs e)
        {
            pictureBox37.Image = crown;
        }
        private void pictureBox38_Click(object sender, EventArgs e)
        {
            pictureBox38.Image = crown;
        }
        private void pictureBox39_Click(object sender, EventArgs e)
        {
            pictureBox39.Image = crown;
        }
        private void pictureBox40_Click(object sender, EventArgs e)
        {
            pictureBox40.Image = crown;
        }
        private void pictureBox41_Click(object sender, EventArgs e)
        {
            pictureBox41.Image = crown;
        }
        private void pictureBox42_Click(object sender, EventArgs e)
        {
            pictureBox42.Image = crown;
        }
        private void pictureBox43_Click(object sender, EventArgs e)
        {
            pictureBox43.Image = crown;
        }
        private void pictureBox44_Click(object sender, EventArgs e)
        {
            pictureBox44.Image = crown;
        }
        private void pictureBox45_Click(object sender, EventArgs e)
        {
            pictureBox45.Image = crown;
        }
        private void pictureBox46_Click(object sender, EventArgs e)
        {
            pictureBox46.Image = crown;
        }
        private void pictureBox47_Click(object sender, EventArgs e)
        {
            pictureBox47.Image = crown;
        }
        private void pictureBox48_Click(object sender, EventArgs e)
        {
            pictureBox48.Image = crown;
        }
        private void pictureBox49_Click(object sender, EventArgs e)
        {
            pictureBox49.Image = crown;
        }
        private void pictureBox50_Click(object sender, EventArgs e)
        {
            pictureBox50.Image = crown;
        }
        private void pictureBox51_Click(object sender, EventArgs e)
        {
            pictureBox51.Image = crown;
        }
        private void pictureBox52_Click(object sender, EventArgs e)
        {
            pictureBox52.Image = crown;
        }
        private void pictureBox53_Click(object sender, EventArgs e)
        {
            pictureBox53.Image = crown;
        }
        private void pictureBox54_Click(object sender, EventArgs e)
        {
            pictureBox54.Image = crown;
        }
        private void pictureBox55_Click(object sender, EventArgs e)
        {
            pictureBox55.Image = crown;
        }
        private void pictureBox56_Click(object sender, EventArgs e)
        {
            pictureBox56.Image = crown;
        }
        private void pictureBox57_Click(object sender, EventArgs e)
        {
            if (pictureBox57.Image == dot)
            {
                MessageBox.Show("you cant put queen here");


            }
            else
            {
                pictureBox57.Image = crown;
                pictureBox1.Image = dot;
                pictureBox9.Image = dot;
                pictureBox10.Image = dot;
                pictureBox11.Image = dot;
                pictureBox12.Image = dot;
                pictureBox58.Image = dot;
                pictureBox59.Image = dot;
                pictureBox60.Image = dot;
                pictureBox61.Image = dot;
                pictureBox62.Image = dot;
                pictureBox63.Image = dot;
                pictureBox64.Image = dot;
                pictureBox22.Image = dot;
                pictureBox27.Image = dot;
                pictureBox33.Image = dot;
                pictureBox39.Image = dot;
                pictureBox45.Image = dot;
                pictureBox51.Image = dot;
                pictureBox7.Image = dot;
                pictureBox13.Image = dot;
                pictureBox14.Image = dot;
                total_queen++;
                winner();
            }
        }
        private void pictureBox58_Click(object sender, EventArgs e)
        {
            pictureBox58.Image = crown;
        }
        private void pictureBox59_Click(object sender, EventArgs e)
        {
            pictureBox59.Image = crown;
        }
        private void pictureBox60_Click(object sender, EventArgs e)
        {
            pictureBox60.Image = crown;
        }
        private void pictureBox61_Click(object sender, EventArgs e)
        {
            pictureBox61.Image = crown;
        }
        private void pictureBox62_Click(object sender, EventArgs e)
        {
            pictureBox62.Image = crown;
        }
        private void pictureBox63_Click(object sender, EventArgs e)
        {
            pictureBox63.Image = crown;
        }
        private void pictureBox64_Click(object sender, EventArgs e)
        {
            pictureBox64.Image = crown;
        }



    }
}
