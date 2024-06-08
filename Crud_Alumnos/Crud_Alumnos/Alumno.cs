using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Controls;
using System.IO.Packaging;

namespace Crud_Alumnos
{
    public class Alumno
    {
        public int IdUsuario { get; set; }
        public string Carnet { get; set; }
        public string Nombre { get; set; }

        public string Telefono { get; set; }
        public string Grado { get; set; }
        public string Usuario { get; set; }
        public int Id { get; set; }
        public string NombreUsuario { get; set; }

    }
}