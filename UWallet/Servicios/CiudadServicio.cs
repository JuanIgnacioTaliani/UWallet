using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWallet.Entidades;
using UWallet.Repositorio;

namespace UWallet.Servicios
{
    internal class CiudadServicio
    {
        private CiudadRepositorio repositorio;
        public CiudadServicio() { repositorio = new CiudadRepositorio(); }
        public List<Ciudad> obtenerCiudades() { return repositorio.obtenerCiudades(); }
        public void Delete(int id_ciudad) { repositorio.Delete(id_ciudad); }
        public bool Validate(Ciudad ciudad) { return ciudad.ValidarPais() && ciudad.ValidarNombre(); }
        public bool Exists(Ciudad ciudad) { return repositorio.Exists(ciudad);}
        public void Register(Ciudad ciudad) { repositorio.Register(ciudad.getNombre(), ciudad.getPais().getId()); }
        public void Update(Ciudad ciudad) { repositorio.Update(ciudad.getId(), ciudad.getNombre(), ciudad.getPais().getId()); }
    }
}
