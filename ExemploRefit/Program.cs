using Refit;
using System;
using System.Threading.Tasks;


namespace ExemploRefit
{
	class Program
	{
		static async Task Main(string[] args)
		{
			var cepClient = RestService.For<ICepApiService>("https://viacep.com.br");
			string meuCep = "18803414";
			Console.WriteLine("Consultando dados do Cep:" + meuCep);


			var address = await cepClient.GetAddressAsync(meuCep);


			Console.Write($"\nLogradouro:{address.Logradouro}\nBairro:{address.Bairro}" +
				$"\nEstado:{address.Uf}\nCódigo Ibge:{address.Ibge}");
			Console.ReadKey();
		}
	}
}