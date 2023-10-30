using System.IO;
using System.Net.Http;
using System;
using Microsoft.VisualBasic;

HttpClient client = new HttpClient();

// var url = "https://www.bosch.com.br/";

Console.WriteLine("Digite o Site que deseja baixar");
var url = Console.ReadLine();

var responsive = await client.GetAsync(url);
if (responsive.StatusCode == 0)
    Console.WriteLine("Nao foi encontrado");
else
{
    var html = await responsive.Content.ReadAsStringAsync();
    Console.WriteLine("Deseja baixar: (1 -> sim  2 -> não)");
    var choose = Console.ReadLine();
    if (choose == "1")
    {
       await File.WriteAllTextAsync("Site.html", html);
    }
}


// desafio: pedir  a url, ao ele passar o sistema pergunta se ele quer salvar ou nao, caso sim, criar um .html, caso nao, printar o html