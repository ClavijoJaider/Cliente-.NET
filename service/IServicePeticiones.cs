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
        CuentaAhorrosDto BuscarPorNumeroCuenta(int numeroCuenta);
        bool EliminarLogico(int numeroCuenta);
        bool ActualizarCuenta(int numeroCuenta, CuentaAhorrosDto cuentaEditada);
        void Healthcheck();
    }
}