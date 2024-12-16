using Portfolio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Test.Tests
{
    public class QualificationTest
    {
        [Fact]
        public void GetQualifications_RetornaListaQualificacoes()
        {
            Qualification Qualification = new Qualification();
            var result = Qualification.GetQualifications(File.ReadAllText(@"C:\Users\bruno\source\repos\Portfolio\Portfolio\Infrastructure\Repositories\qualifications.json"));
            Assert.NotEmpty(result);
        }

        [Fact]
        public void GetQualification_RetornaNull()
        {
            Qualification Qualification = new Qualification();
            var result = Qualification.GetQualifications("");
            Assert.Null(result);
        }
    }
}
