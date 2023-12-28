
//!ALUMNO RAFAEL VALERIO GRADO DAW 1 CURSO


//? ejercicio 1) Codifica un programa que demani 6 números a l’usuari i després els imprimeixi de
//? manera inversa.



// internal class Program
// {
//     private static void Main(string[] args)
//     {
       
//         Console.WriteLine("ingresa 6 numeros:");

//         int[] numeros = new int[6];

//         for (int i = 0; i < 6; i++)
//         {
//             Console.Write($"numero [{i}]: ");
//             numeros[i] = Convert.ToInt32(Console.ReadLine());
//         }

//         Console.WriteLine("\nnumeros inversos:");

//         for (int i = 5; i >= 0; i--)
//         {
//             Console.WriteLine(numeros[i]);
//         }
//     }
// }
  

//? ejercicio 2)Codifica un programa que prepari espai per desar un màxim de 100 noms. L'usuari
//? haurà d'anar introduint un nom cada cop, fins que es teclegi stop, moment en què
//? deixaran de demanar-se més noms i es mostrarà a la pantalla la llista dels noms que
//? s'han introduït.



//   internal class Program
// {
//     private static void Main(string[] args)
//     {

//        string[] nombres = new string[100];
       
//         for(int i=0; i< nombres.Length;i++){
//          Console.WriteLine("escribe un nombre o stop para terminar");
//          string nombre = Console.ReadLine();
         
//             if(nombre == "stop")
//             {
//                 break;
//             }
//          nombres[i] = nombre;

//         }
//         Console.WriteLine("\nNombres introducidos:");
//         for(int i = 0; i < nombres.Length; i++) {
  
//             if(!string.IsNullOrEmpty(nombres[i])) {
//             Console.WriteLine(nombres[i]);
//             }

//         }

       
//     }
// }



//? Ejercicio 3)Codifica un programa que emmagatzemi en una taula el nombre de dies que té cada
//? mes, demaneu a l'usuari que us indiqui un mes (1=gener, 12=desembre) i mostri a la
//? pantalla el nombre de dies que té aquest mes.

//  internal class Program
// {
//     private static void Main(string[] args)

//  {
//     string[] meses = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

//     int[] diasMes = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
    
//     Console.Write("Introduce un mes (1-12): ");
//     int mes = int.Parse(Console.ReadLine());
    
//     Console.WriteLine("El mes de " + meses[mes-1] + " tiene " + diasMes[mes-1] + " días.");
//   }
// }




//? Ejercicio 4)Codifica un programa que permita al usuario ingresar 7 valores decimales y luego
//? muestre esos valores ordenados de mayor a menor.


//  internal class Program
// {
//     private static void Main(string[] args)

//  {

//     decimal[] valores = new decimal[7];

//     for (int i = 0; i < 7; i++) {
//       Console.Write("Ingresa un valor decimal #{0}: ", i+1);
//       valores[i] = decimal.Parse(Console.ReadLine());
//     }

//     Array.Sort(valores);
//     Array.Reverse(valores);

//     Console.WriteLine("\nValores ordenados de mayor a menor:");

//     foreach (decimal valor in valores) {
//       Console.WriteLine(valor);
//     }

//   }


// }


//? Ejercicio 5)Codifica un programa que solicite al usuario el ingreso de 10 números y determine
//? cuántos de ellos son pares.


//  internal class Program
// {
//     private static void Main(string[] args)

//   {
//      int cantidadPares = 0;

//     for (int i = 1; i <= 10; i++) {
//       Console.Write("Ingresa un número: ");
//       int numero = int.Parse(Console.ReadLine());

//       if (numero % 2 == 0) {
//         cantidadPares++; 
//       }
//     }

//     Console.WriteLine("Cantidad de números pares: " + cantidadPares);

//   }

// }