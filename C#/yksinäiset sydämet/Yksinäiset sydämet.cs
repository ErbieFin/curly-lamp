using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yksinäiset_sydämet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nimi;
            int ika;
            nimi = nameBox.Text;
            ika = int.Parse(ageBox.Text);

            if (ika < 18)
            {
                MessageBox.Show("Olet alaikäinen, mene Nuorisoklubille!");

            }

            else if (ika < 25)
            {
                MessageBox.Show("Olet nuori aikuinen, mene Nuorten Aikuisten Klubille");


            }

            else if (ika < 40)
            {
                MessageBox.Show("Taidat olla naimisissa, oletkohan oikealla sivustolla??");

            }

            else if (ika < 60)
            {
                MessageBox.Show("Olet ollut jo liian kauan naimisissa joten kaipaan Swingerklubia!!");
            }

            else if (ika > 100)
            {
                MessageBox.Show("Olet varttunut lady tai herrasmies joten Varttuneiden Klubi on paikkasi!");

            }

            else if (ika < 150)

                MessageBox.Show("Hey WTF??? :o");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
