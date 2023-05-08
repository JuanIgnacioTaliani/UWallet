using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWallet.Entidades;
using UWallet.Repositorio;

namespace UWallet.Servicios
{
    internal class CotizacionesServicio
    {
        private readonly CotizacionesRepositorio repositorio;

        public CotizacionesServicio()
        {
            repositorio = new CotizacionesRepositorio();
        }

        public Cotizacion obtenerCotizacionReciente(int id)
        {
            return repositorio.obtenerCotizacionReciente(id);
        }

        public float obtenerPrecioReciente(int id_cripto)
        {
            return repositorio.obtenerPrecioReciente(id_cripto);
        }

        public List<Cotizacion> GetCotizaciones()
        {
            return repositorio.GetCotizaciones();
        }
    }
}
