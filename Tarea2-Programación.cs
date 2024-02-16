using System;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Conversión de Tipos 
        Console.WriteLine("--------------------------------------------------CONVERSIÓN DE TIPOS--------------------------------------------------");


       
        
        Console.Write("Por favor, Ingresa un número entero: ");
        int entero = int.Parse(Console.ReadLine());
        Console.WriteLine($"De Número entero a decimal: {Convert.ToDecimal(entero)}");

        Console.Write("Por favor, Ingresa un número decimal: ");
        decimal decimalNumber = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"De Número decimal a flotante: {Convert.ToSingle(decimalNumber)}");

        Console.Write("Por favor, Ingresa un número flotante: ");
        float flotante = float.Parse(Console.ReadLine());
        Console.WriteLine($"De Número flotante a entero: {Convert.ToInt32(flotante)}");

        Console.Write("Por favor, Ingresa un carácter: ");
        char caracter = char.Parse(Console.ReadLine());
        Console.WriteLine($"De Carácter a Entero: {(int)caracter}");

        Console.Write("Por favor, Ingresa un número ENTERO que desea convertir a carácter: ");
        int enteroParaCaracter = int.Parse(Console.ReadLine());
        Console.WriteLine($"De Entero a Carácter: {(char)enteroParaCaracter}");



        // 2. Operaciones con tipos de datos

        Console.WriteLine("\n2. ---------------------------------------OPERACIONES CON TIPOS DE DATOS-------------------------------------------------");

        Console.Write("Primer Número Entero: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Segundo Número Entero: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"La Suma de los dos números ingresados es de: {num1 + num2}");

        Console.Write("Porfavor,Ingresa un Número Decimal: ");
        decimal dec1 = decimal.Parse(Console.ReadLine());
        Console.Write("Porfavor, Ingresa otro Número Decimal: ");
        decimal dec2 = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"La Resta de los dos números decimales ingresados es de: {dec1 - dec2}");


        Console.Write("Ingresa un Número Flotante: ");
        float fl1 = float.Parse(Console.ReadLine());
        Console.Write("Porfavor, Ingresa otro Número Flotante: ");
        float fl2 = float.Parse(Console.ReadLine());
        Console.WriteLine($"La Multiplicación de los dos números flotantes ingresados es de: {fl1 * fl2}");

        Console.Write("Porfavor, Ingresa el numerador: ");
        int numerador = int.Parse(Console.ReadLine());
        Console.Write("Porfavor, Ingresa el denominador: ");
        int denominador = int.Parse(Console.ReadLine());
        Console.WriteLine($"La División de los dos números enteros ingresados es de: {(float)numerador / denominador}");


        Console.Write("Porfavor, Ingresa el primer número Entero para Módulo: ");
        int moduloNum1 = int.Parse(Console.ReadLine());
        Console.Write("Porfavor, Ingresa el segundo número Entero para Módulo (diferente de cero): ");
        int moduloNum2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"El Módulo de los dos Números Enteros ingresados es de: {moduloNum1 % moduloNum2}");



        // 3. Uso de String y Char
        

        Console.WriteLine("\n3. --------------------------------------------------USO DE CHAR Y STRING-------------------------------------------------");


        Console.Write("Porfavor, Ingresa una cadena de texto que deseas imprimir en MAYÚSCULAS: ");
        string textoMayusculas = Console.ReadLine().ToUpper();
        Console.WriteLine($"Cadena en MAYÚSCULAS: {textoMayusculas}");

        Console.Write("PORFAVOR, INGRESA UNA CADENA DE TEXTO QUE DESEAS CONVERTIR EN minúsculas: ");
        string textoMinusculas = Console.ReadLine().ToLower();
        Console.WriteLine($"CADENA EN minúsculas: {textoMinusculas}");

        Console.Write("Ingresa una Cadena de Texto, la cual se imprimirá al revés: ");
        string textoReverso = new string(Console.ReadLine().ToCharArray().Reverse().ToArray());
        Console.WriteLine($"Cadena al revés: {textoReverso}");



        Console.Write("Por favor, ingresa una cadena de texto: ");
        string textoBuscar = Console.ReadLine();

        Console.Write("Por favor, ingresa la palabra a buscar en la cadena de texto ingresada anteriormente: ");
        string palabraBuscar = Console.ReadLine();

        bool palabraEncontrada = textoBuscar.Contains(palabraBuscar, StringComparison.OrdinalIgnoreCase);

        Console.WriteLine($"La palabra '{palabraBuscar}' {(palabraEncontrada ? "se encuentra" : "no se encuentra")} en la cadena.");


        Console.Write("Porfavor, Ingresa una cadena de texto: ");
        string textoContarVocales = Console.ReadLine();
        int contadorVocales = 0;
        foreach (char c in textoContarVocales.ToLower())

        {
            if ("aeiou".Contains(c))
                contadorVocales++;
        }
        Console.WriteLine($"El Número de vocales en la cadena: {contadorVocales}");


        // 4. Operaciones Geométricas
        Console.WriteLine("\n4. ----------------------------------------------------OPERACIONES GEOMÉTRICAS-----------------------------------------------");

        while (true)
        {
            Console.WriteLine("Selecciona la operación geométrica:");
            Console.WriteLine("1. Calcular área de un triángulo");
            Console.WriteLine("2. Calcular volumen de una esfera");
            Console.WriteLine("3. Calcular distancia entre dos puntos");
            Console.WriteLine("4. Convertir Celsius a Fahrenheit");
            Console.WriteLine("5. Convertir Fahrenheit a Celsius");
            Console.WriteLine("6. Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CalcularAreaTriangulo();
                    break;
                case 2:
                    CalcularVolumenEsfera();
                    break;
                case 3:
                    CalcularDistanciaEntrePuntos();
                    break;
                case 4:
                    ConvertirCelsiusAFahrenheit();
                    break;
                case 5:
                    ConvertirFahrenheitACelsius();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }

            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }


    // Funciones para operaciones geométricas

    static void CalcularAreaTriangulo()
    {
        Console.WriteLine("Ingresa la base del triángulo:");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa la altura del triángulo:");
        double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

        double areaTriangulo = 0.5 * baseTriangulo * alturaTriangulo;
        Console.WriteLine($"El área del triángulo es: {areaTriangulo}");
    }

    static void CalcularVolumenEsfera()
    {
        Console.WriteLine("Ingresa el radio de la esfera:");
        double radioEsfera = Convert.ToDouble(Console.ReadLine());

        double volumenEsfera = (4.0 / 3.0) * Math.PI * Math.Pow(radioEsfera, 3);
        Console.WriteLine($"El volumen de la esfera es: {volumenEsfera}");
    }

    static void CalcularDistanciaEntrePuntos()
    {
        Console.WriteLine("Ingresa las coordenadas del primer punto (x1 y1):");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa las coordenadas del segundo punto (x2 y2):");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double y2 = Convert.ToDouble(Console.ReadLine());

        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine($"La distancia entre los dos puntos es: {distancia}");
    }

    static void ConvertirCelsiusAFahrenheit()
    {
        Console.WriteLine("Ingresa la temperatura en grados Celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"La temperatura en grados Fahrenheit es: {fahrenheit}");
    }

    static void ConvertirFahrenheitACelsius()
    {
        Console.WriteLine("Ingresa la temperatura en grados Fahrenheit:");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"La temperatura en grados Celsius es: {celsius}");
    }
}
