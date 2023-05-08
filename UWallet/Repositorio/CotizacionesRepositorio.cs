using UWallet.Entidades;
using System;
using System.Collections.Generic;
using System.Data;


namespace UWallet.Repositorio
{
    public class CotizacionesRepositorio
    {
        public List<Cotizacion> GetCotizaciones()
        {
            var cotizaciones = new List<Cotizacion>();
            var sql = $"SELECT c.*, cri.* FROM Cotizaciones c JOIN Criptomonedas cri On c.id_cripto = cri.id_cripto WHERE DAY(GETDATE()) = day(c.fecha_hora_cotizacion)";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sql);
            foreach (DataRow fila in tabla.Rows)
            {
                // Informacion de Cotizaciones
                DateTime fecha = Convert.ToDateTime(fila["fecha_hora_cotizacion"].ToString());
                float precio = (float)Convert.ToDouble(fila["precio"].ToString());
                //Informacion de la Criptomoneda 
                int id = Convert.ToInt32(fila["id_cripto"].ToString());
                int cantidad = Convert.ToInt32(fila["cantidad"].ToString());
                var nombre = fila["nombre_cripto"].ToString();
                var abrev = fila["abreviacion_cripto"].ToString();
                var logo = fila["logo"].ToString();
                var cripto = new Criptomoneda(id, nombre, abrev, cantidad, logo);
                var cotizacion = new Cotizacion(fecha, cripto, precio);
                cotizaciones.Add(cotizacion);
            }
            return cotizaciones;
        }
        public float obtenerPrecioReciente(int id_cripto)
        {
            var sqlPrecio = $"SELECT id_cripto, precio FROM Cotizaciones WHERE id_cripto = {id_cripto} " +
                        $"AND fecha_hora_cotizacion = (SELECT MAX(fecha_hora_cotizacion) FROM Cotizaciones)";
            var precio = (float)Math.Round(Convert.ToDouble(DBHelper.GetDBHelper().ConsultaDuranteTransaccion(sqlPrecio).Rows[0][0]));
            return precio;
        }

        public Cotizacion obtenerCotizacionReciente(int id)
        {
            //string sqlPrecio = $"SELECT CO.fecha_hora_cotizacion, CO.precio, CR.abreviacion_cripto, CR.cantidad FROM Cotizaciones CO, Criptomonedas CR " +
            //    $"WHERE CO.id_cripto = CR.id_cripto AND CR.id_cripto = {id} AND CO.fecha_hora_cotizacion = (SELECT MAX(COO.fecha_hora_cotizacion) FROM Cotizaciones COO)";
            string sqlPrecio = $"SELECT CO.fecha_hora_cotizacion, CO.precio, CR.abreviacion_cripto, CR.cantidad FROM Cotizaciones CO, Criptomonedas CR WHERE CO.id_cripto = CR.id_cripto  AND CO.fecha_hora_cotizacion = (SELECT MAX(COO.fecha_hora_cotizacion) FROM Cotizaciones COO WHERE COO.id_cripto = {id})";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sqlPrecio);
            Cotizacion cotizacion = null;
            foreach (DataRow fila in tabla.Rows)
            {
                DateTime fecha = Convert.ToDateTime(fila["fecha_hora_cotizacion"].ToString());
                float precio = (float)Convert.ToDouble(fila["precio"].ToString());
                string abreviacion = fila["abreviacion_cripto"].ToString();
                double cantidad = Convert.ToDouble(fila["cantidad"].ToString());
                var cripto = new Criptomoneda(id, abreviacion, cantidad);
                cotizacion = new Cotizacion(fecha, cripto, precio);
            }
            return cotizacion;
        }

    }
}


