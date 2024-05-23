using System.Runtime.CompilerServices;
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

namespace FirstHomeWork
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int sum = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string[] arr = textBox1.Text.Split("\r\n");
                foreach (var item in arr)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (!char.IsDigit(item[i]))
                        {
                            throw new Exception("Enter numbers not strings");
                        }
                    }
                    if (item.Contains(" "))
                    {
                        throw new Exception("Delete spaces");

                    }
                    sum += Convert.ToInt32(item);

                }
                textBlock1.Text = sum.ToString();
                sum = 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Invalid line");
                MessageBox.Show(ex.Message);
            }
        }
    
       
    }
}