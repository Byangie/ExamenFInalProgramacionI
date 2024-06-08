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
    /// Lógica de interacción para UpdateWindow.xaml
    /// </summary>
    public partial class UpdateWindow : Window
    {

        public UpdateWindow(int id)
        {
            InitializeComponent();
            DataAccess dataAccess = new DataAccess();
            Alumno alumno = dataAccess.GetById(id);
            txtIdUsario.Text = alumno.IdUsuario.ToString();
            txtCarnet.Text = alumno.Carnet;
            txtNombre.Text = alumno.Nombre;
            txtTelefono.Text = alumno.Telefono;
            txtGrado.Text = alumno.Grado;
            cboUsuario.ItemsSource = dataAccess.GetUsuario();
            cboUsuario.SelectedValue = alumno.Usuario;

        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            Alumno alumno = new Alumno
            {
                Carnet = txtCarnet.Text,
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Grado = txtGrado.Text,
                IdUsuario = int.Parse(txtIdUsario.Text),
                Id = int.Parse(cboUsuario.SelectedValue?.ToString() ?? "0")

            };
            int result = dataAccess.Update(alumno);
            if (result > 0)
            {
                MessageBox.Show("Alumno guardado correctamente");
            }
            this.Close();
        }
    }
}