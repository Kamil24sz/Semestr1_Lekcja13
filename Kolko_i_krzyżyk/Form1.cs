using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolko_i_krzyżyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Co ma się dziać po kliknięciu (któregokolwiek z przycisków)

        //włącz wszytskie przyciski + wyczyść z nich tekst
        private void WlaczWszystkiePrzyciskiIResetuj()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
        }

        //wyłączanie wszystkich przycisków
        private void WylaczWszystkiePrzyciski()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        } 

        //sprawdzanie czy ktoś nie wygrał
        private bool SprawdzCzyKtosWygral()
        {
            //Sprawdzamy pierwszy wiersz
            if(btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn1.Text != "")
            {
                return true;
            }
            //Sprawdzamy drugi wiersz
            else if (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn4.Text != "")
            {
                return true;
            }
            //Sprawdzamy trzeci wiersz
            else if (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn7.Text != "")
            {
                return true;
            }
            //Sprawdzamy pierwszą kolumnę
            else if (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn1.Text != "")
            {
                return true;
            }
            //Sprawdzamy drugą kolumnę
            else if (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn2.Text != "")
            {
                return true;
            }
            //Sprawdzamy trzecią kolumnę
            else if (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn3.Text != "")
            {
                return true;
            }
            //Sprawdzamy pierwszą przekątną
            else if (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn1.Text != "")
            {
                return true;
            }
            //Sprawdzamy drugą przekątną
            else if (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn3.Text != "")
            {
                return true;
            }
            return false;
        }

        //metody dla przycisków
    }
}