using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReview
{
    public class AsyncProgramming
    {
        // Crea un metodo asincrono PrepararCafe(int segundos) que imprima en consola “Café
        // listo!” al pasar los segundos indicados.
        static public async Task<int> PrepararCafe(int segundos)
        {
            int milisegundos = segundos * 1000;
            await Task.Run(() => Thread.Sleep(milisegundos));
            //Thread.Sleep(milisegundos);
            Console.WriteLine("Café listo!");

            return 1;
        }

        // Crea un metodo asincrono Contar(int segundos) que imprima en consola los segundos
        // que transcurrent hasta llegar a los segundos indicados.

        static public async Task<int> Contar(int segundos)
        {
            int segundosActuales = 0;

            while(segundosActuales <= segundos)
            {
                // Espera un segundo
                await Task.Run(() => Thread.Sleep(1000));
                // Actualiza el "contador" del tiempo
                segundosActuales++;
                // Imprime que pasó un segundo
                Console.WriteLine($"Acaban de pasar {segundosActuales} segundos");

            }

            return 1;
        }
    }
}
