using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppBoteco
{
	internal class BuscaCep
	{
	
		private readonly HttpClient _httpClient;
		private const string BaseUrl = "https://viacep.com.br/ws/";

		public BuscaCep()
		{
			_httpClient = new HttpClient
			{
				BaseAddress = new Uri(BaseUrl)
			};
		}

		public async Task<Endereco> BuscarEnderecoPorCepAsync(string cep)
		{
			try
			{
				var response = await _httpClient.GetAsync($"{cep}/json/");

				if (response.IsSuccessStatusCode)
				{
					var content = await response.Content.ReadAsStringAsync();
					var endereco = JsonConvert.DeserializeObject<Endereco>(content);
					return endereco;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Erro ao buscar o endereço: {ex.Message}");
			}

			return null;
		}
	}

	public class Endereco
	{
		public string Cep { get; set; }
		public string Logradouro { get; set; }
		public string Bairro { get; set; }
		public string Localidade { get; set; }
		public string Uf { get; set; }
	}

}
