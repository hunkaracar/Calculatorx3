using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcuulatorX3
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekranTemizlenecekMi;
        private int _ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rakam1button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += 1;
        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += 2;
        }

        private void rakam3button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += 3;
        }

        private void rakam4button_Click(object sender, EventArgs e)
        { 
            if (_ekranTemizlenecekMi)
            {
               ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += 4;
        }

        private void rakam5button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += 5;
        }

        private void rakam6button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += 6;
        }

        private void rakam7button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += 7;
        }

        private void rakam8button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += 8;
        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += 9;
        }

        private void rakam0button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranLabel.Text == "0")
            {
                ekranLabel.Text = "";
            }
            ekranLabel.Text += 0;
        }

        private void toplamabutton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void esittirbutton_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikincisayi;
                    break;

                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    break;

                case '*':
                    sonuc = _ilksayi * ikincisayi;
                    break;

                case '/':
                    sonuc = _ilksayi / ikincisayi;
                    break;

                default:
                    sonuc = 0;
                    break;
            }
            ekranLabel.Text = Convert.ToString(sonuc);
        }

        private void cıkarmabutton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void carpmabutton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void bolmebutton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void temizlebutton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "";
        }
    }
}
