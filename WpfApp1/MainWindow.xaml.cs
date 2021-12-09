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
using WpfApp1;
using Visual;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private WpfApp1.Triad _triada;
        private WpfApp1.Triad _secondtriada;
        private void Zapoln(object sender, RoutedEventArgs e)
        {
            
            Random rnd = new Random();
            _triada = new Triad() 
            {
                FirstNumber = rnd.Next(100),
                SecondNumber = rnd.Next(100),
                ThirdNumber = rnd.Next(100)
            };
            _secondtriada = new Triad()
            {
                FirstNumber = rnd.Next(100),
                SecondNumber = rnd.Next(100),
                ThirdNumber = rnd.Next(100)

            };
            data.ItemsSource= VisualArray.ToDataTable(_triada.TriadArray).DefaultView;
            data_2.ItemsSource = VisualArray.ToDataTable(_secondtriada.TriadArray).DefaultView;
        }
        private void proverka(out int k)
        {
            int.TryParse(Chislo.Text, out k);
            if (k == 0|| Chislo.Text==null) { MessageBox.Show("Введите ЧИСЛО!(не ноль)", "Ошибка"); return; }            
        }
        private void Proiz_Click(object sender, RoutedEventArgs e)
        {
            int inNum = Convert.ToInt32(Chislo.Text);
            proverka(out int k);
            WpfApp1.Triad thirdTriad = new Triad();
            _triada.ProizTriad(inNum,out int[] mas);
            data_3.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            //proverka(out int k);
            //mas_3 =Triada.Sum(mas, k);
            //data_3.ItemsSource = VisualArray.ToDataTable(mas_3).DefaultView;
        }

        private void SumTriad_Click(object sender, RoutedEventArgs e)
        {
        //    mas_3=Triada.Sum(mas, mas_2);
        //    data_3.ItemsSource = VisualArray.ToDataTable(mas_3).DefaultView;

        }

        private void Srav_Cklick(object sender, RoutedEventArgs e)
        {
            //string[] mas_4;
            //proverka(out int k);
            //mas_4 = Triada.Srav(mas, k);
            //data_3.ItemsSource = VisualArray.ToDataTable(mas_4).DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
