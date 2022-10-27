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

namespace prova_30pts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> achou = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }


        private void click1(object sender, MouseButtonEventArgs e)
        {
            if(erro1.Visibility == Visibility.Hidden)
            {
                erro1.Visibility = Visibility.Visible;
                achou.Add(1);
                verifica();
            }
        }
        private void click2(object sender, MouseButtonEventArgs e)
        {
            if (erro2.Visibility == Visibility.Hidden)
            {
                erro2.Visibility = Visibility.Visible;
                achou.Add(2);
                verifica();
            }
        }

        private void click3(object sender, MouseButtonEventArgs e)
        {
            if (erro3.Visibility == Visibility.Hidden)
            {
                erro3.Visibility = Visibility.Visible;
                achou.Add(3);
                verifica();
            }
        }

        private void click4(object sender, MouseButtonEventArgs e)
        {
            if (erro4.Visibility == Visibility.Hidden)
            {
                erro4.Visibility = Visibility.Visible;
                achou.Add(4);
                verifica();
            }
        }

        private void click5(object sender, MouseButtonEventArgs e)
        {
            if (erro5.Visibility == Visibility.Hidden)
            {
                erro5.Visibility = Visibility.Visible;
                achou.Add(5);
                verifica();
            }
        }

        private void click6(object sender, MouseButtonEventArgs e)
        {
            if (erro6.Visibility == Visibility.Hidden)
            {
                erro6.Visibility = Visibility.Visible;
                achou.Add(6);
                verifica();
            }
        }

        private void click7(object sender, MouseButtonEventArgs e)
        {
            if (erro7.Visibility == Visibility.Hidden)
            {
                erro7.Visibility = Visibility.Visible;
                achou.Add(7);
                verifica();
            }
        }
        private void verifica()
        {
            if(achou.Count() == 7)
            {
                MessageBoxResult result = MessageBox.Show
                    (
                    "Você achou todos os erros!",
                    "Informação",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information
                    );
                if(result == MessageBoxResult.OK)
                {
                    for(int i = 1; i <= 7; i++)
                    {
                        achou.Remove(i);
                    }
                    erro1.Visibility = Visibility.Hidden;
                    erro2.Visibility = Visibility.Hidden;
                    erro3.Visibility = Visibility.Hidden;
                    erro4.Visibility = Visibility.Hidden;
                    erro5.Visibility = Visibility.Hidden;
                    erro6.Visibility = Visibility.Hidden;
                    erro7.Visibility = Visibility.Hidden;
                }
            }
        }
    }
}
