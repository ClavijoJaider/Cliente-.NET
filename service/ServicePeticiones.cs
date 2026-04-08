using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WayBankClient.model;

namespace WayBankClient.service
{
    public class ServicePeticiones : IServicePeticiones
    {
        public bool EliminarLogico(int id)
        {
            var options = new RestClientOptions("http://localhost:8080/cuentas");
            var client = new RestClient(options);
            var request = new RestRequest($"/{id}", Method.Delete);
            var response = client.Delete(request);
            return response.IsSuccessful;
        }

        bool IServicePeticiones.ActualizarCuenta(string numeroCuenta, CuentaAhorrosDto cuentaEditada)
        {
            var options = new RestClientOptions("http://localhost:8080/cuentas");
            var client = new RestClient(options);
            var request = new RestRequest($"/{numeroCuenta}", Method.Put);
            request.AddJsonBody(cuentaEditada);
            var response = client.Put(request);
            return response.IsSuccessful;
        }

        CuentaAhorrosDto IServicePeticiones.BuscarPorId(int id)
        {
            var options = new RestClientOptions("http://localhost:8080/cuentas");
            var client = new RestClient(options);
            var request = new RestRequest($"/{id}", Method.Get);
            var response = client.Get<CuentaAhorrosDto>(request);
            return response;
        }

        List<CuentaAhorrosDto> IServicePeticiones.BuscarPorTitular(string nombreTitular)
        {
            var options = new RestClientOptions("http://localhost:8080/cuentas");
            var client = new RestClient(options);
            var request = new RestRequest("/buscar", Method.Get);
            request.AddQueryParameter("titular", nombreTitular);
            var response = client.Get<List<CuentaAhorrosDto>>(request);
            return response ?? new List<CuentaAhorrosDto>();
        }

        bool IServicePeticiones.CrearCuenta(CuentaAhorrosDto cuenta)
        {
            var options = new RestClientOptions("http://localhost:8080/cuentas");
            var client = new RestClient(options);
            var request = new RestRequest("/", Method.Post);
            request.AddJsonBody(cuenta);
            var response = client.Post(request);
            return response.IsSuccessful;
        }

        List<CuentaAhorrosDto> IServicePeticiones.ListarCuentas()
        {
            var options = new RestClientOptions("http://localhost:8080/cuentas");
            var client = new RestClient(options);
            var request = new RestRequest("/", Method.Get);
            var response = client.Get<List<CuentaAhorrosDto>>(request);
            return response ?? new List<CuentaAhorrosDto>();
        }

        List<CuentaAhorrosDto> IServicePeticiones.ListarCuentasPorEstado(string estado)
        {
            var options = new RestClientOptions("http://localhost:8080/cuentas");
            var client = new RestClient(options);
            var request = new RestRequest("/filtrar", Method.Get);
            request.AddQueryParameter("estado", estado); // Usa QueryParam como indica tu Java
            var response = client.Get<List<CuentaAhorrosDto>>(request);
            return response ?? new List<CuentaAhorrosDto>();
        }

        public void Healtcheck()
        {
            var options = new RestClientOptions("http://localhost:8080/cuentas");
            var client = new RestClient(options);
            var request = new RestRequest("/healthcheck", Method.Get);
            var response = client.Get(request);
            if (response.IsSuccessful)
            {
                MessageBox.Show(response.Content, "Estado del Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo conectar con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
