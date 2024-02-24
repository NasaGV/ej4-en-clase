//Enunciado 1
//ejercicio 1

//for (int i = 2, contador = 0; contador < 5; i += 2, contador++)
//{
//Console.WriteLine(i);
//}

//ejercicio 2
//int suma = 0;
//for (int i = 1; i <= 10; i++)
//{
// suma += i;
//}
//Console.WriteLine("La suma de los primeros 10 numeros naturales es: "+suma);

//enunciado 2

//ejercicio 1
//int suma = 0;
//int numero;

//Console.WriteLine("Ingrese numeros enteros positivos y ingrese un numero negativo para finalizar.");

//do
//{
//Console.Write("Ingrese un numero: ");
// numero = Convert.ToInt32(Console.ReadLine());

//if (numero >= 0)
// {
// suma += numero;
// }

//} while (numero >= 0);

//Console.WriteLine("La suma de los numeros ingresados es: " + suma);

//ejercicio 2

//int numero = 1;

//while (true)
//{
// if (numero % 7 == 0 && numero % 11 == 0)
// {
// Console.WriteLine("El primer numero entero divisible entre 7 y 11 es: " + numero);
// break;
// }
// numero++;
//}

//Anunciado 3

//ejercicio 1

//string contraCorrecta = "jutiapa";
//string contraseña;

//do
//{
// Console.Write("Ingrese la contraseña: ");
//contraseña = Console.ReadLine();

// if (contraseña != contraCorrecta)
// {
// Console.WriteLine("Contraseña incorrecta. Vuelve a intentarlo.");
//}

//} while (contraseña != contraCorrecta);

//Console.WriteLine("¡Contraseña correcta!.");

//ejercicio 2

Random random = new Random();
int numeroAleatorio = random.Next(1, 101);
int intentos = 0;
int intentoUsuario;

Console.WriteLine("Adivina el numero correcto");
Console.WriteLine("Se ha generado un numero aleatorio entre 1 y 100 adivina cual es: ");

do
{
    Console.Write("Ingresa un numero: ");
    intentoUsuario = Convert.ToInt32(Console.ReadLine());
    intentos++;

    if (intentoUsuario < numeroAleatorio)
    {
        Console.WriteLine("El número es mayor. ¡Intenta nuevamente!");
    }
    else if (intentoUsuario > numeroAleatorio)
    {
        Console.WriteLine("El número es menor. ¡Intenta nuevamente!");
    }
    else
    {
        Console.WriteLine("¡Felicidades! Has adivinado el número en " + intentos + " intentos.");
    }

} while (intentoUsuario != numeroAleatorio);