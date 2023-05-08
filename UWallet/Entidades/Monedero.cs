namespace UWallet.Entidades
{
    public class Monedero
    {
        #region Atributos
        private Usuario usuario;
        private Criptomoneda cripto;
        private float saldo;
        #endregion

        #region Accesores
        public void setIdUsuario(Usuario usuario) { this.usuario = usuario; }
        public Usuario getUsuario() { return this.usuario; }
        public void setCripto(Criptomoneda cripto) { this.cripto = cripto; }
        public Criptomoneda getCripto() { return this.cripto; }
        public void setSaldo(float monto) { this.saldo = monto; }
        public float getSaldo() { return this.saldo; }
        #endregion

        public Monedero()
        {

        }
        public Monedero(Usuario usuario, Criptomoneda cripto, float saldo)
        {
            this.usuario = usuario;
            this.cripto = cripto;
            this.saldo = saldo;
        }
    }
}

