do
{
    int opcion;
    double num1,num2, resultado;
    Console.WriteLine("1-Sumar");
    Console.WriteLine("2-Restar");
    Console.WriteLine("3-Dividir");
    Console.WriteLine("4-Multiplicar");
    Console.WriteLine("5-Valor Absoluto");
    Console.WriteLine("6-cuadrado");
    Console.WriteLine("7-raiz cuadrada");
    Console.WriteLine("8-Seno");
    Console.WriteLine("9-Coseno");
    Console.WriteLine("10-Parte entera");

    Console.WriteLine("Ingrese una Opcion: ");

    int.TryParse(Console.ReadLine(),out opcion);

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese los numeros");
            double.TryParse(Console.ReadLine(),out num1);
            double.TryParse(Console.ReadLine(),out num2);
            resultado= num1 + num2;
            Console.WriteLine("El resultado es : " +resultado);
            break; 
        case 2:
            Console.WriteLine("Ingrese los numeros");
            double.TryParse(Console.ReadLine(),out num1);
            double.TryParse(Console.ReadLine(),out num2);
            resultado= num1 - num2;
            Console.WriteLine("El resultado es : " +resultado);
            break;
        case 3:
            Console.WriteLine("Ingrese los numeros");
            double.TryParse(Console.ReadLine(),out num1);
            double.TryParse(Console.ReadLine(),out num2);
            resultado= num1 / num2;
            Console.WriteLine("El resultado es : " +resultado);
            break;
        case 4:
            Console.WriteLine("Ingrese los numeros");
            double.TryParse(Console.ReadLine(),out num1);
            double.TryParse(Console.ReadLine(),out num2);
            resultado= num1 * num2;
            Console.WriteLine("El resultado es : " +resultado);
            break;

        case 5:
            Console.WriteLine("ingrese un numero: ");
            double.TryParse(Console.ReadLine(),out num1);
            resultado= Math.Abs(num1);
            Console.WriteLine("El resultado es : " +resultado);
            break;
        case 6:
            Console.WriteLine("ingrese un numero: ");
            double.TryParse(Console.ReadLine(),out num1);
            resultado= Math.Pow(num1,2);
            Console.WriteLine("El resultado es : " +resultado);
            break;
        case 7:
            Console.WriteLine("ingrese un numero: ");
            double.TryParse(Console.ReadLine(),out num1);
            resultado= Math.Sqrt(num1);
            Console.WriteLine("El resultado es : " +resultado);
            break;
        case 8:
            Console.WriteLine("ingrese un numero: ");
            double.TryParse(Console.ReadLine(),out num1);
            resultado= Math.Sin(num1);
            Console.WriteLine("El resultado es : " +resultado);
            break;
        case 9:
            Console.WriteLine("ingrese un numero: ");
            double.TryParse(Console.ReadLine(),out num1);
            resultado= Math.Cos(num1);
            Console.WriteLine("El resultado es : " +resultado);
            break;
        case 10:
            Console.WriteLine("ingrese un numero: ");
            double.TryParse(Console.ReadLine(),out num1);
            resultado= Math.Floor(num1);
            Console.WriteLine("La parte entera del numero es : " +resultado);
            break;
    };

    Console.WriteLine("Si desea hacer otro calculo presione 1 sino presione 0: ");
    int.TryParse(Console.ReadLine(),out opcion);

} while (opcion==1);

Console.WriteLine("Ingrese dos numeros: ");
double.TryParse(Console.ReadLine(),out num1);
double.TryParse(Console.ReadLine(),out num2);

if (num1>=num2)
{
    Console.WriteLine("el numero "+num1+" es el mayor y el numero "+num2+" es el menor");
} else
{
    Console.WriteLine("el numero "+num2+" es el mayor y el numero "+num1+" es el menor");
}
