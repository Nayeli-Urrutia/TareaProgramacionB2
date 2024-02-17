using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace TareaProgramacionB2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tarea 2 programacion 

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("*****1. Conversión de tipos:*****");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            Console.WriteLine("*********************************");
            Console.ResetColor();

            // EJERCICIO 1.1
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|1.1. Convertir Entero a Decimal|");
            Console.ResetColor();

            int numeroEntero;
            Console.WriteLine("Ingrese un número entero: ");
            numeroEntero = int.Parse(Console.ReadLine());
            decimal numeroDecimal = Convert.ToDecimal(numeroEntero) / 100;
            Console.WriteLine("El número decimal es: " + numeroDecimal);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Presione Enter para Continuar");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|1.2. Convertir Decimal a Flotante|");
            Console.ResetColor();

            //EJERCICIO 1.2

            Console.WriteLine("Ingrese un número decimal:");
            double numeroDecimalIngresado = double.Parse(Console.ReadLine());

            double numeroFlotanteResultado = (double)numeroDecimalIngresado;

            string resultadoFormateado = numeroFlotanteResultado.ToString("F2");

            Console.WriteLine("El número flotante es: " + resultadoFormateado);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Presione Enter para continuar");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            // EJERCICIO 1.3
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|1.3. Convertir Flotante a Entero |");
            Console.ResetColor();

            float numFlo;
            Console.WriteLine("Ingrese un numero flotante");
            numFlo = float.Parse(Console.ReadLine());
            int numerEn = Convert.ToInt32(numFlo);
            Console.WriteLine("El numero Entero es:" + numerEn);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Presione Enter para Continuar");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            // EJERCICIO 1.4

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|1.4. Convertir un caracter a un entero |");
            Console.ResetColor();

            char caracter;
            Console.WriteLine("Escriba un caracter");
            caracter = char.Parse(Console.ReadLine());

            int numeroEno = Convert.ToInt32(caracter);

            Console.WriteLine("En numero Enterio es: " + numeroEno);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Presione Enter para Continuar");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            //EJERCICIO 1.5

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|1.5. Convertir entero a caracter |");
            Console.ResetColor();

            int numer;
            Console.WriteLine("Ingrese un Número Entero");
            numer = int.Parse(Console.ReadLine());

            char CARAC = Convert.ToChar(numer);
            Console.WriteLine("El caracter es:" + CARAC);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Presione Enter para Continuar");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            // 2

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("********************************************");
            Console.WriteLine("*****2. Operaciones con Tipos de Datos:*****");
            Console.WriteLine("********************************************");
            Console.ResetColor();


            //EJERCICIO 2.1

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|2.1 Calcular la suma de dos numeros enteros|");
            Console.ResetColor();


            Console.WriteLine("Escriba un número Entero");
            int primernumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba un Número Entero");
            int segundonumero = int.Parse(Console.ReadLine());

            int suma = primernumero + segundonumero;

            Console.WriteLine("La suma de los numeros es " + suma);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Presione Enter para Continuar");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            //EJERCICIO 2.2
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|2.2 Calcular la resta de dos numeros decimales|");
            Console.ResetColor();

            Console.WriteLine("Escriba un número decimal:");
            double primerNumero = double.Parse(Console.ReadLine());

            Console.WriteLine("Escriba otro número decimal:");
            double segundoNumero = double.Parse(Console.ReadLine());

            double resta = primerNumero - segundoNumero;

            string resultado = resta.ToString("F2");

            Console.WriteLine($"La resta de los números {primerNumero} y {segundoNumero} es: {resultado}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Presione Enter para continuar");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            //EJERCICIO 2.3 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|2.3 Calcular la Multiplicación de dos Números Flotantes|");
            Console.ResetColor();

            Console.WriteLine("Ingrese un Número Flotante");
            float numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un Número Flotante");
            float numero2 = float.Parse(Console.ReadLine());

            float multiplicacion = numero1 * numero2;
            string Multipli = multiplicacion.ToString("F2");

            Console.WriteLine($"La Multiplicación de los números {numero1} y {numero2} es: {Multipli}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Presione Enter para continuar");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            //EJERCICIO 2.4 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|2.3 Calcular la División de dos Números Enteros|");
            Console.ResetColor();

            Console.WriteLine("Ingrese un número entero:");
            int numer1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número entero:");
            int numer2 = int.Parse(Console.ReadLine());

            if (numer2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: No se puede dividir por cero.");
                Console.ResetColor();
            }
            else
            {
                double division = (double)numer1 / numer2;

                Console.WriteLine("La división de los números es: " + division);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Presione Enter para continuar");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();


            //EJERCICIO 2.5
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|2.3 Calcular el Modulo de dos enteros |");
            Console.ResetColor();


            Console.WriteLine("Ingrese un número entero:");
            int dividendo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número entero:");
            int divisor = int.Parse(Console.ReadLine());

            int modulo = dividendo % divisor;

            Console.WriteLine("El Modulo es:" + modulo);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Presione Enter para continuar");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            // 3

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("**********************************");
            Console.WriteLine("*****3. Uso de Char y String:*****");
            Console.WriteLine("**********************************");
            Console.ResetColor();

            //EJERCICIO 3.1
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|3.1 Leer Cadena de texto y pasar a Mayusculas|");
            Console.ResetColor();

            Console.WriteLine("Ingrese un Texto:");
            string nombre = Console.ReadLine();

            string Textomayuscula = nombre.ToUpper();
            Console.WriteLine("La cadena de Texto en Mayusculas es:" + Textomayuscula);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Presione Enter para continuar");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();


            //EJERCICIO 3.2

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|3.2 Leer Cadena de texto y pasar a Minuscula|");
            Console.ResetColor();

            Console.WriteLine("Ingrese un Texto:");
            string mini = Console.ReadLine();

            string TEXMINI = mini.ToLower();
            Console.WriteLine("La cadena de Texto en MINUSCYLAS es:" + TEXMINI);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Presione Enter para continuar");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            //EJERCICIO 3.3

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|3.2 Leer Cadena de texto e Imprimirla al revéz |");
            Console.ResetColor();

            Console.WriteLine("Ingrese un Texto:");
            string contra = Console.ReadLine();

            string TEXC = "";
            for (int i = contra.Length - 1; i >= 0; i--)
            {
                TEXC += contra[i];
            }

            Console.WriteLine("La cadena al revés es: " + TEXC);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Presione Enter para continuar");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            //EJERCICIO 3.4

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("|3.2 Leer Cadena de texto y buscar una palabra en ella|");
            Console.ResetColor();

            Console.WriteLine("Ingrese una cadena de texto:");
            string texto1 = Console.ReadLine();

            Console.WriteLine("Ingrese la palabra a buscar:");
            string palabra = Console.ReadLine();

            int indice = texto1.IndexOf(palabra);

            if (indice == -1)
            {
                Console.WriteLine("La palabra no se encuentra en la cadena.");
            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(texto1.Substring(0, indice));
                Console.ResetColor();
                Console.Write(palabra);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(texto1.Substring(indice + palabra.Length));
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Presione Enter para continuar");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();



                //EJERCICIO 3.5
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("|3.2 Leer Cadena de texto y contar las vocales|");
                Console.ResetColor();

                Console.WriteLine("Ingrese una cadena de texto:");
                string texto = Console.ReadLine();

                int numeroVocales = 0;

                foreach (char letra in texto)
                {
                    if ("aeiouAEIOU".Contains(letra))
                    {
                        numeroVocales++;
                    }
                }

                Console.WriteLine("La cadena contiene " + numeroVocales + " vocales.");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Presione Enter para continuar");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

                // 4

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("********************************************");
                Console.WriteLine("*****4. Uso de tipo de Datos Numericos:*****");
                Console.WriteLine("********************************************");
                Console.ResetColor();


                //EJERCICIO 4.1
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("|4.1 Aréa de un Triángulo|");
                Console.ResetColor();

                Console.WriteLine("Ingresa la base del Triángulo");
                double base1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa la Altura del Triángulo");
                double altura = double.Parse(Console.ReadLine());

                double areatriangu = (base1 * altura) / 2;
                Console.WriteLine("El Aréa del Triangulo es:" + areatriangu);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Presione Enter para continuar");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

                //EJERCICIO 4.2
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("|4.2 Volumen de una Esfera |");
                Console.ResetColor();

                Console.WriteLine("Ingrese el diámetro de la esfera:");
                double diametro = double.Parse(Console.ReadLine());


                double radio = diametro / 2;


                double volumen = (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);

                Console.WriteLine("El volumen de la esfera es: {0:F2}", volumen);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Presione Enter para continuar");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

                //EJERCICIO 4.3
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("|4.3 Distancia entre puntos|");
                Console.ResetColor();

                Console.WriteLine("Ingrese la coordenada X del primer punto:");
                double x1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la coordenada Y del primer punto:");
                double y1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la coordenada X del segundo punto:");
                double x2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la coordenada Y del segundo punto:");
                double y2 = double.Parse(Console.ReadLine());

                double distanciaPuntos = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

                Console.WriteLine("La distancia entre los dos puntos es: " + distanciaPuntos);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Presione Enter para continuar");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();


                //EJERCICIO 4.4
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("|4.4 Temperatura de Celsius a Fahrenheit|");
                Console.ResetColor();
                Console.WriteLine("Ingrese la temperatura en grados Celsius:");
                double celsius = double.Parse(Console.ReadLine());

                double fahrenheit = (celsius * 9 / 5) + 32;

                Console.WriteLine("La temperatura en grados Fahrenheit es: " + fahrenheit);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Presione Enter para continuar");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();

                //EJERCICIO 4.5
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("|4.4 Temperatura de  Fahrenheit a Celsius|");
                Console.ResetColor();

                Console.WriteLine("Ingrese la temperatura en grados Fahrenheit:");
                double fah = double.Parse(Console.ReadLine());

                double cels = (fah - 32) * 5 / 9;

                Console.WriteLine("La temperatura en grados Celsius es: " + cels);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Presione enter para salir del programa");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();


            }
        }
    }


}
    

    }
}
