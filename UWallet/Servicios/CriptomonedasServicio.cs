using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UWallet.Entidades;
using UWallet.Repositorio;

namespace UWallet.Servicios
{
    public class CriptomonedasServicio
    {
        private CriptoRepositorio repositorio;
        public CriptomonedasServicio() { repositorio = new CriptoRepositorio(); }
        public List<Criptomoneda> GetCriptomonedas() { return repositorio.GetCriptomonedas(); }
        public void Delete(int id_cripto) { repositorio.Delete(id_cripto); }
        public bool Validate(Criptomoneda cripto) { return cripto.ValidarAbreviacion() && cripto.ValidarCantidad() && cripto.ValidarNombre(); } 
        public bool Exists(Criptomoneda cripto) { return repositorio.Exists(cripto); }
        public void Register(Criptomoneda cripto) { repositorio.Register(cripto); }
        public void Update(Criptomoneda cripto) { repositorio.Update(cripto); }
    }
}
