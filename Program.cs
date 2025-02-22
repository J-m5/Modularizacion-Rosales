using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n MENÚ DE EJERCICIOS ");
            Console.WriteLine("1. Calculadora basica");
            Console.WriteLine("2. Validacion de Contraseña");
            Console.WriteLine("3. Números primos");
            Console.WriteLine("4. Suma de numeros pares");
            Console.WriteLine("5. Conversion de temperatura");
            Console.WriteLine("6. Contador de vocales");
            Console.WriteLine("7. Calculo de factorial");
            Console.WriteLine("8. Juego de adivinaza");
            Console.WriteLine("9. Paso por referencia");
            Console.WriteLine("10. Tabla de multiplicar");
            Console.WriteLine("11. Salir");
            Console.Write("Selecciona una opción: ");

            string opcion = Console.ReadLine();
            Console.Clear();

            switch (opcion)
            {
                case "1": Calculadorabasica(); break;
                case "2": ValidaciondeContraseña(); break;
                case "3": NumerosPrimo(); break;
                case "4": SumadenumerosPares(); break;
                case "5": ConversiondeTemperatura(); break;
                case "6": ContadordeVocales(); break;
                case "7": CalculodeFactorial(); break;
                case "8": Juegodeadivinanza(); break;
                case "9": Pasoporreferencia(); break;
                case "10": TabladeMultiplicar(); break;
                case "11": return;
                default: Console.WriteLine("Opción no válida. Intenta de nuevo."); break;
            }
        }
    }

    static void Calculadorabasica()
    {
        Console.Write("Ingresa el primer número: ");
        if (!double.TryParse(Console.ReadLine(), out double num1)) return;
        Console.Write("Ingresa el segundo número: ");
        if (!double.TryParse(Console.ReadLine(), out double num2)) return;

        Console.WriteLine("Elige una operación: (suma, resta, multiplicacion, division)");
        string operacion = Console.ReadLine();

        double resultado = operacion switch
        {
            "suma" => num1 + num2,
            "resta" => num1 - num2,
            "multiplicacion" => num1 * num2,
            "division" => num2 != 0 ? num1 / num2 : double.NaN,
            _ => double.NaN
        };

        Console.WriteLine($"Resultado: {resultado}");
    }

    static void ValidaciondeContraseña()
    {
        string contraseña;
        do
        {
            Console.Write("Ingresa la contraseña: ");
            contraseña = Console.ReadLine();
        } while (contraseña != "1234");

        Console.WriteLine("Acceso concedido.");
    }

    static void NumerosPrimo()
    {
        Console.Write("Ingresa un número: ");
        if (!int.TryParse(Console.ReadLine(), out int num)) return;

        bool esPrimo = EsPrimo(num);
        Console.WriteLine(esPrimo ? "Es primo" : "No es primo");
    }

    static bool EsPrimo(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
            if (num % i == 0) return false;
        return true;
    }

    static void SumadenumerosPares()
    {
        int suma = 0, num;
        do
        {
            Console.Write("Ingresa un número (0 para salir): ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) suma += num;
        } while (num != 0);

        Console.WriteLine($"Suma de pares: {suma}");
    }

    static void ConversiondeTemperatura()
    {
        Console.Write("1. Celsius a Fahrenheit\n2. Fahrenheit a Celsius\nOpción: ");
        string opcion = Console.ReadLine();

        Console.Write("Ingresa la temperatura: ");
        if (!double.TryParse(Console.ReadLine(), out double temp)) return;

        double resultado = opcion == "1" ? (temp * 9 / 5) + 32 : (temp - 32) * 5 / 9;
        Console.WriteLine($"Resultado: {resultado}");
    }

    static void ContadordeVocales()
    {
        Console.Write("Ingresa una frase: ");
        string frase = Console.ReadLine().ToLower();
        int contador = 0;

        foreach (char c in frase)
            if ("aeiou".Contains(c)) contador++;

        Console.WriteLine($"Cantidad de vocales: {contador}");
    }

    static void CalculodeFactorial()
    {
        Console.Write("Ingresa un número: ");
        if (!int.TryParse(Console.ReadLine(), out int num)) return;

        long factorial = 1;
        for (int i = 2; i <= num; i++) factorial *= i;

        Console.WriteLine($"Factorial: {factorial}");
    }

    static void Juegodeadivinanza()
    {
        Random rand = new Random();
        int numeroSecreto = rand.Next(1, 101), intento;

        do
        {
            Console.Write("Adivina el número (1-100): ");
            intento = int.Parse(Console.ReadLine());

            if (intento < numeroSecreto) Console.WriteLine("Demasiado bajo.");
            else if (intento > numeroSecreto) Console.WriteLine("Demasiado alto.");

        } while (intento != numeroSecreto);

        Console.WriteLine("¡Correcto!");
    }

    static void Pasoporreferencia()
    {
        Console.Write("Ingresa el primer número: ");
        if (!int.TryParse(Console.ReadLine(), out int a)) return;
        Console.Write("Ingresa el segundo número: ");
        if (!int.TryParse(Console.ReadLine(), out int b)) return;

        Intercambiar(ref a, ref b);
        Console.WriteLine($"Valores intercambiados: {a}, {b}");
    }

    static void Intercambiar(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    static void TabladeMultiplicar()
    {
        Console.Write("Ingresa un número: ");
        if (!int.TryParse(Console.ReadLine(), out int num)) return;

        MostrarTabla(num);
    }

    static void MostrarTabla(int num)
    {
        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{num} x {i} = {num * i}");
    }
}
