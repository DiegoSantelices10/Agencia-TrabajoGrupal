using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia
{
    class Usuario
    {
        private int DNI;
        private string nombre;
        private string email;
        private string password;
        private bool esAdmin;
        private bool bloqueado;

        public Usuario(int dNI, string nombre, string email, string password, bool esAdmin, bool bloqueado)
        {
            DNI = dNI;
            this.nombre = nombre;
            this.email = email;
            this.password = password;
            this.esAdmin = esAdmin;
            this.bloqueado = bloqueado;
        }
    }
}
