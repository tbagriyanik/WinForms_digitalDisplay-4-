using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace displayNesne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display _bizimSayi = new Display();
            _bizimSayi.Kapsayici = panel1; //nesneler buraya gelsin
            _bizimSayi.Deger = textBox1.Text;
            _bizimSayi.Renk = (radioButton1.Checked) ? 1 : (radioButton2.Checked) ? 2 : (radioButton3.Checked) ? 3 : 2;
            _bizimSayi.Goster();
        }
    }
}
