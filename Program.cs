using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cajero_app2
{
    class Program
    {
        static double saldo;

        static void Main(string[] args)
        {
            int operacion, edad_total;
            edad_total = 0;
            // saldo = 100;
            // int operacion;


            // Console.WriteLine("Elija una operacion");
            // Console.WriteLine("\t1- Deposito \n\t2- Extraccion\n\t3- Consulta\n\t4- Salida");
            // operacion = Convert.ToInt32(Console.ReadLine());

            do
            {
                operacion = Menu();
                switch (operacion)
            {
                //Console.Clear();
                case 1:
                    {
                        Console.Clear();
                        CargarGrupos() ;
                        // Console.WriteLine("Cargar grupo");
                        // Console.Beep(440, 300);
                        // Console.ReadKey();
                    }
                    break;

                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("Ver reporte");
                        Console.Beep(440, 300);
                        Console.ReadKey();                     
                    }
                    break;
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("Salir");
                        // Console.WriteLine("Su saldo es: {0:c2}", Consulta());
                        Console.Beep(440, 300);
                        Thread.Sleep(1000);
                    }
                    break;
                case 4:
                    {
                        Console.Clear();
                        Console.Beep(440, 3000);
                    }
                    break;
            }
            }
            while(operacion != 3);         
        }

        //--------------------------------------------------
       
       static public int Menu()
        {
            int operacion;
            int paddingTop = 5;

              // Obtiene el ancho de la consola
        int consoleWidth = Console.WindowWidth;

        // Calcula la posición horizontal para centrar el menú
        int menuWidth = 20; // Anchura del menú
        int leftMargin = (consoleWidth - menuWidth) / 2;

        Console.Title = ("Paseo Aventura");
        // Console.BackgroundColor = ConsoleColor.Gray;
                
        // Establece la posición del cursor para centrar el menú
        Console.SetCursorPosition(leftMargin, Console.CursorTop);
        Console.Clear();
            for (int i = 0; i < paddingTop; i++)
        {
            Console.WriteLine();
        }

        Console.WriteLine("".PadLeft(leftMargin) + "=== MENU PRINCIPAL ===");
        Console.WriteLine("".PadLeft(leftMargin) + "1. Cargar grupo");
        Console.WriteLine("".PadLeft(leftMargin) + "2. Reporte diario");
        Console.WriteLine("".PadLeft(leftMargin) + "3. Salir");
        Console.WriteLine("".PadLeft(leftMargin) +"======================");
        Console.Write("".PadLeft(leftMargin) +"Ingrese opción: ");

            operacion = Convert.ToInt32(Console.ReadLine());      
            if (operacion < 1 || operacion >4)
            { 
            Console.WriteLine("".PadLeft(leftMargin) +"opcion invalida");
            Thread.Sleep(1000);
            }
            Console.Clear();
            return operacion;
        }

        // ---------------------------------------------------------

        static public (int, double) CargarGrupos() 
        {
            int edad, edad_grupo;
            double total_grupo, entradas, descuento;
            descuento = 0;
            total_grupo = 0;
            entradas = 0;
            edad = 0;
            edad_grupo = 0;
            
            do 
            {
                            Console.Clear();
            Console.WriteLine("=== Cargar grupo ===");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ingresar -1 para salir");

            Console.ResetColor();
            Console.WriteLine("ingresar edad");

            edad = Convert.ToInt32(Console.ReadLine()); 
            if (edad != -1) 
            {
                edad_grupo += edad;
                entradas ++;
            }
            }
            while(edad != -1);

            if ( entradas >= 4) 
                 
            {
                descuento = (entradas * 1500) /100 * 15;
                total_grupo = (entradas * 1500) - descuento;
            } else  {
                total_grupo = (entradas * 1500);
            }

            


            Console.WriteLine("la edad total es: {0}", edad_grupo );
            Console.WriteLine("la cantida de entradas es: {0}", entradas );
            Console.WriteLine("el total en pesos es: {0}", total_grupo );

            Console.WriteLine("presione una tecla para volver al menu principal");
            Console.ReadKey();                                 
            Console.WriteLine("la edad total es: {0}", edad_grupo );
            return (edad_grupo, total_grupo) ;
        }
    }
}
