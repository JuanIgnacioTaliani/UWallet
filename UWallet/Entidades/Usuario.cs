using System;

namespace UWallet.Entidades
{
    public class Usuario
    {
        #region Atributos
        private int id;
        private string nombre;
        private string contrasenia;
        private Perfil perfil;
        private string mail;
        private DateTime fecha_alta;

        #endregion

        #region Accesores
        public void setIdUsuario(int id) { this.id = id; }
        public int getIdUsuario() { return this.id; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public string getNombre() { return this.nombre; }
        public void setContrasenia(string contrasenia) { this.contrasenia = contrasenia; }
        public string getContrasenia() { return this.contrasenia; }
        public void setPerfil(Perfil perfil) { this.perfil = perfil; }
        public Perfil getPerfil() { return this.perfil; }
        public void setFechaAlta(DateTime fecha_alta) { this.fecha_alta = fecha_alta; }
        public DateTime getFechaAlta() { return this.fecha_alta; }
        public void setEmail(string email) { this.mail = email; }
        public string getEmail() { return this.mail; }
        #endregion

        public Usuario(int id, string mail,string nombre,string contrasenia,Perfil perfil) 
        {
            this.id = id;
            this.nombre = nombre;
            this.contrasenia = contrasenia;
            this.perfil = perfil;
            this.mail = mail;
           // this.fecha_alta = fecha_alta;
        }
        public Usuario(int id)
        {
            this.id = id;
        }
        public Usuario(string nombre, string contrasenia,string mail ,Perfil perfil)
        {
            this.nombre = nombre;
            this.contrasenia = contrasenia;
            this.perfil = perfil;
            this.mail = mail;
        }
        public Usuario(int id,string nombre, string contrasenia, Perfil perfil)
        {
            this.id = id;
            this.nombre = nombre;
            this.contrasenia = contrasenia;
            this.perfil = perfil;
        }

        public Usuario(string nombre, string contrasenia)
        {
            this.contrasenia = contrasenia;
            this.nombre = nombre;
        }
        public Usuario()
        {
        }
    }
}
