using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReview.Tests
{
    public class PersonToEmailTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            List<Persona> personaList1 = new List<Persona>(){
                new Persona("Jose", "jose@email.com", new DateTime(2000, 9, 4)),
                new Persona("Maria", "maria@email.com", new DateTime(1987, 11, 29))
            }; ;
            List<Persona> personaList2 = new List<Persona>(){
                new Persona("Alberto", "alberto@email.com", new DateTime(2007, 2, 13)),
                new Persona("Ennio", "ennio@email.com", new DateTime(1996, 1, 3))
            }; ;
            List<Persona> personaList3 = new List<Persona>(){
                new Persona("Dafne", "dafne@email.com", new DateTime(2000, 8, 27)),
                new Persona("Luis", "luis@email.com", new DateTime(1999, 4, 15))
            }; ;

            List<String> expectedEmailList1 = new List<string>()
            {
                "jose@email.com",
                "maria@email.com"
            };
            List<String> expectedEmailList2 = new List<string>()
            {
                "alberto@email.com",
                "ennio@email.com"
            };
            List<String> expectedEmailList3 = new List<string>()
            {
                "dafne@email.com",
                "luis@email.com"
            };

            yield return new object[] { personaList1, expectedEmailList1 };
            yield return new object[] { personaList2, expectedEmailList2 };
            yield return new object[] { personaList3, expectedEmailList3 };

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
