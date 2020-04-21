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

namespace Hyungseok_Lee_Ex01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Calculate_Click(object sender, RoutedEventArgs e)
        {
            richTxtBox_Result.Document.Blocks.Clear();
            richTxtBox_Result.AppendText($"Name: {txtbox_Name.Text}\n" +
                $"Address: {txtBox_Addres.Text}\n" +
                $"Province: {ComboBx_Province.Text}\n");
            if (radioBtn_Youth.IsChecked == true)
            {
                richTxtBox_Result.AppendText($"\nAge range: {radioBtn_Youth.Content}");
            }
            if (RadioBtn_Adult.IsChecked == true)
            {
                richTxtBox_Result.AppendText($"\nAge range: {RadioBtn_Adult.Content}");
            }
            if (radioBtn_Senior.IsChecked == true)
            {
                richTxtBox_Result.AppendText($"\nAge range: {radioBtn_Senior.Content}");
            }
            double sum = 0;
            if(chckBox_Flossing.IsChecked == true)
            {
                sum += 20.00;
            }
            if(chckBox_Filling.IsChecked == true)
            {
                sum += 75.00;
            }
            if(chckBox_RootCanal.IsChecked == true)
            {
                sum += 150.00;
            }
            switch(ComboBx_Province.Text)
            {
                case "Alberta":
                    sum *= 0.97;
                    break;
                case "Ontario":
                    sum *= 0.87;
                    break;
                case "Quebec":
                    sum *= 0.94;
                    break;
                default:
                    break;
            }
            if(radioBtn_Youth.IsChecked == true)
            {
                sum *= 0.85;
            }
            if(radioBtn_Senior.IsChecked == true)
            {
                sum *= 0.9;
            }
            richTxtBox_Result.AppendText($"\nPrice : {sum}$");
        }
        
        private void Txtbox_Name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
