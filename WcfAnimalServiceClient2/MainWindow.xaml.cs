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

namespace WcfAnimalServiceClient2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //WcfAnimalServiceProxies.AnimalSvcClient proxy = new WcfAnimalServiceProxies.AnimalSvcClient();
            IISHostServiceReference.AnimalSvcLibraryClient client = new IISHostServiceReference.AnimalSvcLibraryClient();
            IISHostServiceReference.Animal animal = new IISHostServiceReference.Animal();
            animal.Name = "Monkey";
            label1.Content = client.GreetAnimal(animal) + " ";

            IISHostServiceReference.AnimalSvcPrivateLibraryClient client2 = new IISHostServiceReference.AnimalSvcPrivateLibraryClient();
            label2.Content = client2.GetAnimalInfo();
        }
    }
}
