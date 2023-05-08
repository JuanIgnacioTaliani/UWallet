using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWallet.Repositorio
{
    public class ReportesRepositorio
    {
        public DataTable ObtenerClientesPorPais()
        {
            var sql = "SELECT count(nro_cliente) AS 'Clientes', p.nombre AS 'Pais' FROM Clientes c JOIN Ciudades t ON c.id_ciudad = t.id_ciudad JOIN Paises p ON t.cod_pais = p.id_pais GROUP BY p.nombre";
            var datatable = DBHelper.GetDBHelper().ConsultaSQL(sql);
            return datatable;
        }
        public DataTable ObtenerCriptosMasTransaccionadas()
        {
            var sql = "SELECT count(id_transaccion) AS 'Cantidad', abreviacion_cripto AS 'Abreviacion' FROM Transacciones t JOIN Criptomonedas c ON t.id_cripto = c.id_cripto GROUP BY abreviacion_cripto";
            var datatable = DBHelper.GetDBHelper().ConsultaSQL(sql);
            return datatable;
        }
        public DataTable ObtenerComisiones()
        {
            var sql = "SELECT SUM(monto_comision) AS 'Comision', fecha_hora_transaccion AS 'Fecha' FROM Transacciones GROUP BY fecha_hora_transaccion";
            var datatable = DBHelper.GetDBHelper().ConsultaSQL(sql);
            return datatable;
        }

    }
}
