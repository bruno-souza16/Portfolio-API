using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Portfolio.Domain.Entities;
using Portfolio.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Portfolio.Test.Tests
{
    public class AuthTest
    {
        [Fact]
        public void GetAuth_RetornaFalse()
        {
            Auth auth = new Auth();
            var result = auth.GetAuth(string.Empty);
            Assert.Null(result);
        }

        [Fact]
        public void GetAuth_RetornaTrue()
        {
            Auth auth = new Auth()
            {
                Username = "yes",
                Password = "yes"
            };
            string json = JsonConvert.SerializeObject(auth);
            var result = auth.GetAuth(json);
            Assert.NotNull(result);
        }

        [Fact]
        public void ValidateAuth_RetornaFalse()
        {
            var auth = new Auth()
            {
                Username = "Bruno",
                Password = "me15u1@1608"
            };
            string json = JsonConvert.SerializeObject(auth);
            var result = auth.ValidateAuth(json, "", "");
            Assert.False(result);
        }

        [Fact]
        public void ValidateAuth_RetornaTrue()
        {
            var auth = new Auth()
            {
                Username = "Bruno",
                Password = "me15u1@1608"
            };
            string json = JsonConvert.SerializeObject(auth);
            var result = auth.ValidateAuth(json, auth.Username, auth.Password);
            Assert.True(result);
        }
    }
}
