using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Usuario
    {
        private int id_usuario;
        private string rut_usuario;
        private string tipo_usuario;
        private string clave;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Rut_usuario { get => rut_usuario; set => rut_usuario = value; }
        public string Tipo_usuario { get => tipo_usuario; set => tipo_usuario = value; }
        public string Clave { get => clave; set => clave = value; }
    }
}
