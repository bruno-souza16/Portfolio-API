using Portfolio.Domain.Interfaces;
using Portfolio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Test.Tests
{
    public class FormationTest
    {
        [Fact]
        public void GetFormation_RetornaDados()
        {
            Formation formation = new Formation();
            formation = formation.GetFormation(File.ReadAllText(@"C:\Users\bruno\source\repos\Portfolio\Portfolio\Infrastructure\Repositories\formation.json"));
            Assert.IsType<Formation>(formation);
        }

        [Fact]
        public void GetExperience_RetornaNull()
        {
            Formation formation = new Formation();
            formation = formation.GetFormation("");
            Assert.Null(formation);
        }
    }
}
