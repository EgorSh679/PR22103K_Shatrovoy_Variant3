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
using System.Xml.Serialization;

namespace PR22103K_Shatrovoy_Variant3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int min, max, N;
            try
            {
                min = Convert.ToInt32(tbmin.Text);
                max = Convert.ToInt32(tbmax.Text);
                N = Convert.ToInt32(tbsize.Text);

                int[] array = new int[N];
                for (int i = 0; i < N; i++)
                {
                    array[i] = rand.Next(min, max);
                }

                string ovet = "Сгенерированный массив: " + string.Join(", ", array);
                otvet1.Content = ovet;

                var sortedArray = array.OrderBy(x => x % 2 != 0).ToArray();

                ovet = "Пересортированный массив: " + string.Join(", ", sortedArray);
                otvet2.Content = ovet;

            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }
    }
}
