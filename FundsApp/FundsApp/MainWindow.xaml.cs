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
using FundsApp;

namespace FundsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AppManager appManager;

        public MainWindow()
        {
             InitializeComponent();
             // Start Apps manager
             appManager = new AppManager();

             appManager.SetAccountBal();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            appManager.CreateBill(stkPan);
        }

    }
}
