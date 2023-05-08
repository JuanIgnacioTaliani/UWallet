using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using UWallet.Entidades;
using UWallet.Entidades.Enums;

namespace UWallet.Repositorio
{
    internal class TransaccionesRepositorio
    {

        public void Comprar(Transaccion c)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    // INSERT INTO Transacciones
                    var sqlTx = $"INSERT INTO Transacciones (id_usuario, id_cripto, fecha_hora_transaccion, id_tipo, monto_usd, monto_cripto, precio, monto_comision)" +
                        $"VALUES({c.getMonedero().getUsuario().getIdUsuario()}, {c.getMonedero().getCripto().Id}, '{c.getFechaHoraTransaccion().ToString("yyyy-MM-ddTHH:mm:ss")}', " +
                        $"{c.getTipo().getId()}, {c.getMontoUSD().ToString().Replace(',', '.')}, {c.getMontoCripto().ToString().Replace(',','.')}, {c.getCotizacion().getPrecio()}, {c.getMontoComision().ToString().Replace(',', '.')})";
                    DBHelper.GetDBHelper().EjecutarSQL(sqlTx);

                    // UPDATE saldos de usuario
                    var sqlUpdateSaldoUSDUsuario = $"UPDATE Monederos SET saldo=saldo-{c.getMontoUSD().ToString().Replace(',', '.')} WHERE id_usuario={c.getMonedero().getUsuario().getIdUsuario()} " +
                        $"AND id_cripto={(int)CriptomonedasDisponibles.USD}";
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sqlUpdateSaldoUSDUsuario);
                    var sqlUpdateSaldoCriptoUsuario = $"UPDATE Monederos SET saldo=saldo+{c.getMontoCripto().ToString().Replace(',', '.')} WHERE id_usuario={c.getMonedero().getUsuario().getIdUsuario()} " +
                        $"AND id_cripto={c.getMonedero().getCripto().Id}";
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sqlUpdateSaldoCriptoUsuario);

                    // UPDATE saldos del Broker
                    var sqlUpdateUSDBroker = $"UPDATE Criptomonedas SET cantidad=cantidad+{c.getMontoUSD().ToString().Replace(',', '.')} WHERE id_cripto={(int)CriptomonedasDisponibles.USD}";
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sqlUpdateUSDBroker);
                    var sqlUpdateSaldoCriptoBroker = $"UPDATE Criptomonedas SET cantidad=cantidad-{c.getMontoCripto().ToString().Replace(',', '.')} WHERE id_cripto={c.getMonedero().getCripto().Id}";
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sqlUpdateSaldoCriptoBroker);
                    tx.Commit();
                }
                    catch (Exception ex)
                {
                    tx.Rollback();
                    throw new ApplicationException("No se pudo realizar la compra.");
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }
        }

        public void Ingresar(Transaccion i)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    // INSERT INTO Transacciones
                    var sqlTx = $"INSERT INTO Transacciones (id_usuario, id_cripto, fecha_hora_transaccion, id_tipo, monto_usd, monto_cripto, precio, monto_comision)" +
                        $"VALUES({i.getMonedero().getUsuario().getIdUsuario()}, {(int)CriptomonedasDisponibles.USD}, '{i.getFechaHoraTransaccion().ToString("yyyy-MM-ddTHH:mm:ss")}', " +
                        $"{i.getTipo().getId()}, {i.getMontoUSD().ToString().Replace(',', '.')}, {i.getMontoCripto().ToString().Replace(',', '.')}, {i.getCotizacion().getPrecio()}, {i.getMontoComision().ToString().Replace(',', '.')})";
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sqlTx);

                    // UPDATE saldos de usuario
                    var sqlUpdateSaldoUSDUsuario = $"UPDATE Monederos SET saldo=saldo+{i.getMontoUSD().ToString().Replace(',', '.')} WHERE id_usuario={i.getMonedero().getUsuario().getIdUsuario()} " +
                        $"AND id_cripto={(int)CriptomonedasDisponibles.USD}";
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sqlUpdateSaldoUSDUsuario);
                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new ApplicationException("No se pudo realizar el ingreso.");
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }
        }

        public void Vender(Transaccion v)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    // INSERT INTO Transacciones
                    var sqlTx = $"INSERT INTO Transacciones (id_usuario, id_cripto, fecha_hora_transaccion, id_tipo, monto_usd, monto_cripto, precio, monto_comision)" +
                        $"VALUES({v.getMonedero().getUsuario().getIdUsuario()}, {v.getMonedero().getCripto().Id}, '{v.getFechaHoraTransaccion().ToString("yyyy-MM-ddTHH:mm:ss")}', " +
                        $"{v.getTipo().getId()}, {v.getMontoUSD().ToString().Replace(',', '.')}, {v.getMontoCripto().ToString().Replace(',', '.')}, {v.getCotizacion().getPrecio()}, {v.getMontoComision().ToString().Replace(',', '.')})";
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sqlTx);

                    // UPDATE saldos de usuario
                    var sqlUpdateSaldoUSDUsuario = $"UPDATE Monederos SET saldo=saldo+{v.getMontoUSD().ToString().Replace(',', '.')} WHERE id_usuario={v.getMonedero().getUsuario().getIdUsuario()} " +
                        $"AND id_cripto={(int)CriptomonedasDisponibles.USD}";
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sqlUpdateSaldoUSDUsuario);
                    var sqlUpdateSaldoCriptoUsuario = $"UPDATE Monederos SET saldo=saldo-{v.getMontoCripto().ToString().Replace(',', '.')} WHERE id_usuario={v.getMonedero().getUsuario().getIdUsuario()} " +
                        $"AND id_cripto={v.getMonedero().getCripto().Id}";
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sqlUpdateSaldoCriptoUsuario);

                    // UPDATE saldos del Broker
                    var sqlUpdateSaldoUSDBroker = $"UPDATE Criptomonedas SET cantidad=cantidad-{v.getMontoUSD().ToString().Replace(',', '.')} WHERE id_cripto={(int)CriptomonedasDisponibles.USD}";
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sqlUpdateSaldoUSDBroker);
                    var sqlUpdateSaldoCriptoBroker = $"UPDATE Criptomonedas SET cantidad=cantidad+{v.getMontoCripto().ToString().Replace(',', '.')} WHERE id_cripto={v.getMonedero().getCripto().Id}";
                    DBHelper.GetDBHelper().EjecutarUpdateTransaccionSQL(sqlUpdateSaldoCriptoBroker);

                    tx.Commit();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new ApplicationException("No se pudo realizar la venta");
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }
        }
    }

   
}
