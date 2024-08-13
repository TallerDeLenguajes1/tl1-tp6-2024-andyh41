// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("Valor de a:"+a);
Console.WriteLine("Valor de b:"+b);

Console.WriteLine("----- Ejercicio 1 -----");
Console.WriteLine("Ingrese el número a invertir:");
int numero;

if(int.TryParse(Console.ReadLine(), out numero )){
    string mensaje = invertirNumero(numero) == 0 ? "El número ingresado es 0" : "El número invertido es: " +invertirNumero(numero);
    Console.WriteLine(mensaje);
} else {
    Console.WriteLine("No ingreso un número");
}

static int invertirNumero(int numero)
{
    int invertido = 0;
    if(numero == 0) return 0;
    while (numero != 0)
    {
        int ultimo = numero % 10;
        invertido = invertido * 10 + ultimo;
        numero = numero / 10;
    }
    return invertido; 

} */

// ejercicio 4

string? Sub_cadena,Buscada;
int longitud, posc, long_sub;
Console.WriteLine("Ingrese texto:");
string Cadena  = Console.ReadLine();
Console.WriteLine("Ingrese segundo texto:");
string Cadena2 = Console.ReadLine();

if (Cadena != null) // Asegura que la cadena no sea nula
    {
        longitud = Cadena.Length;
        Console.WriteLine($"Largo de la cadena 1: {longitud}");
        Console.WriteLine(Cadena+Cadena2);

        Console.WriteLine("Ingresar la posición inicial de la sub cadena:");
        posc = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la longitud de la sub cadena:");
        long_sub = int.Parse(Console.ReadLine());

        // Verifica que los valores estén dentro de los límites de la cadena
        if (posc >= 0 && posc + long_sub <= longitud)
        {
            Sub_cadena = Cadena.Substring(posc, long_sub);
            Console.WriteLine($"La subcadena extraída es: {Sub_cadena}");
        }
        else
        {
            Console.WriteLine("La posición inicial y/o la longitud de la subcadena no son válidas.");
        }

        Console.WriteLine("Recorro la cadena con un foreach:\n");
        foreach(char caracter in Cadena )
        {
            Console.Write(caracter);
        }

        Console.WriteLine("Cadena CORTADA: ");
        foreach( string parte in partes)
        {
            Console.WriteLine(parte);
        }


        int posicion = Cadena.IndexOf(Buscada, StringComparison.OrdinalIgnoreCase);
        if(posicion!= -1)
        {
            Console.WriteLine($"La palabra '{Buscada}' se encuentra\n");
        }
        else 
        {
            Console.WriteLine("La palabra no se encuentra");

        }

        string Min = Cadena.ToLower();
        Console.WriteLine($"Minuscula : {Min}\n");
        string May = Cadena.ToUpper();
        Console.WriteLine($"Mayuscula : {May}\n");

        Console.WriteLine("Ingrese el caracter que separa:\n");
        char separa = Console.ReadLine()[0];
        string[] partes = Cadena.Split(separa);
            

        Console.WriteLine("Ingrese un calculo simple:\n");
        string calculo =  Console.ReadLine();
        char[] signos = {"+","-","/","*"};

        foreach( char signo in signos)
        {
            if (calculo.IndexOf(signo)!= -1)
            {
                string[] operandos = Cadena.Split(signo);
                int a = int.Parse(operandos[0]);
                int b = int.Parse(operandos[1]);
                int result = Operar(signo,a,b);

                Console.WriteLine($"El resultado de la {signo} entre {a} y {b} es : {result}\n");
            }
        }

        using System.Text.RegularExpressions;
        Console.WriteLine("Ingrese un email:\n");
        string email = Console.ReadLine();
        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        bool isValid = Regex.IsMatch(email, pattern);
        Console.WriteLine(isValid); // True si el correo es válido
    }


static int Operar(char signo, int a, int b)
    {
        switch (signo)
        {
            case '+':
                return a + b;
                break;
            case '-':
                return a - b;
                break;
            case '*':
                return a * b;
                break;
            case '/':
                return a / b;
                break;
            default:
                throw new ArgumentException("Operador no válido");
                break;    
        }
    }
