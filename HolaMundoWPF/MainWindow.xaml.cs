using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HolaMundoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double n1, n2;
        private string sig;
        private bool ban = false;
        public MainWindow()
        {
            InitializeComponent();

            uno.Click += Uno_Click;
            dos.Click += Dos_Click;
            tres.Click += Tres_Click;
            cuatr.Click += Cuatro_Click;
            cinco.Click += Cinco_Click;
            seis.Click += Seis_Click;
            siete.Click += Siete_Click;
            ocho.Click += Ocho_Click;
            nueve.Click += Nueve_Click;
            cero.Click += Cero_Click;
            pun.Click += Punto_Click;

            sum.Click += Sum_Click;
            res.Click += Res_Click;
            mul.Click += Mul_Click;
            div.Click += Div_Click;
            igual.Click += Igual_Click;

            lim.Click += Limpiar_Click;
        }

        private void Limpiar_Click(object sender, RoutedEventArgs e)
        {
            txtScreen.Clear();
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            n1 = double.Parse(txtScreen.Text);
            txtScreen.Clear();
            txtScreen.AppendText(div.Content+"");
            sig ="/";
            ban = true;
        }

        private void Mul_Click(object sender, RoutedEventArgs e)
        {
            n1 = double.Parse(txtScreen.Text);
            txtScreen.Clear();
            txtScreen.AppendText(mul.Content + "");
            sig = "*";
            ban = true;
        }

        private void Res_Click(object sender, RoutedEventArgs e)
        {
            n1 = double.Parse(txtScreen.Text);
            txtScreen.Clear();
            txtScreen.AppendText(res.Content + "");
            ban = true;
            sig = "-";
        }

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            n1=double.Parse(txtScreen.Text);
            txtScreen.Clear();
            txtScreen.AppendText(sum.Content + "");
            sig = "+";
            ban = true;
        }

        private void Igual_Click(object sender, RoutedEventArgs e)
        {
            n2 = double.Parse(txtScreen.Text);

            switch (sig)
            {
                case "+": n1=n1 + n2;
                    break;
                case "-":
                    n1 = n1 - n2;
                    break;
                case "*":
                    n1 = n1 * n2;
                    break;
                case "/":
                    n1 = n1 / n2;
                    break;
                default: txtScreen.Text = "Error";
                    break;
            }
            
            txtScreen.Text = n1+"";
        }

        private void Punto_Click(object sender, RoutedEventArgs e)
        {
            
            if (ban ==true)
            {
                txtScreen.Text = "";
                ban = false;
            }
            txtScreen.AppendText(pun.Content + "");
        }

        private void Cero_Click(object sender, RoutedEventArgs e)
        {

            if (ban == true)
            {
                txtScreen.Text = "";
                ban = false;
            }
            txtScreen.AppendText(cero.Content + "");
        }

        private void Nueve_Click(object sender, RoutedEventArgs e)
        {

            if (ban == true)
            {
                txtScreen.Text = "";
                ban = false;
            }
            txtScreen.AppendText(nueve.Content + "");
        }

        private void Ocho_Click(object sender, RoutedEventArgs e)
        {

            if(ban == true)
            {
                txtScreen.Text = "";
                ban = false;
            }
            txtScreen.AppendText(ocho.Content + "");
        }

        private void Siete_Click(object sender, RoutedEventArgs e)
        {

            if(ban == true)
            {
                txtScreen.Text = "";
                ban = false;
            }
            txtScreen.AppendText(siete.Content + "");
        }

        private void Seis_Click(object sender, RoutedEventArgs e)
        {

            if (ban == true)
            {
                txtScreen.Text = "";
                ban = false;
            }
            txtScreen.AppendText(seis.Content + "");
        }

        private void Cinco_Click(object sender, RoutedEventArgs e)
        {

            if (ban == true)
            {
                txtScreen.Text = "";
                ban = false;
            }
            txtScreen.AppendText(cinco.Content + "");
        }

        private void Cuatro_Click(object sender, RoutedEventArgs e)
        {

            if (ban == true)
            {
                txtScreen.Text = "";
                ban = false;
            }
            txtScreen.AppendText(cuatr.Content + "");
        }

        private void Tres_Click(object sender, RoutedEventArgs e)
        {

            if (ban == true)
            {
                txtScreen.Text = "";
                ban = false;
            }
            txtScreen.AppendText(tres.Content + "");
        }

        private void Dos_Click(object sender, RoutedEventArgs e)
        {

            if (ban == true)
            {
                txtScreen.Text = "";
                ban = false;
            }
            txtScreen.AppendText(dos.Content + "");
        }

        private void Uno_Click(object sender, RoutedEventArgs e)
        {

            if (ban == true)
            {
                txtScreen.Text = "";
                ban = false;
             }
            txtScreen.AppendText(uno.Content + "");
        }
    }
}
