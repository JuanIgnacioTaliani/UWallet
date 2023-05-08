using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWallet.Repositorio
{
    public class PerfilesRepositorio
    {
        // Validar el Perfil que posee el Usuario Logueado
        // Devuelve: True si es asi
        public bool ValidarPerfil(string nombre, string contrasenia, int id_perfil)
        {
            // id_perfil = 1 -> Administrador
            // id_perfil = 2 -> Cliente
            var sql = $"SELECT * FROM Usuarios  WHERE  nombre='{nombre}' AND contrasenia='{contrasenia}' AND id_perfil={id_perfil}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            if (tablaResultado.Rows.Count == 0)
                return false;
            return true;
        }

    }
}
