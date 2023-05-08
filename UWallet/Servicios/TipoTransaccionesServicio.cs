using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWallet.Entidades;
using UWallet.Repositorio;

namespace UWallet.Servicios
{
    public class TipoTransaccionesServicio
    {
        private readonly TipoTransaccionesRepositorio repositorio;

        public TipoTransaccionesServicio()
        {
            repositorio = new TipoTransaccionesRepositorio();
        }

        public TipoTransaccion obtenerTipoTransaccion(int id_tipo) 
        { 
            return repositorio.obtenerTipoTransaccion(id_tipo); 
        }
    }
}
