namespace PraticaOfix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personaje personaje = new Personaje
            {
                Nombre = "Pech",
                vida = 5,
                Ataque = 3,
                Defensa = 2,
                Nivel = 2
            };

            Console.WriteLine($"Nombre: {personaje.Nombre}");
            Console.WriteLine($"Vida: {personaje.vida}");
            Console.WriteLine($"Ataque: {personaje.Ataque}");
            Console.WriteLine($"Defensa: {personaje.Defensa}");
            Console.WriteLine($"Nivel: {personaje.Nivel}");
        }
    }
}