using Portfolio.Domain.Interfaces;
using Portfolio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Test.Tests
{
    public class ExperienceTest
    {
        [Fact]
        public void GetExperiences_RetornaListaExperiencia()
        {
            Experience experience = new Experience();
            var result = experience.GetExperiences(File.ReadAllText(@"C:\Users\bruno\source\repos\Portfolio\Portfolio\Infrastructure\Repositories\experience.json"));
            Assert.NotEmpty(result);
        }

        [Fact]
        public void GetExperience_RetornaNull()
        {
            Experience experience = new Experience();
            var result = experience.GetExperiences("");
            Assert.Null(result);
        }
    }
}
