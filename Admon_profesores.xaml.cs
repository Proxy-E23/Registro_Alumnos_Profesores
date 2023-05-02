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
    /// Lógica de interacción para Admon_profesores.xaml
    /// </summary>
    public partial class Admon_profesores : Window
    {
        general_methods gm = new general_methods();
        public Admon_profesores()
        {
            InitializeComponent();
            general_methods valtxt = new general_methods();

            valtxt.soloNumeros(txt_numero);
            valtxt.soloNumeros(txt_cp);
            valtxt.soloNumeros(txt_telefono);
            valtxt.SoloLetras(txt_nombre);
            valtxt.SoloLetras(txt_apelido_1);
            valtxt.SoloLetras(txt_apelido_2);
            valtxt.SoloLetras(txt_ciudad);
            valtxt.SoloLetras(txt_estado);

            gm.inhabilitarControles(combbx_aula, txt_nombre, txt_apelido_1, txt_apelido_2, txt_calle, txt_numero,
                txt_colonia, txt_cp, txt_ciudad, txt_estado, txt_email, txt_telefono, dp_fechanac, btn_actualizar);

        }

        private void btn_Avolver_Click(object sender, RoutedEventArgs e)
        {
            general_methods go_principal_menu = new general_methods();
            go_principal_menu.A_menu_principal(this);
        }

        private void btn_Aagregar_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn_Acancelar_Click(object sender, RoutedEventArgs e)
        {
            general_methods Limpiar = new general_methods();
            Limpiar.LimpiarCampos(this);
        }
        private void cb_modificar_Checked(object sender, RoutedEventArgs e)
        {
            if (cb_modificar.IsChecked == true)
            {
                gm.inhabilitarControles(txt_matricula, btn_buscar);
                gm.habilitarControles(combbx_aula, txt_nombre, txt_apelido_1, txt_apelido_2, txt_calle, txt_numero, txt_colonia, txt_cp, txt_ciudad, txt_estado, txt_email, txt_telefono, dp_fechanac, btn_actualizar);
            }
        }

        private void cb_modificar_Unchecked(object sender, RoutedEventArgs e)
        {
            if (cb_modificar.IsChecked == false)
            {
                gm.habilitarControles(txt_matricula, btn_buscar);
                gm.inhabilitarControles(combbx_aula, txt_nombre, txt_apelido_1, txt_apelido_2, txt_calle, txt_numero, txt_colonia, txt_cp, txt_ciudad, txt_estado, txt_email, txt_telefono, dp_fechanac);
            }
        }

    }
}
