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

namespace Crud_Alumnos
{
    /// <summary>
    /// Lógica de interacción para InsertWindow.xaml
    /// </summary>
    public partial class InsertWindow : Window
    {
        public InsertWindow()
        {
            InitializeComponent();
            DataAccess dataAccess = new DataAccess();
            //para desplegarnos todas las carreras disponibles
            cboUsuario.ItemsSource = dataAccess.GetUsuario();
        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            Alumno alumno = new Alumno
            {
                IdUsuario = int.Parse(txtIdUsario.Text),
                Carnet = txtCarnet.Text,
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Grado = txtGrado.Text,
                Id = int.Parse(cboUsuario.SelectedValue?.ToString() ?? "0")
                //Usuario = int.Parse(cboUsuario.SelectedValue?.ToString() ?? "0")
                //Usuario = int.Parse(cboCarreras.SelectedValue?.ToString() ?? "0")

            };
            int result = dataAccess.Create(alumno);
            if (result > 0)
            {
                MessageBox.Show("Alumno guardado correctamente");
            }
            this.Close();
        }
    }
}
