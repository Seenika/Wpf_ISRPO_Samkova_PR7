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

namespace Wpf_ISRPO_Samkova_PR7
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

        private void Sichilia_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Филе рыбное, Томатная паста, Морковь, Сельдерей корневой, Лук красный, Сельдерей листовой, Лимон, Масло растительное, Порошок чесночный, Фенхель, Соль, Перец черный");
        }

        private void Kremsup_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Шампиньёны, Куриный бульён, Лук, Сливочное масло, Мука, Молоко, Соль, Молотый чёрный перец, Петрашка");
        }

        private void UhaPoCharski_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Филе осётра без кожи, Филе сёмги, Сом мраморный филе, Масло сливочное, Картофель, Морковь, Лук, Помидоры, Лимон, Водка, Маслины, Соль, Молотый чёрный перец, Петрашка");
        }

        private void Kremlovskiy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Баранина, Свёкла, Капуста, Морковь, Лук, Лимонный сок, Чеснок, Петрушка, ТОматная паста, Лавровый лист, Растительное масло, Уксус, Соль, Молотый чёрный перец");
        }

        private void Shulien_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Куриная грудка, Грибы, Сыр, Сливки, Лук");
        }

        private void Dzhamba_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Сщсиски, Рис, Лук, Болгарский перец, Помидоры, Чеснок, Томатная паста, Масло растительное, Петрушка, Соль, Молотый чёрный перец");
        }

        private void Lapsha_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Луриная грудка, Лапша удон, Перец сладкий, Морковь, Лук, Чесное, Корень имбиря, Лук зелёный, Масло растительное, Соус терияки, Соус соевый, Соль, Молотый чёрный перец, Кунжут обжарнный");
        }

        private void Mahito_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HolodniyChay_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MolochniyKoktel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Smuzi_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
