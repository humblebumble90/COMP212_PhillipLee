// MainWindow.xaml.cs
// Code-behind class for a simple text editor.
using System.Windows;
using System.Windows.Input;

namespace TextEditor
{
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();
      } // end constructor

      // exit the app
      private void closeCommand_Executed( object sender, ExecutedRoutedEventArgs e )
      {
         Application.Current.Shutdown();
      } // end method closeCommand_Executed

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    } // end class MainWindow
} // end namespace TextEditor
