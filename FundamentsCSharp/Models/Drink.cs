namespace FundamentsCSharp.Models
{
    // Si no se indica modificador, la clase es "internal" (visible solo dentro del proyecto/ensamblado)
    class Drink
    {
        // =====================================================
        // PROPIEDADES
        // =====================================================

        // Public → accesible desde cualquier parte del código (dentro y fuera del ensamblado)
        public string Name { get; set; }

        // Public → accesible desde cualquier lugar
        public int Quantity { get; set; }


        // =====================================================
        // CONSTRUCTOR
        // =====================================================

        // Se ejecuta al crear un objeto Drink
        // "this" diferencia entre el campo de la clase y el parámetro del constructor
        public Drink(string Name, int Quantity)
        {
            this.Name = Name;
            this.Quantity = Quantity;
        }


        // =====================================================
        // MÉTODOS
        // =====================================================

        // Public → puede ser llamado desde cualquier lugar
        // Este método reduce la cantidad de bebida según el parámetro recibido
        public void ToDrink(int HowMuchDrinks)
        {
            this.Quantity -= HowMuchDrinks;
        }
    }
}
