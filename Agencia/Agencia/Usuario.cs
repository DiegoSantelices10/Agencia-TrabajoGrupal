using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia
{
    public class Usuario
    {
        public int dni { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool esAdmin { get; set; }
        public bool bloqueado { get; set; }




        public Usuario(int dni, string nombre, string email, string password, bool esAdmin)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.email = email;
            this.password = password;
            this.esAdmin = esAdmin; 
        }



    }
}
