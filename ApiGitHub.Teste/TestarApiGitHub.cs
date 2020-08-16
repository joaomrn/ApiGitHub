using ApiGitHub.Controllers;
using ApiGitHub.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;

namespace ApiGitHub.Teste
{
    [TestClass]
    public class TestarApiGitHub
    {
        [TestMethod]
        public void TestarGitHub()
        {
            int sucesso = 0;
            try
            {
                var controller = new GitHubController();
                var retorno = controller.Get("joaomrn");
                //var client = new RestClient("https://api.github.com/users/");
                //var request = new RestRequest("joaomrn");
                //var response = client.Get(request);
                //var content = response.Content;
                //var retorno = JsonConvert.DeserializeObject<IEnumerable<MyArray>>(content);

                sucesso = 1;
            }
            catch (Exception)
            {
                sucesso = 0;
            }

            Assert.AreEqual(sucesso, 1);
        }
    }
}
