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
using System.Windows.Shapes;

namespace datos_escuela
{
    /// <summary>
    /// Lógica de interacción para main_menu.xaml
    /// </summary>
    public partial class main_menu : Window
    {
        general_methods gm = new general_methods();
        public main_menu()
        {
            InitializeComponent();            
        }

        private void btn_cerrar_sesion_Click(object sender, RoutedEventArgs e)
        {
            gm.A_login(this);
        }
        private void btn_salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_alum_Click(object sender, RoutedEventArgs e)
        {
            gm.A_agregar_alumnos(this);
        }

        private void btn_profes_Click(object sender, RoutedEventArgs e)
        {
            gm.A_gregar_profesores(this);
        }

        private void btn_alumnos_Admin_Click(object sender, RoutedEventArgs e)
        {
            gm.A_admon_alumnos(this);
        }

        private void btn_person_adm_Click(object sender, RoutedEventArgs e)
        {
            gm.A_admon_profesores(this);
        }
    }
}
