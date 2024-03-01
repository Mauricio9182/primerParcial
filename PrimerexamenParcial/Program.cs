//EJERCICIO 1 
int numero;
 bool salir = false;

 // le pedimos al usuario que ingrese un numero entero positivo
 do
 {
     Console.WriteLine("introduzca un numero entero positivo: ");
     numero = int.Parse(Console.ReadLine());
 } while (numero <= 0);

 // Mostrar el menú y obtener la opción del usuario
 while (!salir)
 {
     Console.WriteLine("\nElija una opciin:");
     Console.WriteLine("1. Calcular el factorial del numero");
     Console.WriteLine("2. Calcular la raiz cuadrada del numero");
     Console.WriteLine("3. Salir del programa");

     int opcion = int.Parse(Console.ReadLine());

     switch (opcion)
     {
         case 1:
             // Calcular el factorial del numero
             int factorial = 1;
             for (int i = 1; i <= numero; i++)
             {
                 factorial *= i;
             }
             Console.WriteLine("El factorial de {0} es {1}", numero, factorial);
             break;
         case 2:
             // Calcular la raiz cuadrada del número
             double raizCuadrada = Math.Sqrt(numero);
             Console.WriteLine("La raiz cuadrada de {0} es {1}", numero, raizCuadrada);
             break;
         case 3:
             // Salir del programa
             salir = true;
             break;
         default:
             Console.WriteLine("Opcion no valida. Elija un numero del 1 al 3.");
             break;
     }
 }

 Console.WriteLine("¡Hasta la proxima!");



//EJERCICIO 2
// Le pEdimos dos numeros enteros al usuario
Console.WriteLine("Introduzca el primer numero: ");
 int num1 = int.Parse(Console.ReadLine());

 Console.WriteLine("Introduzca el segundo numero: ");
 int num2 = int.Parse(Console.ReadLine());

 // Pedimos el operador matematico al usuario
 Console.WriteLine("Introduzca el operador matematico (+, -, *, /): ");
 string operador = Console.ReadLine();

 // validamos el operador
 bool operadorValido = ValidarOperador(operador);

 // Si el operador es valido, realizamos la operacion
 if (operadorValido)
 {
     int resultado = 0;

     switch (operador)
     {
         case "+":
             resultado = num1 + num2;
             break;
         case "-":
             resultado = num1 - num2;
             break;
         case "*":
             resultado = num1 * num2;
             break;
         case "/":
             if (num2 == 0)
             {
                 Console.WriteLine("No se puede dividir por 0.");
             }
             else
             {
                 resultado = num1 / num2;
             }
             break;
     }

     // Mostrar el resultado
     if (operador != "/")
     {
         Console.WriteLine("El resultado de {0} {1} {2} es {3}", num1, operador, num2, resultado);
     }
 }
 else
 {
     Console.WriteLine("El operador introducido no es valido.");
 }


static bool ValidarOperador(string operador)
{
bool valido = false;

string[] operadoresValidos = { "+", "-", "*", "/" };

foreach (string op in operadoresValidos)
{
 if (op == operador)
 {
     valido = true;
     break;
 }
}

return valido;
}



//EJERCICIO 3
//le pedimos un numero entero al usuario
Console.WriteLine("Introduzca un numero entero: ");
int num = int.Parse(Console.ReadLine());

// Imprimir la tabla de multiplicar del 1 al 10
Console.WriteLine("Tabla de multiplicar del {0}", num);
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
}




        // Generar un número aleatorio entre 1 y 100
        //EJERCICIO 4
        Random random = new Random();
        int numeroSecreto = random.Next(1, 100);

        // le pedimos al usuario que ingrese un numero
        Console.WriteLine("Introduzca un numero: ");
        int numeroUsuario = int.Parse(Console.ReadLine());

        // Bucle para adivinar el numero secreto
        while (numeroUsuario != numeroSecreto)
        {
            // Indicar al usuario si el numero secreto es mayor o menor que el introducido
            if (numeroUsuario > numeroSecreto)
            {
                Console.WriteLine("El numero secreto es menor que {0}", numeroUsuario);
            }
            else
            {
                Console.WriteLine("El numero secreto es mayor que {0}", numeroUsuario);
            }

            // Pedir un nuevo numero al usuario
            Console.WriteLine("Introduzca otro numero: ");
            numeroUsuario = int.Parse(Console.ReadLine());
        }

        // Mostrar un mensaje de felicitación al usuario
        Console.WriteLine("¡Felicidades! Has adivinado el numero secreto: {0}", numeroSecreto);
