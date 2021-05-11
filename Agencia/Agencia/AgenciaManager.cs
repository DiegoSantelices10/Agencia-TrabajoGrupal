using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agencia;

namespace Agencia
{
    public class AgenciaManager
    {

        List<Usuario> misUsuarios = new List<Usuario>();
        List<Reserva> misReservas = new List<Reserva>();
        public Agencia miAgencia = new Agencia();
        public Usuario us;

        

        public List<string> buscarAlojamiento(string ciudad, DateTime pDesde, DateTime pHasta, int cantPersonas, string tipo)
        {
            
            List<string> busqueda = new List<string>();
            return busqueda;
          
        }

        public bool agregarAlojamiento(Alojamiento al)
        {
            return true;
        }

        public bool modificarAlojamiento(Alojamiento al)
        {
            return true;
        }
        public bool quitarAlojamiento(int codigo)
        {
            return true;
        }

        public List<string> buscarReservas(int DNIusuario)
        {
            List<string> busqueda = new List<string>();

            return busqueda;
        } 

        public bool reservar(int codAloj, int dniUsuario, DateTime fDesde, DateTime fHasta)
        {
            return true;
        }

        public bool modificarReserva(Reserva re)
        {
            return true;
        }

        public bool eliminarReserva(int cod)
        {
            return true;
        }

        public bool autenticarUsuario(int DNI, string password)
        {
            return true;
        }

        public bool desbloquearUsuario(int DNI)
        {
            return true;
        }

      



        public bool agregarUsuario(int dni, string username, string email, string password, string esAdmin)
        {
               bool admin = true;

            if (esAdmin == "Administrador")
            {
                us = new Usuario(dni, username, email, password, admin);  
                misUsuarios.Add(us);
                MessageBox.Show("se agrego al administrador correctamente");
            } else
             {
                admin = false;
                us = new Usuario(dni, username, email, password, admin);
                
                misUsuarios.Add(us);
               
                MessageBox.Show("se agrego al usuario correctamente");
            }
            return admin;
        }


        public bool modificarUsuario(Usuario u)
        {
            return true;
        }


        public bool eliminarUsuario(int DNI)
        {
            return true;
        }

        public void mostrarUsuario()
        {
            
            foreach (var usuario in misUsuarios)
            {
                Console.WriteLine($"( nombre: {usuario.nombre}) (dni: {usuario.dni}) (password:{usuario.password}) (email: {usuario.email})");



            }
        }




    }
}
