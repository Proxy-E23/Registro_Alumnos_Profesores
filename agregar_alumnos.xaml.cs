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
    public partial class agregar_alumnos : Window

    {
        //Variables
        general_methods gm = new general_methods();

        public agregar_alumnos()
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
        }

        private void btn_Avolver_Click(object sender, RoutedEventArgs e)
        {                        
            gm.A_menu_principal(this);
        }

        private void btn_Aagregar_Click(object sender, RoutedEventArgs e)
        {            
        }

        private void btn_Acancelar_Click(object sender, RoutedEventArgs e)
        {            
            gm.LimpiarCampos(this);
        }

        private void txt_Anumero_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txt_Acp_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txt_Atelefono_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
