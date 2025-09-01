namespace FundamentsCSharp.Models
{
    // internal → accesible solo dentro del mismo ensamblado/proyecto
    // Beer hereda de Drink
    internal class Beer : Drink
    {
        // =====================================================
        // CONSTRUCTOR CON HERENCIA
        // =====================================================

        // Llama al constructor de la clase base (Drink) usando "base"
        // El parámetro Name tiene un valor por defecto = "Beer"
        public Beer(int Quantity, string Name = "Beer") : base(Name, Quantity)
        {
        }
    }
}
