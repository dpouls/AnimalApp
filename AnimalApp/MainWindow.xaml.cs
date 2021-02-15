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
        //create a Beast variable to assign new Beast classes to
        Beast beast;
        public MainWindow()
        {
            InitializeComponent();
            //set a default checked button at first
            RBDragon.IsChecked = true;
        }
        /// <summary>
        /// Reassigns the LblResults content to the food type on the beast object.
        /// </summary>
        private void BtnFood_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = beast.FoodType;
        }
        /// <summary>
        /// Reassigns the LblResults content to the skin type on the beast object.
        /// 
        /// </summary>
        private void BtnSkin_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = beast.SkinType;
        }
        /// <summary>
        /// Reassigns the LblResults content to the result from invoking the sound method on the beast object.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSound_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = beast.Sound();
        }
        /// <summary>
        /// Reassigns the LblResults content to the result from invoking the pet method on the beast object.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPet_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = beast.Pet();
        }
        /// <summary>
        /// Reassigns the LblResults content to the result from invoking the move method on the beast object.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMove_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = beast.Move();
        }
        /// <summary>
        /// Reassigns the LblResults content to the result from invoking the eat method on the beast object.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEat_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = beast.Eat();
        }
        /// <summary>
        /// Changes the image to the dragon, reassigns the lblresults content to something related, and instantiates a dragon class with arguments for food and skin type and assigns the instance to the beast variable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBDragon_Checked(object sender, RoutedEventArgs e)
        {
            ImgBeast.Source = new BitmapImage(new Uri("dragon.jpg",UriKind.Relative));
            LblResults.Content = "White dragons soar the skies among the highest peaks in the frostlands.";
            beast = new Dragon("Larger animals and any who dare get near","Scales and Horns");
        }
        /// <summary>
        /// Changes the image to the yeti, reassigns the lblresults content to something related, and instantiates a yeti class with arguments for food and skin type and assigns the instance to the beast variable.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBYeti_Checked(object sender, RoutedEventArgs e)
        {
            ImgBeast.Source = new BitmapImage(new Uri("yeti.jpg", UriKind.Relative));
            LblResults.Content = "Yetis tend to live solitary lives in the brutal tundra.";
            beast = new Yeti("Medium size animals, typically livestock from nearby towns.", "Thick white fur and black skin.");

        }
        /// <summary>
        /// Changes the image to the troll, reassigns the lblresults content to something related, and instantiates a troll class with arguments for food and skin type and assigns the instance to the beast variable.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBTroll_Checked(object sender, RoutedEventArgs e)
        {
            ImgBeast.Source = new BitmapImage(new Uri("frosttroll.jpg", UriKind.Relative));
            LblResults.Content = "Frost Trolls crush their prey.";
            beast = new Troll("Icy blue skin with grey tufts of fur","Sheep and smaller animals, large beasts on ocassion.");
        }
    }
}
