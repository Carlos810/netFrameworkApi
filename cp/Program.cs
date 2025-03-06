using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace cp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            string codigoPostal = "16090"; // Código postal de 5 dígitos

            if (EsCodigoPostalValido(codigoPostal))
            {
                 EnviarCodigoPostal(Convert.ToInt32(codigoPostal)).Wait();
            }
            else
            {
                Console.WriteLine("Código postal inválido.");
            }
            */

            string url = "https://api.exchangerate.host/convert?from=USD&to=MXN&amount=1&format=xml";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string xmlData = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(xmlData);
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }

        }

        static bool EsCodigoPostalValido(string codigo)
        {
            return codigo.Length == 5 && int.TryParse(codigo, out _);
        }

        static async Task EnviarCodigoPostal(int codigo)
        {
            string url = "https://thona-api-desarrollo.azurewebsites.net/api/CatalogoCP"; // Reemplaza con la URL de tu API
                                                                                          //https://thona-api-desarrollo.azurewebsites.net/api/CatalogoCP?CP={CP}
            string xmlData = $"<Solicitud><CodigoPostal>{codigo}</CodigoPostal></Solicitud>";

            using (HttpClient client = new HttpClient())
            {
                var contenido = new StringContent(xmlData, Encoding.UTF8, "application/xml");

                HttpResponseMessage respuesta = await client.PostAsync(url, contenido);

                if (respuesta.IsSuccessStatusCode)
                {
                    Console.WriteLine("Código postal enviado con éxito.");
                }
                else
                {
                    Console.WriteLine($"Error al enviar: {respuesta.StatusCode}");
                }
            }
        }

    }

    
}
