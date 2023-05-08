using UWallet.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWallet.Repositorio
{
    public class MonederoRepositorio
    {
        public List<Monedero> GetMonederos(Usuario usuario)
        {
            var monederos = new List<Monedero>();
            var sql = $"SELECT m.saldo, c.* FROM Monederos m JOIN Criptomonedas c On m.id_cripto = c.id_cripto WHERE m.id_usuario = {usuario.getIdUsuario()}";
            var tablaResultados = DBHelper.GetDBHelper().ConsultaSQL(sql);

            foreach (DataRow fila in tablaResultados.Rows)
            {
                // criptomoneda
                int id = Convert.ToInt32(fila["id_cripto"].ToString());
                double cant = (double)fila["cantidad"];
                var nombre = fila["nombre_cripto"].ToString();
                var abr = fila["abreviacion_cripto"].ToString();
                var logo = (string) fila["logo"];
                var cripto = new Criptomoneda(id, nombre, abr, cant, logo);
                // Monedero
                float saldo = (float)Convert.ToDouble(fila["saldo"]);
                var _monedero = new Monedero(usuario, cripto, saldo);

                monederos.Add(_monedero);
            }
            return monederos;
        }

        public int AgregarMonedero(Monedero monedero)
        {
            //SET IDENTITY_INSERT Monederos ON + SET IDENTITY_INSERT Monederos Off
            var sql = $"INSERT INTO Monederos(id_usuario, id_cripto, saldo) VALUES ({monedero.getUsuario().getIdUsuario()}, {monedero.getCripto().Id}, {monedero.getSaldo()})";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sql);
            return filasAfectadas;
        }

        public int EliminarMonedero(int idCripto, int idUsuario)
        {
            var sql = $"DELETE FROM Monederos WHERE id_cripto ={idCripto} AND id_usuario = {idUsuario} AND saldo = 0";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sql);
            return filasAfectadas;
        }
    }
}
