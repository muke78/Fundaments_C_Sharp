namespace Types_of_data_and_var
{
    class Types_of_data_and_var
    {
        public static void Types()
        {
            // =====================================================
            // TIPOS NUMÉRICOS ENTEROS
            // =====================================================

            // byte → entero sin signo (0 a 255), ocupa 1 byte (8 bits)
            byte byteNumber = 255;

            // sbyte → entero con signo (-128 a 127), ocupa 1 byte (8 bits)
            sbyte sbyteNumber = -128;

            // int → entero con signo (-2,147,483,648 a 2,147,483,647), ocupa 4 bytes (32 bits)
            int intNumber = 512;

            // uint → entero sin signo (0 a 4,294,967,295), ocupa 4 bytes (32 bits)
            uint uIntNumber = 12;

            // long → entero con signo (-9,223,372,036,854,775,808 a 9,223,372,036,854,775,807), ocupa 8 bytes (64 bits)
            long longNumber = -4048;

            // ulong → entero sin signo (0 a 18,446,744,073,709,551,615), ocupa 8 bytes (64 bits)
            ulong ulongNumber = 4048;


            // =====================================================
            // TIPOS NUMÉRICOS DE PUNTO FLOTANTE
            // =====================================================

            // float → precisión simple, ocupa 4 bytes (32 bits)
            // Requiere el sufijo 'f'
            float floatNumber = 200.50f;

            // double → precisión doble, ocupa 8 bytes (64 bits)
            // Es el tipo por defecto para literales con decimales
            double doubleNumber = 120.3d;

            // decimal → precisión alta, ocupa 16 bytes (128 bits)
            // Usado principalmente en cálculos financieros
            // Requiere el sufijo 'm'
            decimal decimalNumber = 189.1m;


            // =====================================================
            // TIPOS DE CARACTERES Y CADENAS
            // =====================================================

            // char → almacena un único carácter Unicode (2 bytes)
            char characterChar = 'A';

            // string → almacena una secuencia de caracteres
            string characterString = "Hello world";


            // =====================================================
            // TIPOS ESPECIALES
            // =====================================================

            // DateTime → representa fecha y hora
            DateTime dateTime = DateTime.Now;

            // bool → valores lógicos (true / false)
            bool boolCondition = true;


            // =====================================================
            // VALORES POR DEFECTO Y NULOS
            // =====================================================

            // Cuando se instancia con 'new', los tipos por valor se inicializan a su valor por defecto
            int number = new int(); // valor por defecto = 0
            Console.WriteLine($"Valor por defecto de int: {number}");

            // Los tipos anulables (nullable) permiten asignar 'null' a tipos por valor
            char? letter = null;
            Console.WriteLine($"Valor de char nullable: {letter}");


            // =====================================================
            // TIPOS INFERIDOS Y BASE
            // =====================================================

            // var → el compilador infiere el tipo automáticamente en tiempo de compilación
            var name = "Erick"; // aquí es string

            // object → clase base de todos los tipos en C#
            // Puede almacenar cualquier tipo, incluyendo tipos anónimos
            object person = new { name = "Erick", lastName = "Gonzalez" };
            Console.WriteLine($"Objeto anónimo: {person}");
        }
    }
}
