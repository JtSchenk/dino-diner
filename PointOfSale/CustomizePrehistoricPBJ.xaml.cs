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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        // Backing variable
        private PrehistoricPBJ pbj;
        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }

        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            this.pbj.HoldPeanutButer();
        }

        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            pbj.HoldJelly();
        }

        public void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
