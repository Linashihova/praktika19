using System.Windows;
using System.Windows.Controls;

namespace Kino_Shihova
{
    public partial class MainWindow : Window
    {
        public static MainWindow init;
        public MainWindow()
        {
            InitializeComponent();
            OpenPage(new Pages.Kinoteatr.Main());
            init = this;
        }
        public void OpenPage(Page page)
        {
            frame.Navigate(page);
        }
        private void OpenKino(object sender, RoutedEventArgs e)
        {
            OpenPage(new Pages.Kinoteatr.Main());
        }

        private void OpenAfish(object sender, RoutedEventArgs e)
        {
            OpenPage(new Pages.Afisha.Main());
        }
    }
}
