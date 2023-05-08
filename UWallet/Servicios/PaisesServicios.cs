using System.Collections.Generic;
using UWallet.Entidades;
using UWallet.Repositorio;

namespace UWallet.Servicios
{
    public class PaisesServicios
    {   
        private PaisesRepositorio repositorio;
        public PaisesServicios() { repositorio = new PaisesRepositorio(); }
        public List<Pais> obtenerPaises() { return repositorio.obtenerPaises(); }
        public void Delete(int id_pais) { repositorio.Delete(id_pais); }
        public bool Validate(Pais pais) { return pais.ValidarNombre(); }
        public bool Exist(Pais pais) { return repositorio.Exists(pais.getNombre()); }
        public void Register(Pais pais) { repositorio.Register(pais.getNombre()); }
        public int obtenerPais(string pais) { return repositorio.obtenerPais(pais); }
        public void Update(Pais pais) { repositorio.Update(pais); }

    }
}
