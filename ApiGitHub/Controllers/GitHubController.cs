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
        [HttpGet]
        public IActionResult Get()
        
        {
            var client = new RestClient("https://api.github.com/users/");
            var request = new RestRequest("joaomrn/repos");
            //request.AddParameter("valor", valor);
            //request.RequestFormat = DataFormat.Json;
            var response = client.Get(request);
            var content = response.Content;
            var retorno = JsonConvert.DeserializeObject<IEnumerable<MyArray>>(content);

            var listaRepositorios = retorno.
                OrderBy(x => x.created_at)//Ordena pela lista data mais antiga
                .ToList()//Converte em um List
                .GetRange(0, 5);//Retorna os 5 primeiros elementos

            return new ObjectResult(listaRepositorios);
        }
    }
}