using UWallet.Entidades;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace UWallet.Repositorio
{
    public class UsuarioRepositorio
    {
        
        public Usuario Login(Usuario usuario)
        {
            var sql = $"SELECT u.*, p.* FROM Usuarios u JOIN Perfiles p ON u.id_perfil = p.id_perfil WHERE nombre='{usuario.getNombre()}' AND contrasenia='{usuario.getContrasenia()}'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            Usuario usuarioLogueado = null;
            if (tablaResultado.Rows.Count == 1)
            {
                var fila = tablaResultado.Rows[0];
                var nombre = fila["nombre"].ToString();
                var contrasenia = fila["contrasenia"].ToString();
                //var fecha = Convert.ToDateTime(fila["fecha_alta"]);
                var idUsuario = Convert.ToInt32(fila["id_usuario"].ToString());
                var idPerfil = Convert.ToInt32(fila["id_perfil"].ToString());
                var descripcion = fila["descripcion_perfil"].ToString();
                var perfil = new Perfil(idPerfil, descripcion);
                usuarioLogueado = new Usuario(idUsuario, nombre, contrasenia, perfil);
            }
            return usuarioLogueado;
        }

        public void Register(string nombre, string contrasenia, string email,int id_perfil)
        {
            var sql = $"INSERT INTO Usuarios (nombre,contrasenia,email,id_perfil) VALUES ('{nombre}','{contrasenia}','{email}',{id_perfil})";
            DBHelper.GetDBHelper().EjecutarSQL(sql);
        }

        public bool usuarioExiste(string usuario) 
        {
            var sql = $"SELECT 1 FROM Usuarios WHERE nombre='{usuario}'";
            return DBHelper.GetDBHelper().ConsultaSQL(sql).Rows.Count != 0;
        }


    }
}
