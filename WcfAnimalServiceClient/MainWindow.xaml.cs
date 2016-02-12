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

namespace WcfAnimalServiceClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            WcfAnimalServiceProxies.AnimalSvcClient proxy = new WcfAnimalServiceProxies.AnimalSvcClient();
            WcfAnimalServiceLibrary.Animal animal = new WcfAnimalServiceLibrary.Animal();
            animal.Name = "Monkey";
            label1.Content = proxy.GreetAnimal(animal);

            WcfAnimalServiceProxies.AnimalSvcClient2 proxy2 = new WcfAnimalServiceProxies.AnimalSvcClient2();
            label2.Content = proxy2.GetAnimalInfo();
        }
    }
}
