using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UWallet.Entidades;
using UWallet.Repositorio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UWallet.Servicios
{
    public class UsuariosServicio
    {
        private readonly UsuarioRepositorio usuarioRepositorio; 
        public static Usuario UsuarioLogueado;
        public UsuariosServicio()
        {
            usuarioRepositorio = new UsuarioRepositorio();
        }

        public bool Login(Usuario usuario)
        {
            var usuarioLogueado = usuarioRepositorio.Login(usuario);
            if (usuarioLogueado == null)
                return false;
            UsuarioLogueado = usuarioLogueado;
            return true;
        }

        public bool verificarDatos(Usuario usuario , string contrasenia) 
        {
            return verificarContrasenia(usuario.getContrasenia(), contrasenia) && !verificarNombre(usuario.getNombre()) && !verificarEmail(usuario.getEmail()) && !usuarioNoRepetido(usuario);
        }
        public bool verificarNombre(string nombre) { return string.IsNullOrEmpty(nombre); }
        public bool verificarCaracteres(string cadena, int maximo) { return cadena.Length > maximo; }
        public bool verificarEmail(string email) { return string.IsNullOrEmpty(email); }

        public bool verificarContrasenia(string contrasenia1, string contrasenia2) { return contrasenia1 == contrasenia2; }

        public void Register(Usuario usuario) { usuarioRepositorio.Register(usuario.getNombre(),usuario.getContrasenia(),usuario.getEmail(),usuario.getPerfil().getIdPerfil()); Login(usuario); }
    
        private bool usuarioNoRepetido(Usuario usuario) { return usuarioRepositorio.usuarioExiste(usuario.getNombre()); }
    }
}
