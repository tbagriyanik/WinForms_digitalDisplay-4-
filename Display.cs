using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace displayNesne
{
    internal class Display
    {
        public string Deger { get; set; }
        public int Renk { get; set; }
        public Panel Kapsayici;


        public void Goster()
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            form1.Controls["panel1"].Controls.Clear(); //önce içini temizleyelim

            int sol = 10;
            char[] rakamlar = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i = 0; i < Deger.Length; i++)
            {
                if (!rakamlar.Contains(Deger[i])) continue; //başka şeyleri atlar

                myDisplay kopya = new myDisplay();
                kopya.Name = "display" + i;     //zorunda değiliz
                kopya.Width = 122;
                kopya.Height = 200;
                kopya.Left = sol;               //soldan başlar
                kopya.Top = 10;

                Color rengi = Color.Pink;
                if (Renk == 1) rengi = Color.Blue;
                else if (Renk == 2) rengi = Color.Green;
                else if (Renk == 3) rengi = Color.Red;

                if (Deger[i] == '0')
                {
                    kopya.Controls["panel2"].BackColor = rengi;
                    kopya.Controls["panel3"].BackColor = Color.LightYellow;
                    kopya.Controls["panel4"].BackColor = rengi;
                    kopya.Controls["panel5"].BackColor = rengi;
                    kopya.Controls["panel6"].BackColor = rengi;
                    kopya.Controls["panel7"].BackColor = rengi;
                    kopya.Controls["panel8"].BackColor = rengi;
                    if (i != Deger.Length - 1 && (Deger[i + 1] == '.' || Deger[i + 1] == ','))
                        kopya.Controls["panel9"].BackColor = rengi;
                    else
                        kopya.Controls["panel9"].BackColor = Color.LightYellow;
                }
                else if (Deger[i] == '1')
                {
                    kopya.Controls["panel2"].BackColor = Color.LightYellow;
                    kopya.Controls["panel3"].BackColor = Color.LightYellow;
                    kopya.Controls["panel4"].BackColor = Color.LightYellow;
                    kopya.Controls["panel5"].BackColor = Color.LightYellow;
                    kopya.Controls["panel6"].BackColor = rengi;
                    kopya.Controls["panel7"].BackColor = Color.LightYellow;
                    kopya.Controls["panel8"].BackColor = rengi;
                    if (i != Deger.Length - 1 && (Deger[i + 1] == '.' || Deger[i + 1] == ','))
                        kopya.Controls["panel9"].BackColor = rengi;
                    else
                        kopya.Controls["panel9"].BackColor = Color.LightYellow;
                }
                else if (Deger[i] == '2')
                {
                    kopya.Controls["panel2"].BackColor = rengi;
                    kopya.Controls["panel3"].BackColor = rengi;
                    kopya.Controls["panel4"].BackColor = rengi;
                    kopya.Controls["panel5"].BackColor = Color.LightYellow;
                    kopya.Controls["panel6"].BackColor = rengi;
                    kopya.Controls["panel7"].BackColor = rengi;
                    kopya.Controls["panel8"].BackColor = Color.LightYellow;
                    if (i != Deger.Length - 1 && (Deger[i + 1] == '.' || Deger[i + 1] == ','))
                        kopya.Controls["panel9"].BackColor = rengi;
                    else
                        kopya.Controls["panel9"].BackColor = Color.LightYellow;
                }
                else if (Deger[i] == '3')
                {
                    kopya.Controls["panel2"].BackColor = rengi;
                    kopya.Controls["panel3"].BackColor = rengi;
                    kopya.Controls["panel4"].BackColor = rengi;
                    kopya.Controls["panel5"].BackColor = Color.LightYellow;
                    kopya.Controls["panel6"].BackColor = rengi;
                    kopya.Controls["panel7"].BackColor = Color.LightYellow;
                    kopya.Controls["panel8"].BackColor = rengi;
                    if (i != Deger.Length - 1 && (Deger[i + 1] == '.' || Deger[i + 1] == ','))
                        kopya.Controls["panel9"].BackColor = rengi;
                    else
                        kopya.Controls["panel9"].BackColor = Color.LightYellow;
                }
                else if (Deger[i] == '4')
                {
                    kopya.Controls["panel2"].BackColor = Color.LightYellow;
                    kopya.Controls["panel3"].BackColor = rengi;
                    kopya.Controls["panel4"].BackColor = Color.LightYellow;
                    kopya.Controls["panel5"].BackColor = rengi;
                    kopya.Controls["panel6"].BackColor = rengi;
                    kopya.Controls["panel7"].BackColor = Color.LightYellow;
                    kopya.Controls["panel8"].BackColor = rengi;
                    if (i != Deger.Length - 1 && (Deger[i + 1] == '.' || Deger[i + 1] == ','))
                        kopya.Controls["panel9"].BackColor = rengi;
                    else
                        kopya.Controls["panel9"].BackColor = Color.LightYellow;
                }
                else if (Deger[i] == '5')
                {
                    kopya.Controls["panel2"].BackColor = rengi;
                    kopya.Controls["panel3"].BackColor = rengi;
                    kopya.Controls["panel4"].BackColor = rengi;
                    kopya.Controls["panel5"].BackColor = rengi;
                    kopya.Controls["panel6"].BackColor = Color.LightYellow;
                    kopya.Controls["panel7"].BackColor = Color.LightYellow;
                    kopya.Controls["panel8"].BackColor = rengi;
                    if (i != Deger.Length - 1 && (Deger[i + 1] == '.' || Deger[i + 1] == ','))
                        kopya.Controls["panel9"].BackColor = rengi;
                    else
                        kopya.Controls["panel9"].BackColor = Color.LightYellow;
                }
                else if (Deger[i] == '6')
                {
                    kopya.Controls["panel2"].BackColor = rengi;
                    kopya.Controls["panel3"].BackColor = rengi;
                    kopya.Controls["panel4"].BackColor = rengi;
                    kopya.Controls["panel5"].BackColor = rengi;
                    kopya.Controls["panel6"].BackColor = Color.LightYellow;
                    kopya.Controls["panel7"].BackColor = rengi;
                    kopya.Controls["panel8"].BackColor = rengi;
                    if (i != Deger.Length - 1 && (Deger[i + 1] == '.' || Deger[i + 1] == ','))
                        kopya.Controls["panel9"].BackColor = rengi;
                    else
                        kopya.Controls["panel9"].BackColor = Color.LightYellow;
                }
                else if (Deger[i] == '7')
                {
                    kopya.Controls["panel2"].BackColor = rengi;
                    kopya.Controls["panel3"].BackColor = Color.LightYellow;
                    kopya.Controls["panel4"].BackColor = Color.LightYellow;
                    kopya.Controls["panel5"].BackColor = Color.LightYellow;
                    kopya.Controls["panel6"].BackColor = rengi;
                    kopya.Controls["panel7"].BackColor = Color.LightYellow;
                    kopya.Controls["panel8"].BackColor = rengi;
                    if (i != Deger.Length - 1 && (Deger[i + 1] == '.' || Deger[i + 1] == ','))
                        kopya.Controls["panel9"].BackColor = rengi;
                    else
                        kopya.Controls["panel9"].BackColor = Color.LightYellow;
                }
                else if (Deger[i] == '8')
                {
                    kopya.Controls["panel2"].BackColor = rengi;
                    kopya.Controls["panel3"].BackColor = rengi;
                    kopya.Controls["panel4"].BackColor = rengi;
                    kopya.Controls["panel5"].BackColor = rengi;
                    kopya.Controls["panel6"].BackColor = rengi;
                    kopya.Controls["panel7"].BackColor = rengi;
                    kopya.Controls["panel8"].BackColor = rengi;
                    if (i != Deger.Length - 1 && (Deger[i + 1] == '.' || Deger[i + 1] == ','))
                        kopya.Controls["panel9"].BackColor = rengi;
                    else
                        kopya.Controls["panel9"].BackColor = Color.LightYellow;
                }
                else if (Deger[i] == '9')
                {
                    kopya.Controls["panel2"].BackColor = rengi;
                    kopya.Controls["panel3"].BackColor = rengi;
                    kopya.Controls["panel4"].BackColor = rengi;
                    kopya.Controls["panel5"].BackColor = rengi;
                    kopya.Controls["panel6"].BackColor = rengi;
                    kopya.Controls["panel7"].BackColor = Color.LightYellow;
                    kopya.Controls["panel8"].BackColor = rengi;
                    if (i != Deger.Length - 1 && (Deger[i + 1] == '.' || Deger[i + 1] == ','))
                        kopya.Controls["panel9"].BackColor = rengi;
                    else
                        kopya.Controls["panel9"].BackColor = Color.LightYellow;
                }

                form1.Controls["panel1"].Controls.Add(kopya);

                sol += 122;

            }
        }
    }
}
