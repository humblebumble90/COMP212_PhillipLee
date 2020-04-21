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

namespace DataBindingWithDataContextOneWay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Product product = new Product
        {
            Name = "Galaxy",
            Price = 1200.00
        };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = product;
        }

        private void buttonDisplay_Click(object sender, RoutedEventArgs e)
        {
            string message = "Price of " + product.Name + " is " + "$" + product.Price;
            MessageBox.Show(message);
        }

        private void NameText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    } // end class
} // end namespace
