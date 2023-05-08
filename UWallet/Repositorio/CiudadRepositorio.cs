using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWallet.Entidades;

namespace UWallet.Repositorio
{
    internal class CiudadRepositorio
    {
        public List<Ciudad> obtenerCiudades()
        {
            var sql = $"SELECT c.nombre,id_ciudad,p.id_pais,p.nombre as nombrePais FROM Ciudades c JOIN Paises p ON c.cod_pais = p.id_pais";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var ciudades = new List<Ciudad>();

            foreach (DataRow fila in tabla.Rows)
            {
                int id = (int)Convert.ToInt64(fila["id_ciudad"].ToString());
                int id_pais = (int)Convert.ToInt64(fila["id_pais"].ToString());
                Pais pais = new Pais(fila["nombrePais"].ToString(),id_pais);
                var ciudad = new Ciudad(fila["nombre"].ToString(), id, pais);
                ciudades.Add(ciudad);
            }

            return ciudades;
        }

        public void Delete(int id_ciudad)
        {
            var sql = $"DELETE FROM Ciudades WHERE id_ciudad = {id_ciudad}";
            DBHelper.GetDBHelper().EjecutarSQL(sql);
        }
        public bool Exists(Ciudad ciudad)
        {
            var sql = $"SELECT 1 FROM Ciudades WHERE nombre = '{ciudad.getNombre()}' AND cod_pais={ciudad.getPais().getId()}";
            return DBHelper.GetDBHelper().ConsultaSQL(sql).Rows.Count != 0;
        }

        public void Register(string nombre,int pais)
        {
            var sql = $"INSERT INTO Ciudades (nombre,cod_pais) VALUES ('{nombre}',{pais})";
            DBHelper.GetDBHelper().EjecutarSQL(sql);
        }

        public void Update(int id_ciudad, string nombre, int pais)
        {
            var sql = $"UPDATE Ciudades SET nombre = '{nombre}', cod_pais = {pais} WHERE id_ciudad = {id_ciudad}";
            DBHelper.GetDBHelper().EjecutarSQL(sql);
        }
    }
}
