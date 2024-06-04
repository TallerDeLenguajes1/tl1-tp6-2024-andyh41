// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
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

}
