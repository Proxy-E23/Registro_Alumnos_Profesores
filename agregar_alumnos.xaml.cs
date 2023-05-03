using OfficeOpenXml;
using Registro_Alumnos_profesores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
        toExcel tE = new toExcel();

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
        
        private void txt_matricula_TextChanged(object sender, TextChangedEventArgs e)
        {
            gm.ConvertirAMayusculas(txt_matricula);
        }

        private void txt_nombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            gm.PrimeraLetraAMayusculas(txt_nombre);
        }

        private void txt_apelido_1_TextChanged(object sender, TextChangedEventArgs e)
        {
            gm.PrimeraLetraAMayusculas(txt_apelido_1);
        }

        private void txt_apelido_2_TextChanged(object sender, TextChangedEventArgs e)
        {
            gm.PrimeraLetraAMayusculas(txt_apelido_2);
        }

        private void txt_calle_TextChanged(object sender, TextChangedEventArgs e)
        {
            gm.PrimeraLetraAMayusculas(txt_calle);
        }

        private void txt_Anumero_TextChanged(object sender, TextChangedEventArgs e)
        {            

        }
        private void txt_colonia_TextChanged(object sender, TextChangedEventArgs e)
        {
            gm.PrimeraLetraAMayusculas(txt_colonia);
        }

        private void txt_Acp_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        private void txt_ciudad_TextChanged(object sender, TextChangedEventArgs e)
        {
            gm.PrimeraLetraAMayusculas(txt_ciudad);
        }
        private void txt_estado_TextChanged(object sender, TextChangedEventArgs e)
        {
            gm.PrimeraLetraAMayusculas(txt_estado);
        }
        private void txt_email_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_Atelefono_TextChanged(object sender, TextChangedEventArgs e)
        {
            
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

        private void ExportarExcel_Click(object sender, RoutedEventArgs e)
        {
            DataTable datos = new DataTable();
            datos.Columns.Add("Matricula", typeof(string));
            datos.Columns.Add("Aula", typeof(string));
            datos.Columns.Add("Nombre", typeof(string));
            datos.Columns.Add("Apellido P", typeof(string));
            datos.Columns.Add("Apellido M", typeof(string));
            datos.Columns.Add("Calle", typeof(string));
            datos.Columns.Add("Numero", typeof(int));
            datos.Columns.Add("Colonia", typeof(string));
            datos.Columns.Add("Ciudad", typeof(string));
            datos.Columns.Add("Estado", typeof(string));
            datos.Columns.Add("Codigo Postal", typeof(int));
            datos.Columns.Add("Email", typeof(string));
            datos.Columns.Add("Telefono", typeof(string));
            datos.Columns.Add("Fecha de Nacimiento", typeof(string));

            string aula = combbx_aula.SelectedItem != null ? (string)((ComboBoxItem)combbx_aula.SelectedItem).Content : "";
            DateTime fechaNacimiento = dp_fecha.SelectedDate != null ? dp_fecha.SelectedDate.Value : DateTime.MinValue;
            string fechaFormateada = fechaNacimiento.ToString("dd/MM/yyyy");

            datos.Rows.Add(txt_matricula.Text, aula, txt_nombre.Text, txt_apelido_1.Text,
                          txt_apelido_2.Text, txt_calle.Text, txt_numero.Text, txt_colonia.Text, txt_ciudad.Text, txt_estado.Text,
                          txt_cp.Text, txt_email.Text, txt_telefono.Text, fechaFormateada);

            string nombreArchivo = string.Format("{0}_{1}_{2}_{3}.xlsx", txt_matricula.Text, txt_nombre.Text, txt_apelido_1.Text, txt_apelido_2.Text);
            toExcel.ExportarAExcel(datos, nombreArchivo);
        }

    }
}
