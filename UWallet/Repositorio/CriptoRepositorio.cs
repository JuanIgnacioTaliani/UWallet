using UWallet.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;

namespace UWallet.Repositorio
{
    public class CriptoRepositorio
    {
        public List<Criptomoneda> GetCriptomonedas()
        {
            var criptomonedas = new List<Criptomoneda>();
            var sql = $"SELECT * FROM Criptomonedas WHERE cantidad != 0";
            var tablaResultados = DBHelper.GetDBHelper().ConsultaSQL(sql);

            foreach (DataRow fila in tablaResultados.Rows)
            {
                int id = Convert.ToInt32(fila["id_cripto"].ToString());
                double cant = (double)fila["cantidad"];
                var nombre = fila["nombre_cripto"].ToString();
                var abr = fila["abreviacion_cripto"].ToString();
                var logo = (string) fila["logo"];
                var cripto = new Criptomoneda(id, nombre, abr, cant, logo);

                criptomonedas.Add(cripto);
            }
            return criptomonedas;
        }

        public void Delete(int id_cripto) 
        {
            var sql = $"DELETE FROM Criptomonedas WHERE id_cripto = {id_cripto}";
            DBHelper.GetDBHelper().EjecutarSQL(sql);
        }

        public void Register(Criptomoneda cripto) 
        {
            var sql = $"INSERT INTO Criptomonedas (nombre_cripto,logo,abreviacion_cripto,cantidad,esta_activo) VALUES ('{cripto.Nombre}','{cripto.Logo}','{cripto.Abreviacion}', {cripto.Cantidad},1)";
            DBHelper.GetDBHelper().EjecutarSQL(sql);
        }

        public bool Exists(Criptomoneda cripto) 
        {
            var sql = $"SELECT 1 FROM Criptomonedas WHERE nombre_cripto='{cripto.Nombre}' AND abreviacion_cripto='{cripto.Abreviacion}' AND cantidad={cripto.Cantidad} AND logo='{cripto.Logo}'";
            return DBHelper.GetDBHelper().ConsultaSQL(sql).Rows.Count != 0;
        }
        public void Update(Criptomoneda cripto) 
        {
            var sql =$"Update Criptomonedas SET nombre_cripto='{cripto.Nombre}',abreviacion_cripto='{cripto.Abreviacion}',cantidad={cripto.Cantidad},logo='{cripto.Logo}' WHERE id_cripto={cripto.Id}" ;
            DBHelper.GetDBHelper().EjecutarSQL(sql);
        }
    }
}
