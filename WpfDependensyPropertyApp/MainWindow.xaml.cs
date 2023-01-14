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

namespace WpfDependensyPropertyApp
{
    public class User : DependencyObject
    {
        public static DependencyProperty NameProperty;
        public static DependencyProperty AgeProperty;

        

        static User()
        {
            NameProperty = DependencyProperty.Register(
                "Name",
                typeof(string), 
                typeof(User)
                );

            FrameworkPropertyMetadata metadata = new();
            metadata.CoerceValueCallback = new CoerceValueCallback(AgeCoerceValue);

            AgeProperty = DependencyProperty.Register(
                "Age",
                typeof(int),
                typeof(User),
                metadata,
                new ValidateValueCallback(AgeValidateValue)
                );
        }

        static bool AgeValidateValue(object value)
        {
            int currentAge = (int)value;
            return currentAge >= 0;
            return true;
        }

        static object AgeCoerceValue(DependencyObject d, object baseValue)
        {
            int currentAge = (int)baseValue;
            if (currentAge < 0)
                currentAge = 0;
            if (currentAge > 100)
                currentAge = 100;
            return currentAge;
        }

        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }

        public int Age
        {
            get => (int)GetValue(AgeProperty);
            set => SetValue(AgeProperty, value);
        }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //txtBlock.Text = "Hello world";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = (User)this.Resources["userBob"];
            MessageBox.Show(user.Age.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ((User)this.Resources["userBob"]).Age = 56;
        }
    }
}
