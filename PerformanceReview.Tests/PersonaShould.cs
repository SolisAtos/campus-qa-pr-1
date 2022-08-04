namespace PerformanceReview.Tests
{
    public class PersonaShould
    {
        [Fact]
        public void VerifyConvertPersonListToEmailListFact()
        {
            // Arrange
            List<Persona> personaList = new List<Persona>(){
                new Persona("Jose", "jose@email.com", new DateTime(2000, 9, 4)),
                new Persona("Maria", "maria@email.com", new DateTime(1987, 11, 29)),
                new Persona("Alberto", "alberto@email.com", new DateTime(2007, 2, 13)),
                new Persona("Ennio", "ennio@email.com", new DateTime(1996, 1, 3)),
                new Persona("Dafne", "dafne@email.com", new DateTime(2000, 8, 27)),
                new Persona("Luis", "luis@email.com", new DateTime(1999, 4, 15))
            }; ;
            List<String> actualEmailList = new List<string>();
            List<String> expectedEmailList = new List<string>()
            {
                "jose@email.com",
                "maria@email.com",
                "alberto@email.com",
                "ennio@email.com",
                "dafne@email.com",
                "luis@email.com"
            };

            // Act
            actualEmailList = Persona.ConvertPersonListToEmailList(personaList);

            // Assert
            Assert.Equal(expectedEmailList, actualEmailList);
        }

        [Fact]
        public void VerifyFilterByBirthdayAndReturnTheFirstInTheListFact()
        {
            // Arrange
            List<Persona> personaList = new List<Persona>(){
                new Persona("Jose", "jose@email.com", new DateTime(2000, 9, 4)),
                new Persona("Maria", "maria@email.com", new DateTime(1987, 11, 29)),
                new Persona("Alberto", "alberto@email.com", new DateTime(2007, 2, 13)),
                new Persona("Ennio", "ennio@email.com", new DateTime(1996, 1, 3)),
                new Persona("Dafne", "dafne@email.com", new DateTime(2000, 8, 27)),
                new Persona("Luis", "luis@email.com", new DateTime(1999, 4, 15))
            }; ;
            DateTime filterDate = new DateTime(2000, 10, 1);
            Persona expectedPersona = new Persona("Alberto", "alberto@email.com", new DateTime(2007, 2, 13));
            Persona actualPersona;

            // Act
            actualPersona = Persona.FilterByBirthdayAndReturnTheFirstInTheList(personaList, filterDate);

            // Assert
            Assert.Equal(expectedPersona.Name, actualPersona.Name);
        }

        [Theory]
        [ClassData(typeof(PersonToEmailTestData))]
        public void VerifyConvertPersonListToEmailListTheory(List<Persona> personaList, List<string> expectedEmailList)
        {
            // Arrange
            List<String> actualEmailList = new List<string>();

            // Act
            actualEmailList = Persona.ConvertPersonListToEmailList(personaList);

            // Assert
            Assert.Equal(expectedEmailList, actualEmailList);
        }

        [Theory]
        [ClassData(typeof(FilterByBirthdayTestData))]
        public void VerifyFilterByBirthdayAndReturnTheFirstInTheListTheory(List<Persona> personaList, DateTime filterDate, string expectedName)
        {
            // Arrange
            Persona actualPersona;

            // Act
            actualPersona = Persona.FilterByBirthdayAndReturnTheFirstInTheList(personaList, filterDate);

            // Assert
            Assert.Equal(expectedName, actualPersona.Name);
        }
    }
}