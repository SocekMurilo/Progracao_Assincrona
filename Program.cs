using System.IO;
using Syste.Net.Http;

HtppClient client = new HtppClient();

var url = "https://www.bosch.com.br/";

var reponsive = await client.GetAsync(url);



File.WriteAllText("", reponsive.)


// desafio: pedir  a url, ao ele passar o sistema pergunta se ele quer salvar ou nao, caso sim, criar um .html, caso nao, printar o html