using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using Data;

namespace BleakwindBuffet.PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        object currentItem;

        CheckBox bun = new CheckBox();
        CheckBox ketchup = new CheckBox();
        CheckBox mustard = new CheckBox();
        CheckBox pickle = new CheckBox();
        CheckBox cheese = new CheckBox();
        CheckBox tomato = new CheckBox();
        CheckBox lettuce = new CheckBox();
        CheckBox mayo = new CheckBox();
        CheckBox brocolli = new CheckBox();
        CheckBox mushrooms = new CheckBox();
        CheckBox cheddar = new CheckBox();
        CheckBox sirloin = new CheckBox();
        CheckBox onions = new CheckBox();
        CheckBox roll = new CheckBox();
        CheckBox bacon = new CheckBox();
        CheckBox egg = new CheckBox();
        CheckBox ice = new CheckBox();
        ComboBox flavor = new ComboBox();
        ComboBox size = new ComboBox();
        CheckBox sausage = new CheckBox();
        CheckBox hashbrowns = new CheckBox();
        CheckBox pancake = new CheckBox();
        CheckBox decaf = new CheckBox();
        CheckBox cream = new CheckBox();
        CheckBox lemon = new CheckBox();

        public MainWindow()
        {
            InitializeComponent();

            bun.Content = "Bun";
            bun.Checked += new RoutedEventHandler(OnPropertyChange);
            ketchup.Content = "Ketchup";
            ketchup.Checked += new RoutedEventHandler(OnPropertyChange);
            mustard.Content = "Mustard";
            mustard.Checked += new RoutedEventHandler(OnPropertyChange);
            pickle.Content = "Pickle";
            pickle.Checked += new RoutedEventHandler(OnPropertyChange);
            cheese.Content = "Cheese";
            cheese.Checked += new RoutedEventHandler(OnPropertyChange);
            tomato.Content = "Tomato";
            tomato.Checked += new RoutedEventHandler(OnPropertyChange);
            lettuce.Content = "Lettuce";
            lettuce.Checked += new RoutedEventHandler(OnPropertyChange);
            mayo.Content = "Mayo";
            mayo.Checked += new RoutedEventHandler(OnPropertyChange);
            brocolli.Content = "Brocolli";
            brocolli.Checked += new RoutedEventHandler(OnPropertyChange);
            mushrooms.Content = "Mushrooms";
            mushrooms.Checked += new RoutedEventHandler(OnPropertyChange);
            cheddar.Content = "Cheddar";
            cheddar.Checked += new RoutedEventHandler(OnPropertyChange);
            sirloin.Content = "Sirloin";
            sirloin.Checked += new RoutedEventHandler(OnPropertyChange);
            onions.Content = "Onions";
            onions.Checked += new RoutedEventHandler(OnPropertyChange);
            roll.Content = "Roll";
            roll.Checked += new RoutedEventHandler(OnPropertyChange);
            bacon.Content = "Bacon";
            bacon.Checked += new RoutedEventHandler(OnPropertyChange);
            egg.Content = "Egg";
            egg.Checked += new RoutedEventHandler(OnPropertyChange);
            ice.Content = "Ice";
            ice.Checked += new RoutedEventHandler(OnPropertyChange);
            sausage.Content = "Sausage";
            sausage.Checked += new RoutedEventHandler(OnPropertyChange);
            hashbrowns.Content = "Hashbrowns";
            hashbrowns.Checked += new RoutedEventHandler(OnPropertyChange);
            pancake.Content = "Pancakes";
            pancake.Checked += new RoutedEventHandler(OnPropertyChange);
            decaf.Content = "Decaf";
            decaf.Checked += new RoutedEventHandler(OnPropertyChange);
            cream.Content = "Cream";
            cream.Checked += new RoutedEventHandler(OnPropertyChange);
            lemon.Content = "Lemon";
            lemon.Checked += new RoutedEventHandler(OnPropertyChange);

            List<string> flavors = new List<string>()
            {
                "Blackberry",
                "Cherry",
                "Grapefruit",
                "Lemon",
                "Peach",
                "Watermelon"
            };

            List<string> sizes = new List<string>()
            {
                "Small",
                "Medium",
                "Large"
            };
                
            flavor.ItemsSource = flavors;
            flavor.SelectedIndex = 0;
            size.ItemsSource = sizes;
            size.SelectedIndex = 0;
        }

        public void GoToCustomizeClick(object sender, EventArgs e)
        {
            ClearCheckboxes();

            addButton.IsEnabled = true;
            cancelButton.IsEnabled = true;

            PopulateCheckboxStack(sender);

            currentItem = sender;

            Debug.WriteLine(sender.ToString() + " button clicked");
        }

        private void ClearCheckboxes()
        {
            checkBoxStack.Children.Clear();
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            ClearCheckboxes();

            addButton.IsEnabled = false;
            cancelButton.IsEnabled = false;

            currentItem = null;
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            
        }

        private void OnPropertyChange(object sender, RoutedEventArgs e)
        {

        }

        public void PopulateCheckboxStack(object sender)
        {
            if(sender is Button b) {
                switch (b.Content)
                {
                    case "Briarheart Burger":
                        checkBoxStack.Children.Add(bun);
                        checkBoxStack.Children.Add(ketchup);
                        checkBoxStack.Children.Add(mustard);
                        checkBoxStack.Children.Add(pickle);
                        checkBoxStack.Children.Add(cheese);
                        break;
                    case "Double Draugr":
                        checkBoxStack.Children.Add(bun);
                        checkBoxStack.Children.Add(ketchup);
                        checkBoxStack.Children.Add(mustard);
                        checkBoxStack.Children.Add(pickle);
                        checkBoxStack.Children.Add(cheese);
                        checkBoxStack.Children.Add(tomato);
                        checkBoxStack.Children.Add(lettuce);
                        checkBoxStack.Children.Add(mayo);
                        break;
                    case "Garden Orc Omelette":
                        checkBoxStack.Children.Add(brocolli);
                        checkBoxStack.Children.Add(mushrooms);
                        checkBoxStack.Children.Add(tomato);
                        checkBoxStack.Children.Add(cheddar);
                        break;
                    case "Philly Poacher":
                        checkBoxStack.Children.Add(sirloin);
                        checkBoxStack.Children.Add(onions);
                        checkBoxStack.Children.Add(roll);
                        break;
                    case "Smokehouse Skeleton":
                        checkBoxStack.Children.Add(sausage);
                        checkBoxStack.Children.Add(egg);
                        checkBoxStack.Children.Add(hashbrowns);
                        checkBoxStack.Children.Add(pancake);
                        break;
                    case "Thalmor Triple":
                        checkBoxStack.Children.Add(bun);
                        checkBoxStack.Children.Add(ketchup);
                        checkBoxStack.Children.Add(mustard);
                        checkBoxStack.Children.Add(pickle);
                        checkBoxStack.Children.Add(cheese);
                        checkBoxStack.Children.Add(tomato);
                        checkBoxStack.Children.Add(lettuce);
                        checkBoxStack.Children.Add(mayo);
                        break;
                    case "Thugs T-Bone":
                        // do nothing
                        break;
                    case "Sailor Soda":
                        checkBoxStack.Children.Add(flavor);
                        checkBoxStack.Children.Add(ice);
                        checkBoxStack.Children.Add(size);
                        break;
                    case "Markarth Milk":
                        checkBoxStack.Children.Add(ice);
                        checkBoxStack.Children.Add(size);
                        break;
                    case "Aretino Apple Juice":
                        checkBoxStack.Children.Add(ice);
                        checkBoxStack.Children.Add(size);
                        break;
                    case "Candlehearth Coffee":
                        checkBoxStack.Children.Add(ice);
                        checkBoxStack.Children.Add(size);
                        checkBoxStack.Children.Add(cream);
                        checkBoxStack.Children.Add(decaf);
                        break;
                    case "Warrior Water":
                        checkBoxStack.Children.Add(ice);
                        checkBoxStack.Children.Add(size);
                        checkBoxStack.Children.Add(lemon);
                        break;
                    case "Vokun Salad":
                        checkBoxStack.Children.Add(size);
                        break;
                    case "Fried Miraak":
                        checkBoxStack.Children.Add(size);
                        break;
                    case "Mad Otar Grits":
                        checkBoxStack.Children.Add(size);
                        break;
                    case "Dragonborn Waffle Fries":
                        checkBoxStack.Children.Add(size);
                        break;
                    default:
                        throw new ArgumentException("Button Error");
                }
            }
        }
    }
}
