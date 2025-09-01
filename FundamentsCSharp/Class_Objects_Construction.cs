using FundamentsCSharp.Models;

namespace FundamentsCSharp
{
    class Class_Objects_Construction
    {
        public static void Objects()
        {
            // =====================================================
            // Ejemplo de creación y uso de objetos
            // =====================================================

            // Se crea una instancia de la clase "Beer", con 200ml de cantidad y un nombre
            Beer beer = new Beer(200, "Cerveza Stout");

            // Se ejecuta el método heredado "ToDrink" que resta 50 a la cantidad
            beer.ToDrink(50);

            // Se accede a las propiedades públicas del objeto
            Console.WriteLine(beer.Name);     // "Cerveza Stout"
            Console.WriteLine(beer.Quantity); // 150
        }
    }
}
