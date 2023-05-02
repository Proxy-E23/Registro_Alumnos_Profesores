using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace datos_escuela
{
    class general_methods
    {
        //ABRIR VENTANAS

        //Abrir login
        public void A_login(Window ventanaActual)
        {
            ventanaActual.Hide();
            MainWindow abrirLogin = new MainWindow();
            abrirLogin.Show();
        }
        
        //Volver al Menu principal
        public void A_menu_principal(Window ventanaActual)
        {
            ventanaActual.Hide();
            main_menu menu_principal = new main_menu();
            menu_principal.Show();
        }

        //abrir agregar alumnos
        public void A_agregar_alumnos(Window ventanaActual)
        {
            ventanaActual.Hide();
            agregar_alumnos open_add_alumnos = new agregar_alumnos();
            open_add_alumnos.Show();
        }

        //abrir Administrar alumnos
        public void A_admon_alumnos(Window ventanaActual)
        {
            ventanaActual.Hide();
            Admom_alumnos open_admon_alumnos = new Admom_alumnos();
            open_admon_alumnos.Show();
        }

        //abrir agregar profesores
        public void A_gregar_profesores(Window ventanaActual)
        {
            ventanaActual.Hide();
            agregar_profesores open_agregar_profesores = new agregar_profesores();
            open_agregar_profesores.Show();
        }

        //abrir administrar profesores
        public void A_admon_profesores(Window ventanaActual)
        {
            ventanaActual.Hide();
            Admon_profesores open_admon_personal = new Admon_profesores();
            open_admon_personal.Show();
        }
        //-----------------------------------------------------------------------------------

        //VALIDACIONES DE CAMPOS
        // Metodo para Limpiar los campos de una ventana
        public void LimpiarCampos(DependencyObject obj)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                var child = VisualTreeHelper.GetChild(obj, i);

                if (child is TextBox)
                {
                    ((TextBox)child).Clear();                    
                }
                else if (child is ComboBox)
                {
                    ((ComboBox)child).SelectedIndex = -1;
                }
                else if (child is CheckBox)
                {
                    ((CheckBox)child).IsChecked = false;
                }
                LimpiarCampos(child);
            }
        }

        //Validar que solo se ingresen numeros
        public void soloNumeros(object sender)
        {
            if (sender is TextBox txt)
            {
                txt.PreviewTextInput += new TextCompositionEventHandler((s, e) =>
                {
                    if (!char.IsDigit(e.Text[0]))
                    {
                        e.Handled = true;
                    }
                });
            }
        }

        //Validar que solo se ingresen letras
        public void SoloLetras(object sender)
        {
            if (sender is TextBox txt)
            {
                txt.PreviewTextInput += new TextCompositionEventHandler((s, e) =>
                {
                    if (!char.IsLetter(e.Text[0]) || !IsSpanishLetter(e.Text[0]))
                    {
                        e.Handled = true;
                    }
                });
            }
        }
        private bool IsSpanishLetter(char c)
        {
            return "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ".Contains(c);
        }

        //Deshabililitar campos
        public void inhabilitarControles(params Control[] controles)
        {
            foreach (Control control in controles)
            {
                control.IsEnabled = false;
            }
        }

        //Habililitar campos
        public void habilitarControles(params Control[] controles)
        {
            foreach (Control control in controles)
            {
                control.IsEnabled = true;
            }
        }
        //--------------------------------------------------------------------------------------

    }
}