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

namespace datos_escuela
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

        private void btn_entrar_Click(object sender, RoutedEventArgs e)
        {            
            general_methods go_principal_menu = new general_methods();
            go_principal_menu.A_menu_principal(this);

        }

        private void btn_salir_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_salir_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }   
}
