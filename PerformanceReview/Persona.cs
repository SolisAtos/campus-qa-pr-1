using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReview
{
    // Crea una clase “Persona” con las propiedas: Name, Email, Birthday, 
    public class Persona
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        public Persona(string name, string email, DateTime birthday)
        {
            Name = name;
            Email = email;
            Birthday = birthday;
        }

        // Crea una funcion que convierta la lista de personas a una lista de únicamente Emails
        public static List<string> ConvertPersonListToEmailList(List<Persona> personList)
        {
            return personList.Select(x => x.Email).ToList();
        }

        // Crea una funcion que Filtre la lista de personas, a personas con la fecha de nacimiento
        // mayor a “cierta” fecha y retorne al primero de la lista.
        public static Persona FilterByBirthdayAndReturnTheFirstInTheList(List<Persona> personList, DateTime birthdate)
        {
            List<Persona> personasOlderThanDate;
            personasOlderThanDate = personList.Where(x => x.Birthday > birthdate).ToList();
            return personasOlderThanDate.First();
        }
    }
}
