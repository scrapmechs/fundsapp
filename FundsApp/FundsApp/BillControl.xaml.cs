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

namespace FundsApp
{
    /// <summary>
    /// Interaction logic for BillControl.xaml
    /// </summary>
    public partial class BillControl : UserControl
    {
        public BillControl()
        {
            InitializeComponent();
        }

        private void btnRmove_Click(object sender, RoutedEventArgs e)
        {
            // remove Onclick
            ((Panel)this.Parent).Children.Remove(this);
        }

        private void txtBxPay_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
