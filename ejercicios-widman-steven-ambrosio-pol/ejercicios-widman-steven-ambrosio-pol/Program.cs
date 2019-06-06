using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_widman_steven_ambrosio_pol
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0, suma = 0, cantidad = 0, sumapar = 0, sumaimpar = 0, nummayor = 0, nummenor = 0, summul = 0, sumnum = 0, n1 = 1, n2 = 0, c = 0, cp = 0, sp = 0, fact = 1, I = 0, N = 30, aux = 0, x = 0;
            string mayores = "", menores = "";
            /* for (int i = 0; i <= 100; i++)
             {
                 Console.WriteLine("los numeros de 0 al 100 son " + i);
             }
             Console.ReadKey();
             {

             }
             // ejercicio # 2 ///////////


              for (int i = 100; i > -1; i--)

              {

                  Console.WriteLine("Los numeros en orden decreciente del 100 al 0 son " + i);

              }
              Console.ReadKey();


            // ejercicio # 3///////////
              for (int i = 0; i <= 100; i++)
               {
                   suma = suma + i;
                  Console.WriteLine("La suma de los 100 numeros enteros son " + suma);
               }

               {
                   Console.ReadKey();
               }

             ////// ejercicio # 4 ////////////////
             for (int i = 1; i <= 100; i++)
              {
                  if (i % 2 == 0)
                  {
                      Console.WriteLine("los numeros pares entre el 0 y el 100 son " + i);
                  }

             } Console.ReadKey();

             //// ejercicio # 5  ////////////
           for (int i=1; i <=100; i++)
             {
                 if (i%2!=0)
                 {
                     Console.WriteLine(i);
                     cantidad = cantidad + 1;
                 }
             }            Console.Write("Numeros Impares encontrados {0}",cantidad);            Console.ReadKey(); 

             // ejrcicio #6 //////

             for (int i = 1; i <= 100; i++)
             {
                 if (i % 2 != 0)
                 {
                     Console.WriteLine("los numeros impares son " + i);
                     {
                         suma = suma + i;
                         Console.WriteLine("la suma de los numeros impares son " + suma);
                     }
                 }

             } Console.ReadKey();

             /// ejercicio # 7 ////////////////

             Console.WriteLine("ingrese el numero limite ");
             num1 = Convert.ToInt16(Console.ReadLine());
             for (int i = 0; i <= num1; i++)
             {
                 Console.WriteLine("los numeros naturales son " + i);

             }Console.ReadLine(); 

             // ejercicio # 8 //////////

             for (int i = 1; i <= 100; i++)
             {
                 if (i % 3 == 0)

             Console.WriteLine("Los Multiplos de 3 son " + i);      

             } Console.ReadKey(); 

             // ejercicio # 9 ////////////

             for (int i = 0; i <= 100; i++)
             {
                 if (i % 2 != 0)
                 {
                     suma = suma + i;
                     Console.WriteLine("la suma de los numeros impares son " + suma);
                 }
             }
             Console.ReadKey();

            // ejercicio # 10

            for (int i = 1; i <= 500; i++)
            {
                if (i % 5 == 0)

                    Console.WriteLine("Los Multiplos de 5 son " + i);

            }
            Console.ReadKey();

            // ejercicio # 11///////////////

            Console.WriteLine("ingrese el numero limite ");
            num1 = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i <= num1; i++)
            {
                if (i % 2 == 0)
                {
                    suma = suma + i;
                    Console.WriteLine("la suma es de los multiplos son " + suma);
                }

            }  Console.ReadKey();

            //ejercicio # 12////////////////////////

            Console.WriteLine("ingrese el numero limite ");
            num1 = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < num1; i++)
            {
                if (i % 10 == 0)
                {
                    suma = suma + i;
                    Console.WriteLine("la suma de los multiplos de 10 son " + suma );
                }

            }  Console.ReadKey();

            // ejercicio # 13 ////////////

             num1 = 0;
            suma = 0;
            cantidad = 0;
            Console.Write("Ingrese un numero menor que 500: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 >=500)
            {
                Console.Write("El numero ingresado es mayor a 500.");
            }
            else
            {
                for (int i =num1; i <=500; i=i+8)
                {
                    Console.WriteLine(i);
                    suma = suma + i;
                    cantidad = cantidad + 1;                                       
                }
            }
            Console.WriteLine("Suma de los numeros en 8 posiciones: {0}", suma);
            Console.WriteLine("cantidad de numeros en 8 posiciones: {0}", cantidad);
            Console.ReadKey();

             /// ejercicio # 14//////////////////////
             for (int i = 0; i <= 100; i++)
             {
                 if (i % 2 == 0)
                 {
                     suma = suma + (i * i);
                 }
             }
             Console.WriteLine("Suma de los cuadrados de numeros pares es: {0}", suma);
             Console.ReadKey();

             /// ejercicio # 15 //////////

             Console.Write("Introduce un numero menor que 100:");
             num1 = Convert.ToInt32(Console.ReadLine());
             if (num1 > 100)
             {
                 Console.Write("No es un numero menor que 100");
             }
             else
             {
                 for (int i = num1; i <= 100; i = i + 4)
                 {
                     suma = suma + (i * i);
                 }
             }
             Console.Write("Suma de los cuadrados de los numeros separados 4 posiciones: {0}", suma);
             Console.ReadKey();

             //// ejercicio # 16 /////////////

             Console.Write("Ingrese un Número: ");
             num1 = Convert.ToInt32(Console.ReadLine());
             if (num1 > 0)
             {
                 Console.WriteLine("Numero Positivo");
             }
             else if (num1 < 0)
             {
                 Console.WriteLine("Numero Negativo");
             }
             else
             {
                 Console.WriteLine("El numero es NEUTRO");
             }
             Console.ReadKey();

             ///// ejercicio # 17 ////////////////

             Console.Write("Ingrese un Número: ");
             num1 = Convert.ToInt32(Console.ReadLine());
             if (num1 % 2 == 0)
             {
                 Console.WriteLine("El Numero ingresado es PAR");
             }
             else
             {
                 Console.WriteLine("El Numero ingresado es IMPAR");
             }
             Console.ReadKey();

             /// ejercicio # 18 //////////////////

             Console.Write("Ingrese el numero donde desea Finalizar: ");
             num1 = Convert.ToInt32(Console.ReadLine());
             for (int i = 1; i < num1; i++)
             {
                 if (i % 3 == 0)
                 {
                     Console.WriteLine(i);
                     cantidad = cantidad + 1;
                 }
             }
             Console.WriteLine("Cantidad de multiplos de 3 encontrados: {0} ", cantidad);
             Console.ReadKey();

             //// ejercicio # 19 ////////

             for (int i = 1; i <= 100; i++)
             {
                 Console.WriteLine(i);
                 if (i % 2 == 0)
                 {
                     sumapar = sumapar + i;
                 }
                 else
                 {
                     sumaimpar = sumaimpar + i;
                 }
             }            Console.WriteLine("Suma de numeros PARES: {0}", sumapar);            Console.WriteLine("Suma de numeros IMPARES: {0}", sumaimpar);            Console.ReadKey();

             ////////// ejercicio # 20 ///////////

             for (int i = 1; i <= 100; i++)
             {
                 if (i % 2 == 0 || i % 3 == 0)
                 {
                     Console.WriteLine(i);
                     cantidad = cantidad + 1;
                 }
             }            Console.WriteLine("Multiplos de 2 o 3 encontrados: {0}", cantidad);            Console.ReadKey();

             ///ejercicio # 21 /////////

             for (int i = 1; i <= 100; i++)
             {
                 if (i % 2 == 0 && i % 3 == 0)
                 {
                     Console.WriteLine(i);
                     cantidad = cantidad + 1;
                 }
             }            Console.WriteLine("Multiplos de 2 y 3 encontrados: {0}", cantidad);            Console.ReadKey(); 

             ///// ejercicio # 22 /////////

             for (int i = 1; i <= 5; i++)
             {
                 Console.Write("Ingrese un numero:");
                 num1 = Convert.ToInt32(Console.ReadLine());
                 if (nummayor == 0)
                 {
                     nummayor = num1;
                     nummenor = 0;
                 }
                 if (num1 > nummayor)
                 {
                     nummayor = num1;
                     nummenor = nummayor;
                 }
                 if (num1 < nummenor)
                 {
                     nummenor = num1;
                 }
             }
             Console.WriteLine("El numero mayor es: {0}", nummayor);
             Console.WriteLine("El numero menor es: {0}", nummenor);
             Console.ReadKey();

             /// ejercicio # 23//////////////////

             Console.Write("Ingrese un de Inicio: ");
             num1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("Ingrese un de Inicio: ");
             num2 = Convert.ToInt32(Console.ReadLine());
             for (int i = num1; i <= num2; i++)
             {
                 Console.WriteLine(i);
                 cantidad = cantidad + 1;
                 if (i % 2 == 0)
                 {
                     sumapar = sumapar + 1;
                 }
                 else
                 {
                     sumaimpar = sumaimpar + i;
                 }
             }
             Console.WriteLine("Cantidad de numeros Naturales: {0}", cantidad);
             Console.WriteLine("Cantidad Numero Pares: {0}", sumapar);
             Console.WriteLine("Suma de Numeros Impares: {0}", sumaimpar);
             Console.ReadKey();

             //// ejercicio # 24 /////////////
             for (int i = 1; i < 10; i++)
             {
                 Console.Write("Ingrese un Numero: ");
                 num1 = Convert.ToInt32(Console.ReadLine());
                 if (num1 > 10)
                 {
                     mayores = mayores + "" + num1 + ",";
                 }
                 else
                 {
                     menores = menores + "" + num1 + ",";
                 }
             }
             Console.WriteLine("Los numeros: {0}", mayores + " " + "Son mayores que 10");
             Console.WriteLine("Los numeros: {0}", menores + " " + "Son Menores que 10");
             Console.ReadKey();

             ////// ejercicio # 25////////////

             for (int i = 1; i < 15; i++)
             {
                 Console.Write("Ingrese un numero entre el 1 al 100, excepto los Multiplos de 2:");
                 num1 = Convert.ToInt32(Console.ReadLine());
                 if (num1 < 0 || num1 > 100)
                 {
                     Console.WriteLine("El numero ingresado no esta entre el rango de 1 - 100");
                     Console.ReadKey();
                     return;
                 }
                 if (num1 % 2 == 0)
                 {
                     Console.WriteLine("El numero ingresado es multiplo de dos");
                     Console.ReadKey();
                     return;
                 }
             } 

             //// ejercicio # 26 ////////////////
             Console.Write("Ingrese un numero donde desea finalizar: ");
             num1 = Convert.ToInt32(Console.ReadLine());
             for (int i = 0; i <= num1; i++)
             {
                 if (i % 5 == 0)
                 {
                     summul = summul + i;
                 }
                 else
                 {
                     Console.WriteLine(i);
                     sumnum = sumnum + i;
                 }
             }
             Console.WriteLine("Suma de numeros Excepto los multiplos de 5: {0}", sumnum);
             Console.WriteLine("Valor de la suma de los multiplos de 5: {0}", summul);
             Console.ReadKey();

             ///// ejercicio # 27 //////////

             Console.Write("Ingrese un Numero donde desea finalizar el conteo: ");            num1 = Convert.ToInt32(Console.ReadLine());            for (int i = 1; i <= num1; i++)
             {
                 if (i % 2 == 0 && i % 3 == 0)
                 {
                     Console.WriteLine(i);
                     cantidad = cantidad + 1;
                 }
             }            Console.WriteLine("Cantidad de numeros Multiplos de 2 y 3: {0}", cantidad);            Console.ReadKey();

             ////// ejercicio # 28 ////////////

             for (int i = 1; i <= 10; i++)
             {
                 Console.Write("Ingrese un numero: ");
                 num1 = Convert.ToInt32(Console.ReadLine());
                 if (num1 % 5 == 0)
                 {
                     summul = summul + num1;
                 }
                 if (num1 > nummayor)
                 {
                     nummayor = num1;
                 }
                 if (num1 % 2 == 0)
                 {
                     sumaimpar = sumaimpar + num1;
                 }
             }
             Console.WriteLine("Suma de los Multiplos de 5: {0}", summul);
             Console.WriteLine("El mayor de los Numeros Ingresado: {0}", nummayor);
             Console.WriteLine("Suma de los numeros impares: {0}", sumaimpar);
             Console.ReadKey();

             ///////////ejercicio # 29/////////////////////

             Console.Write("Ingrese un Numero: ");
             num1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("Ingrese otro numero Mayor que el anterior: ");
             num2 = Convert.ToInt32(Console.ReadLine());
             if (num2 > num1)
             {
                 for (int i = num1; i < num2; i = i + 7)
                 {
                     Console.WriteLine(i);
                     if (i % 2 == 0)
                     {
                         cantidad = cantidad + 1;
                     }
                     else
                     {
                         sumaimpar = sumaimpar + i;
                     }
                 }

             }
             else
             {
                 Console.WriteLine("El segundo numero no es mayor al primero.....");

             }
             Console.WriteLine("Numeros pares encontrados: {0}", cantidad);
             Console.WriteLine("Suma de Numeros Impares: {0}", sumaimpar);
             Console.ReadKey();

             //// ejercicio # 30/////////////////

             Console.Write("Ingrese una Cantidad: ");            cantidad = Convert.ToInt32(Console.ReadLine());            if (cantidad < 500)
             {
                 Console.WriteLine("\n ========================");
                 Console.WriteLine("El numero que ingreso es: {0}", cantidad);
                 cantidad = cantidad + (cantidad * 50 / 100);
                 Console.WriteLine("Total mas 50%: {0}", cantidad);

             }            else if (cantidad >= 500 && cantidad < 1000)
             {
                 Console.WriteLine("\n ========================");
                 Console.WriteLine("El numero que ingreso es: {0}", cantidad);
                 cantidad = cantidad + (cantidad * 7 / 100);
                 Console.WriteLine("Total mas 7%: {0}", cantidad);
             }            else if (cantidad > 1000 && cantidad <= 5000)
             {
                 Console.WriteLine("\n ========================");
                 Console.WriteLine("El numero que ingreso es: {0}", cantidad);
                 cantidad = cantidad - (cantidad * 5 / 100);
                 Console.WriteLine("Total menos 5%: {0}", cantidad);
             }            Console.ReadKey();

             ///// ejercicio # 31////////////////
             for (int i = 1; i <= 10; i++)
             {
                 Console.WriteLine("==========Serie {0}==========", i);
                 for (int n = 1; n <= 10; n++)
                 {
                     Console.WriteLine(n);
                 }

             }
             Console.ReadKey();

             ///// ejercicio # 32//////////

             while (n1 > n2)
             {
                 Console.Write("Ingrese un valor entero positivo: ");
                 n1 = Convert.ToInt32(Console.ReadLine());
                 Console.Write("Ingrese el otro valor mayor al anterior: ");
                 n2 = Convert.ToInt32(Console.ReadLine());
                 if (n1 > n2)
                 {
                     Console.Write("Error debe ingresar el Segundo valor mayor o igual al primero");
                 }
             }
             c = n1;
             while (c <= n2)
             {
                 if (c % 2 == 0)
                 {
                     Console.WriteLine(c);
                     cp++;
                     sp = sp + c;
                 }
                 c++;
             }
             Console.WriteLine("Multiplos de 2 encontrados: " + cp);
             Console.WriteLine("La suma de los multiplos de 2: " + sp);
             Console.ReadKey();

             ////ejercicio # 33 ///////////////

             Console.Write("Ingrese un numero a calcular el Factorial: ");
             num1 = Convert.ToInt32(Console.ReadLine());
             for (int i = 1; i <= num1; i++)
             {
                 fact = fact * i;
             }
             Console.WriteLine("El Factorial del numero ingresado es: {0}", fact);
             Console.ReadKey();

             ///// ejercicio # 34 ///////////////

             Console.Write("Ingrese el primer número entero: ");
             n1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("Ingrese el segundo número entero: ");
             n2 = Convert.ToInt32(Console.ReadLine());
             while (c < n2)
             {
                 summul = summul - n1;
                 c++;
             }
             Console.WriteLine("La multiplicación por sumas sucesivas es: " + summul * -1);
             Console.ReadKey();

             ///// ejercicio # 35 /////////////

             while (n2 > n1)
             {
                 Console.Write("Ingrese un valor entero positivo: ");
                 n1 = Convert.ToInt32(Console.ReadLine());
                 Console.Write("Ingrese el otro valor menor al anterior: ");
                 n2 = Convert.ToInt32(Console.ReadLine());
             }
             c = n1;
             while (c >= n2)
             {
                 c = c - n2;
                 I++;
             }
             Console.WriteLine("El cociente por restas sucesivas es: " + I);
             Console.WriteLine("El resto de la divisón por restas sucesivas es: " + c);
             Console.ReadKey();

             ///////ejercicio # 37 ////////////

             Console.Write("Ingrese un numero entero positivo: ");
             num1 = Convert.ToInt32(Console.ReadLine());

             while (num1 >= 10)
             {
                 cantidad++;
                 num1 = num1 / 10;
             }
             Console.WriteLine("El número tiene: " + (cantidad + 1) + " dígitos");
             Console.ReadKey();

             ///// ejercicio # 39 //////////
             for (int i = 1; i <= N; i++)
             {
                 Console.WriteLine(i + " - " + serieFib(i));
             }
             Console.ReadKey();

         }
         public static long serieFib(int n)
         {
             if (n <= 1)
                 return n;

             else return serieFib(n - 1) + serieFib(n - 2);


             ////  ejercicio # 40 ///////////////
             Console.Write("Ingrese un valor: ");
             num1 = Convert.ToInt32(Console.ReadLine());
             while (c < num1)
             {
                 c++;
                 while (aux < c)
                 {
                     aux++;
                     if (c % aux == 0)
                     {
                         cp++;
                     }
                 }
                 if (cp == 2)
                 {
                     Console.WriteLine(" " + c);

                 }
                 cp = 0;
                 aux = 0;
             }
             Console.WriteLine("El menor numero primos es: 2");
             Console.ReadKey();

             /////// ejercicio # 41 ////////

             Console.Write("Ingrese un numero ENTERO para Convertir a BINARIO: ");
             num1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("\n===============");
             Console.Write("BINARIO: ");
             while ((num1) != 0)
             {
                 x = num1 % 2;
                 Console.Write("" + x);
                 num1 = num1 / 2;
             }
             Console.ReadKey();*/
        }
    }
}
