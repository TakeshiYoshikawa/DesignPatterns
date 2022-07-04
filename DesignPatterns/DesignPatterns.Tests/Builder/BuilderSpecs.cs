using Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DesignPatterns.Tests.Builder
{
    public class BuilderSpecs
    {
        [Fact]
        public void Generate_base_name()
        {
            NameGenerator ng = new NameGeneratorBuilder()
                .CreatePerson()
                .Generate();

            string output = ng.GenerateName("Takeshi");
            
            Assert.Equal("Takeshi", output);
        }

        [Fact]
        public void Generate_master_name()
        {
            NameGenerator ng = new NameGeneratorBuilder()
                .CreateMaster()
                .Generate();

            string output = ng.GenerateName("Takeshi");

            Assert.Equal("Master Takeshi", output);
        }

        [Fact]
        public void Generate_doctor_name()
        {
            NameGenerator ng = new NameGeneratorBuilder()
                .CreateDoctor()
                .Generate();

            string output = ng.GenerateName("Takeshi");

            Assert.Equal("Doctor Takeshi", output);
        }

        [Fact]
        public void Generate_your_highness_name()
        {
            NameGenerator ng = new NameGeneratorBuilder()
                .CreatePerson()
                .CreateHighness()
                .Generate();

            string output = ng.GenerateName("Takeshi");

            Assert.Equal("Highness Takeshi", output);
        }

        [Fact]
        public void Generate_your_magnificent_name()
        {
            NameGenerator ng = new NameGeneratorBuilder()
                .CreatePerson()
                .CreateMagnificent()
                .Generate();

            string output = ng.GenerateName("Takeshi");

            Assert.Equal("Magnificent Takeshi", output);
        }

        [Fact]
        public void Generate_your_highness_magnificent_name()
        {
            NameGenerator ng = new NameGeneratorBuilder()
                .CreatePerson()
                .CreateHighness()
                .CreateMagnificent()
                .Generate();

            string output = ng.GenerateName("Takeshi");

            Assert.Equal("Highness Magnificent Takeshi", output);
        }
    }
}
