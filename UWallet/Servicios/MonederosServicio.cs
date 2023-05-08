using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWallet.Entidades;
using UWallet.Repositorio;

namespace UWallet.Servicios
{
    public class MonederosServicio
    {
        private readonly MonederoRepositorio monederoRepositorio;
        public MonederosServicio()
        {
            monederoRepositorio = new MonederoRepositorio();
        }

        public List<Monedero> GetMonederos()
        {
            return monederoRepositorio.GetMonederos(UsuariosServicio.UsuarioLogueado);
        }

        public bool AgregarMonedero(Monedero newMonedero)
        {
            int filasAfectadas = monederoRepositorio.AgregarMonedero(newMonedero);  
            if (filasAfectadas == 0)
                return false;
            return true; 
        }

        public bool EliminarMonedero(int idCripto, int idUsuario)
        {
            int filasAfectadas = monederoRepositorio.EliminarMonedero(idCripto, idUsuario);
            if (filasAfectadas == 0)
                return false;
            return true;
        }
    }
}
