using System;
using System.Collections.Generic;
using System.Data;
using UWallet.Entidades;

namespace UWallet.Repositorio
{
    public class PaisesRepositorio
    {
        public List<Pais> obtenerPaises()
        {
            var sql = $"SELECT id_pais,nombre FROM Paises";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var paises = new List<Pais>();

            foreach (DataRow fila in tabla.Rows)
            {
                int id = (int) Convert.ToInt64(fila["id_pais"].ToString());
                var pais = new Pais(fila["nombre"].ToString(),id);
                paises.Add(pais);
            }

            return paises;
        }

        public void Delete(int id_pais) 
        {
            var sql = $"DELETE FROM Paises WHERE id_pais = {id_pais}";
            DBHelper.GetDBHelper().EjecutarSQL(sql);
        }

        public bool Exists(string pais)
        {
            var sql = $"SELECT 1 FROM Paises WHERE nombre='{pais}'";
            return DBHelper.GetDBHelper().ConsultaSQL(sql).Rows.Count != 0;
        }

        public int obtenerPais(string pais)
        {
            var sql = $"SELECT id_pais FROM Paises WHERE nombre='{pais}'";
            var id = (int) Convert.ToInt64(DBHelper.GetDBHelper().ConsultaSQL(sql).Rows[0][0].ToString());
            return id ;
        }

        public void Register(string nombre) 
        {
            var sql = $"INSERT INTO Paises (nombre) VALUES ('{nombre}')";
            DBHelper.GetDBHelper().EjecutarSQL(sql);
        }

        public void Update(Pais pais) 
        {
            var sql = $"UPDATE Paises SET nombre='{pais.getNombre()}' WHERE id_pais={pais.getId()}";
            DBHelper.GetDBHelper().EjecutarSQL(sql);
        }
    }
}