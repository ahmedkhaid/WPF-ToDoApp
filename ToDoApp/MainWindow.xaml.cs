using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDoApp
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
        private void ToDoButton(object sender, RoutedEventArgs e)
        {
            string UserText = UserInput.Text;
           
            //now need to apend to the as text block
            //and handling if the box is empty or null
            if(!string.IsNullOrEmpty(UserText))
                {
                TextBlock textBlock=new TextBlock();
                textBlock.Text = UserText;
                TodoList.Children.Add(textBlock);
                  textBlock.Foreground=new SolidColorBrush(Colors.White);
                textBlock.Margin = new Thickness(10);
            }
            UserInput.Clear();

        }
    }
}