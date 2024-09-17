using Cine.Enums;
using Cine.Modelos;

namespace Cine
{
    class Program
    {
        static void Main()
        {         
            Pelicula peli = new Pelicula("Rey Leon", "Infantil", 90, Formato._3D_Doblada);

            Sala sala = new Sala(1, peli);
            sala.DefinirHorario(16,30);

            Asiento asiento = new Asiento('A', 23, TipoAsiento.Estandar, false);

            Cinema cine = new Cinema("Libertad");

            cine.AgregsarSala(sala);

            Entrada entrada = new Entrada(cine, peli, asiento);
            entrada.AgregarFecha(new DateTime(2024, 9, 10));

            entrada.MostrarDetalles();
            Console.WriteLine($"Horario: {sala.Horario}");
        }
    }
}
