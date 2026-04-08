using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WayBankClient.model;

namespace WayBankClient.service
{
    internal interface IServicePeticiones
    {

        bool CrearCuenta(CuentaAhorrosDto cuenta);
        List<CuentaAhorrosDto> ListarCuentas();
        List<CuentaAhorrosDto> ListarCuentasPorEstado(string estado);
        List<CuentaAhorrosDto> BuscarPorTitular(string nombreTitular);
        CuentaAhorrosDto BuscarPorId(int id);
        bool EliminarLogico(int id);
        bool ActualizarCuenta(string numeroCuenta, CuentaAhorrosDto cuentaEditada);
    }
}
