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

namespace lotto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] numbers = new int[6];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("De 6 Lotto getallen zijn: ");
            sb.AppendLine("");
            Random numberGen = new Random();

            int count = 0;
            for (int i = 0; i < 6; i++)
            { 
                int newNumber = numberGen.Next(0, 46);

                if(!NumberExists(newNumber, count))
                {
                    numbers[count] = newNumber;                    
                    count++;
                }
            }

            for (int i = 1; i < 7; i++)
            {
                string result = $"Getal {i} is {numbers[i-1]}";
                sb.AppendLine(result);

            }
            resultTextbox.Text = sb.ToString();
        }

        private bool NumberExists(int newNumber, int count)
        {
            for (int i = 0; i < count; i++) 
            {
                if (numbers[i] == newNumber)
                {
                    return true; 
                }
            }
            return false; // Getal is uniek
        }



    }
}