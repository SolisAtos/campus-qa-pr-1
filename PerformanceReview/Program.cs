namespace PerformanceReview
{
    class Program
    {
        
        static async Task Main(string[] args)
        {
            //
            // LINQ section
            //

            // e inicializa una lista con 6 personas
            List<Persona> personaList = new List<Persona>() {
                new Persona("Jose", "jose@email.com", new DateTime(2000, 9, 4)),
                new Persona("Maria", "maria@email.com", new DateTime(1987, 11, 29)),
                new Persona("Alberto", "alberto@email.com", new DateTime(2007, 2, 13)),
                new Persona("Ennio", "ennio@email.com", new DateTime(1996, 1, 3)),
                new Persona("Dafne", "dafne@email.com", new DateTime(2000, 8, 27)),
                new Persona("Luis", "luis@email.com", new DateTime(1999, 4, 15))
            };

            // Llama la funcion que convierte la lista de personas a una lista de únicamente Emails
            List<string> emailList = Persona.ConvertPersonListToEmailList(personaList);
            foreach(string email in emailList)
            {
                Console.WriteLine(email);
            }

            // Llama la funcion que convierte la lista de personas a una lista de únicamente Emails
            DateTime filterDate = new DateTime(2000, 5, 6);
            Persona datePerson = Persona.FilterByBirthdayAndReturnTheFirstInTheList(personaList, filterDate);
            Console.WriteLine($"\nThe person named {datePerson.Name} born {datePerson.Birthday} was the first in the filtered list");


            //
            // Async programming section
            //

            Task.WaitAll(
                AsyncProgramming.PrepararCafe(5),
                AsyncProgramming.Contar(8)
                );

        }
    }
}