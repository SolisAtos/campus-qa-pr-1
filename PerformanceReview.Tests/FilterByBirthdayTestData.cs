using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReview.Tests
{
    public class FilterByBirthdayTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            List<Persona> personaList = new List<Persona>(){
                new Persona("Jose", "jose@email.com", new DateTime(2000, 9, 4)),
                new Persona("Maria", "maria@email.com", new DateTime(1987, 11, 29)),
                new Persona("Alberto", "alberto@email.com", new DateTime(2007, 2, 13)),
                new Persona("Ennio", "ennio@email.com", new DateTime(1996, 1, 3)),
                new Persona("Dafne", "dafne@email.com", new DateTime(2000, 8, 27)),
                new Persona("Luis", "luis@email.com", new DateTime(1999, 4, 15))
            }; ;

            yield return new object[] {personaList, new DateTime(2000,5,1), "Jose" };
            yield return new object[] {personaList, new DateTime(2000, 10, 1), "Alberto" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
