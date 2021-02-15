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

namespace AnimalApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Beast beast;
        public MainWindow()
        {
            InitializeComponent();
            RBDragon.IsChecked = true;
        }

        private void BtnFood_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = beast.FoodType;
        }

        private void BtnSkin_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = beast.SkinType;
        }

        private void BtnSound_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = beast.Sound();
        }

        private void BtnPet_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = beast.Pet();
        }

        private void BtnMove_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = beast.Move();
        }

        private void BtnEat_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = beast.Eat();
        }

        private void RBDragon_Checked(object sender, RoutedEventArgs e)
        {
            ImgBeast.Source = new BitmapImage(new Uri("dragon.jpg",UriKind.Relative));
            LblResults.Content = "White dragons soar the skies among the highest peaks in the frostlands.";
            beast = new Dragon("Larger animals and any who dare get near","Scales and Horns");
        }

        private void RBYeti_Checked(object sender, RoutedEventArgs e)
        {
            ImgBeast.Source = new BitmapImage(new Uri("yeti.jpg", UriKind.Relative));
            LblResults.Content = "Yetis tend to live solitary lives in the brutal tundra.";
            beast = new Yeti("Medium size animals, typically livestock from nearby towns.", "Thick white fur and black skin.");

        }

        private void RBTroll_Checked(object sender, RoutedEventArgs e)
        {
            ImgBeast.Source = new BitmapImage(new Uri("frosttroll.jpg", UriKind.Relative));
            LblResults.Content = "Frost Trolls crush their prey.";
            beast = new Troll("Icy blue skin with grey tufts of fur","Sheep and smaller animals, large beasts on ocassion.");
        }
    }
}
