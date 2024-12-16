using Portfolio.Domain.Interfaces;
using Portfolio.Domain.Entities;
using Portfolio.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Portfolio.Test.Tests
{
    public class JsonLoaderTest
    {
        [Fact]
        public void JsonLoaderExperience_RetornaDados()
        {
            JsonLoader jsonLoader = new JsonLoader(new Experience(), new Formation(), new Qualification(), new Person(), new Repositories(), new Auth());
            var result = jsonLoader.LoadExperience();
            Assert.NotEmpty(result);
        }

        [Fact]
        public void JsonLoaderQualification_RetornaDados()
        {
            JsonLoader jsonLoader = new JsonLoader(new Experience(), new Formation(), new Qualification(), new Person(), new Repositories(), new Auth());
            var result = jsonLoader.LoadQualification();
            Assert.NotEmpty(result);
        }

        [Fact]
        public void JsonLoaderFormation_RetornaDados()
        {
            JsonLoader jsonLoader = new JsonLoader(new Experience(), new Formation(), new Qualification(), new Person(), new Repositories(), new Auth());
            var result = jsonLoader.LoadFormation();
            Assert.IsType<Formation>(result);
        }

        [Fact]
        public void JsonLoaderPerson_RetornaDados()
        {
            JsonLoader jsonLoader = new JsonLoader(new Experience(), new Formation(), new Qualification(), new Person(), new Repositories(), new Auth());
            var result = jsonLoader.LoadPerson();
            Assert.IsType<Person>(result);
        }

        [Fact]  
        public void JsonGetLogin_RetornaFalse()
        {
            JsonLoader jsonLoader = new JsonLoader(new Experience(), new Formation(), new Qualification(), new Person(), new Repositories(), new Auth());
            Auth auth = new Auth()
            {
                Username = "yes",
                Password = "yes"
            };
            string json = JsonConvert.SerializeObject(auth);
            var result = jsonLoader.GetLogin(json);
            Assert.False(result);
        }

        [Fact]
        public void JsonGetLogin_RetornaTrue()
        {
            JsonLoader jsonLoader = new JsonLoader(new Experience(), new Formation(), new Qualification(), new Person(), new Repositories(), new Auth());
            Auth auth = new Auth()
            {
                Username = "Bruno",
                Password = "yes"
            };
            string json = JsonConvert.SerializeObject(auth);
            var result = jsonLoader.GetLogin(json);
            Assert.False(result);
        }
    }
}
