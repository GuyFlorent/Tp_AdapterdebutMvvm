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
using Pattern_Adapter;
using MvvM1;
namespace Tp_Adapter
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IVehicule monVehicule;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string type_Vehicule = cmb_Vehicule.Text;
            switch (type_Vehicule)
            {
                case "Avion":
                    monVehicule = new Avion();
                    break;
                case "Voiture":
                    monVehicule = new Voiture();
                    break;
                case "Moto":
                    monVehicule = new Moto();
                    break;
                default:
                    break;

            }
            monVehicule.Rouler();
        }
        private Vehicule_Adapter _vehiculeAdapater;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (monVehicule != null)
            {
                _vehiculeAdapater = new Vehicule_Adapter(monVehicule);
                _vehiculeAdapater.RoulerAdapter();
            }
            else
                Console.WriteLine("vehicule adapter null");
        }
    }
}
