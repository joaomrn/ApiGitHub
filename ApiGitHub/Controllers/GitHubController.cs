using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiGitHub.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace ApiGitHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GitHubController : ControllerBase
    {
        [HttpGet("{conta}")]
        public IActionResult Get(string conta)
        {
            if (string.IsNullOrEmpty(conta)) return BadRequest();

            var client = new RestClient("https://api.github.com/users/");
            var request = new RestRequest(@$"{conta}/repos");
            var response = client.Get(request);
            var content = response.Content;
            var retorno = JsonConvert.DeserializeObject<IEnumerable<MyArray>>(content);

            var listaRepositorios = retorno.
                OrderBy(x => x.Created_at)//Ordena pela data mais antiga da lista
                .ToList()//Converte em um List
                .GetRange(0, 5);//Retorna os 5 primeiros elementos

            return new ObjectResult(listaRepositorios);
        }
    }
}