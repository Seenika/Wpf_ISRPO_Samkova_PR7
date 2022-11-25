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
            MessageBox.Show("Свежая мята, Лайм, Спрайт, Лёд, Тросниковый сахар");
        }

        private void HolodniyChay_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Зелёный сорт заварки, Мята, Лёд, Лайм, Сахар");
        }

        private void MolochniyKoktel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Молоко, Пломбир, Сахарная пудра");
        }

        private void Smuzi_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Киви, Банан, Шпинат, Йогурт, Сахар");
        }

        private void Brusketa_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Булочка, Говяжий фарш, Огурцы, Майонез, Помидоры, Укроп, Молотый чёрный перец");
        }

        private void Vafli_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Мука, Яйца, Масло сливочное, Сахар, Соль, Ванилин, Масло растительное, Сгущёнка варёная, Сахарная пудра");
        }

        private void Chena1_Click(object sender, RoutedEventArgs e)
        {
            double it = double.Parse(Itog.Text);
            double plus = 250;
            double itog = it + plus;
            Itog.Text = itog.ToString();
            Pokupka.Text += Environment.NewLine + "Суп Сицилия = " + plus.ToString() + " руб.";
        }

        private void Chena2_Click(object sender, RoutedEventArgs e)
        {
            double it = double.Parse(Itog.Text);
            double plus = 300;
            double itog = it + plus;
            Itog.Text = itog.ToString();
            Pokupka.Text += Environment.NewLine + "Уха по царски = " + plus.ToString() + " руб.";
        }

        private void Chena3_Click(object sender, RoutedEventArgs e)
        {
            double it = double.Parse(Itog.Text);
            double plus = 500;
            double itog = it + plus;
            Itog.Text = itog.ToString();
            Pokupka.Text += Environment.NewLine + "Суп Сицилия = " + plus.ToString() + " руб.";
        }

        private void Chena4_Click(object sender, RoutedEventArgs e)
        {
            double it = double.Parse(Itog.Text);
            double plus = 300;
            double itog = it + plus;
            Itog.Text = itog.ToString();
            Pokupka.Text += Environment.NewLine + "Кремлёвский борщ = " + plus.ToString() + " руб.";
        }

        private void Chena5_Click(object sender, RoutedEventArgs e)
        {
            double it = double.Parse(Itog.Text);
            double plus = 200;
            double itog = it + plus;
            Itog.Text = itog.ToString();
            Pokupka.Text += Environment.NewLine + "Брускетта с фаршем и овощами = " + plus.ToString() + " руб.";
        }

        private void Chena6_Click(object sender, RoutedEventArgs e)
        {
            double it = double.Parse(Itog.Text);
            double plus = 300;
            double itog = it + plus;
            Itog.Text = itog.ToString();
            Pokupka.Text += Environment.NewLine + "Жульен с курицей и грибами = " + plus.ToString() + " руб.";
        }

        private void Chena7_Click(object sender, RoutedEventArgs e)
        {
            double it = double.Parse(Itog.Text);
            double plus = 350;
            double itog = it + plus;
            Itog.Text = itog.ToString();
            Pokupka.Text += Environment.NewLine + "Джамбалайя = " + plus.ToString() + " руб.";
        }

        private void Chena8_Click(object sender, RoutedEventArgs e)
        {
            double it = double.Parse(Itog.Text);
            double plus = 300;
            double itog = it + plus;
            Itog.Text = itog.ToString();
            Pokupka.Text += Environment.NewLine + "Лапша удон с курицей и овощами в соусе терияки = " + plus.ToString() + " руб.";
        }

        private void Chena1_Copy_Click(object sender, RoutedEventArgs e)
        {
            double it = double.Parse(Itog.Text);
            double plus = 250;
            double itog = it + plus;
            Itog.Text = itog.ToString();
            Pokupka.Text += Environment.NewLine + "Вафельные трубочки = " + plus.ToString() + " руб.";
        }

        private void Chena1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            double it = double.Parse(Itog.Text);
            double plus = 150;
            double itog = it + plus;
            Itog.Text = itog.ToString();
            Pokupka.Text += Environment.NewLine + "Махито = " + plus.ToString() + " руб.";
        }

        private void Chena1_Copy2_Click(object sender, RoutedEventArgs e)
        {
            double it = double.Parse(Itog.Text);
            double plus = 100;
            double itog = it + plus;
            Itog.Text = itog.ToString();
            Pokupka.Text += Environment.NewLine + "Холодный чай = " + plus.ToString() + " руб.";
        }

        private void Chena1_Copy3_Click(object sender, RoutedEventArgs e)
        {
            double it = double.Parse(Itog.Text);
            double plus = 150;
            double itog = it + plus;
            Itog.Text = itog.ToString();
            Pokupka.Text += Environment.NewLine + "Молочный коктель = " + plus.ToString() + " руб.";
        }

        private void Chena1_Copy4_Click(object sender, RoutedEventArgs e)
        {
            double it = double.Parse(Itog.Text);
            double plus = 200;
            double itog = it + plus;
            Itog.Text = itog.ToString();
            Pokupka.Text += Environment.NewLine + "Зелёный смузи = " + plus.ToString() + " руб.";
        }
    }
}
