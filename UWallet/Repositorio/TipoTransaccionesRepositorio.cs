using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWallet.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UWallet.Repositorio
{
    internal class TipoTransaccionesRepositorio
    {
        public List<TipoTransaccion> obtenerTipoTransacciones()
        {
            var sql = $"SELECT * FROM Tipo_Transacciones";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var tipos = new List<TipoTransaccion>();

            foreach (DataRow fila in tabla.Rows)
            {
                int id = (int)Convert.ToInt64(fila["id_tipo"].ToString());
                string descrip = fila["descripcion_movimiento"].ToString();
                float comision = (float) Convert.ToDouble(fila["comision"].ToString());
                float monto_max = (float)Convert.ToDouble(fila["monto_max"].ToString());
                float monto_min = (float)Convert.ToDouble(fila["monto_min"].ToString());
                var tipo_tx = new TipoTransaccion(id, descrip, comision, monto_max, monto_min);
                tipos.Add(tipo_tx);
            }
            return tipos;
        }

        public TipoTransaccion obtenerTipoTransaccion(int id_tipo)
        {
            var sql = $"SELECT * FROM Tipo_Transacciones WHERE id_tipo={id_tipo}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sql);
            TipoTransaccion tipo_tx = null;
            foreach (DataRow fila in tabla.Rows)
            {
                int id = (int)Convert.ToInt64(fila["id_tipo"].ToString());
                string descrip = fila["descripcion_movimiento"].ToString();
                float comision = (float)Convert.ToDouble(fila["comision"].ToString());
                float monto_max = (float)Convert.ToDouble(fila["monto_max"].ToString());
                float monto_min = (float)Convert.ToDouble(fila["monto_min"].ToString());
                tipo_tx = new TipoTransaccion(id, descrip, comision, monto_max, monto_min);
            }
            return tipo_tx;
        }

        public int obtenerIdTipoTransaccion(string tipo_tx)
        {
            var sql = $"SELECT id_tipo FROM Tipo_Transacciones WHERE descripcion_movimiento='{tipo_tx}'";
            var id = (int)Convert.ToInt64(DBHelper.GetDBHelper().ConsultaSQL(sql).Rows[0][0].ToString());
            return id;
        }

        public float obtenerComisiones(int id)
        {
            var sql = $"SELECT comision FROM Tipo_Transacciones WHERE tipo_id={id}";
            var comision = (float)Convert.ToDouble(DBHelper.GetDBHelper().ConsultaSQL(sql).Rows[0][0].ToString());
            return comision;
        }

        public float obtenerMontoMax(int id)
        {
            var sql = $"SELECT monto_max FROM Tipo_Transacciones WHERE tipo_id={id}";
            var monto_max = (float)Convert.ToDouble(DBHelper.GetDBHelper().ConsultaSQL(sql).Rows[0][0].ToString());
            return monto_max;
        }

        public float obtenerMontoMin(int id)
        {
            var sql = $"SELECT monto_min FROM Tipo_Transacciones WHERE tipo_id={id}";
            var monto_min = (float)Convert.ToDouble(DBHelper.GetDBHelper().ConsultaSQL(sql).Rows[0][0].ToString());
            return monto_min;
        }
    }
}
