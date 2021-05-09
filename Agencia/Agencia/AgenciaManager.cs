using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencia
{
    class AgenciaManager
    {
        List<Usuario> misUsuarios = new List<Usuario>();
        List<Reserva> misReservas = new List<Reserva>();
        public Agencia miAgencia;

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

        public bool agregarUsuario(Usuario u)
        {
            return true;
        }

        public bool modificarUsuario(Usuario u)
        {
            return true;
        }


        public bool eliminarUsuario(int DNI)
        {
            return true;
        }






    }
}
