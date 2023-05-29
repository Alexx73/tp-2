﻿using System;
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
            // Salidas  
            int total_de_grupos, personas_total;
            double rec_pasaportes, individuales, recaudacion_total, edad_promedio; 

            int personas_con_pasaporte, personas_diez_quince;
            int operacion, edad_total , edad, total_grupos_parcial;
            double recaudacion, recaudacion_acumulada;
            edad =0;
            edad_total = 0;
            total_de_grupos = 0;
            recaudacion_acumulada = 0;
            recaudacion= 0;
            total_grupos_parcial = 0;
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
                        // return ( edad_grupo, edad, total_de_grupos, total_grupo) ;
                        // CargarGrupos() ;
                        (edad_total, edad, total_grupos_parcial, recaudacion) = CargarGrupos();
                        recaudacion_acumulada = recaudacion_acumulada + recaudacion;
                        total_de_grupos = total_de_grupos + total_grupos_parcial ;
                        // edad_grupo, edad, total_grupo

                        // Console.WriteLine("Cargar grupo");
                        // Console.Beep(440, 300);
                        // Console.ReadKey();
                    }
                    break;

                case 2:
                    {
                        Console.Clear();
                        VerDatos(total_de_grupos, recaudacion_acumulada, recaudacion );
                        // Console.WriteLine("Ver reporte");
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

         static void VerDatos(int total_de_Grupos, double recaudacion_total, double recaudacion_parcial)
        {
 
               // Obtiene el ancho de la consola
        int consoleWidth = Console.WindowWidth;

        // Calcula la posición horizontal para centrar el menú
        int menuWidth = 20; // Anchura del menú
        int leftMargin = (consoleWidth - menuWidth) / 2;

                    Console.Clear();

            // Console.WriteLine("Ver reporte");

        Console.WriteLine("".PadLeft(leftMargin) + "===== DATOS DEL DIA =====");
        Console.WriteLine("".PadLeft(leftMargin) + "TOTAL GRUPOS: {0}", total_de_Grupos);
        Console.WriteLine("".PadLeft(leftMargin) + "TOTAL PERSONAS:");
        Console.WriteLine("".PadLeft(leftMargin) + "RECAUDACION: {0} ", recaudacion_total);
        Console.WriteLine("".PadLeft(leftMargin) +"==========================");
        Console.ReadKey();        
        // return;

        }
       
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

        static public (int, int, int, double) CargarGrupos() 
        //edad_grupo, edad, total_grupo
        {
            int edad, edad_grupo, mayor, menor1, menor2, menor3, entradas_con_descuento, total_de_grupos;
            double total_grupo, total_sin_desc, entradas, descuento;
            bool aceptado = false;
            total_de_grupos =0;
            descuento = 0;
            total_grupo = 0;
            entradas = 0;
            edad = 0;
            edad_grupo = 0;
            menor1 = 0;
            menor2 = 0;
            menor3 = 0;
            mayor = 0;
            entradas_con_descuento = 0;
            total_sin_desc = 0;
            
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
                // edad_grupo += edad;
                // entradas ++;
            

            if ( edad < 4 ) // edad > 0 &
                {
                    menor1 = menor1 +1 ;
                    
                }
            if (edad >3 && edad < 11)
                {
                    menor2 = menor2 +1 ;
                }
            if (edad >10 && edad < 16)
                {
                    menor3= menor3 + 1;
                } 
                if ( edad > 15)
                {
                   mayor = mayor +1 ;
                } 
               
            }
            }
            while(edad != -1);
            entradas_con_descuento = menor2 + menor3 + mayor ; // numero total de entradas con descuento
            entradas = menor1 + entradas_con_descuento ;
            total_sin_desc = (mayor * 1500)  + (menor2 * 750) + (menor3 * 1200)   ;

            if ( entradas_con_descuento > 3)            
            {       
                descuento = total_sin_desc /100 * 15;
                // total_grupo = total_sin_desc - descuento + ( menor1 * 150) ;

            } else  {
                // total_grupo =  ( menor1 * 150) +  total_grupo;
            }
            total_grupo = total_sin_desc - descuento + ( menor1 * 150) ;
            total_de_grupos = total_de_grupos +1;


            // Console.WriteLine("el total en pesos es: {0}", total_grupo );
            // Console.WriteLine("Aceptar o Cancelar");
            // string opcion = Console.ReadLine();
            // switch (opcion)
            // {
            //     case "a":
            //         Console.WriteLine("Has seleccionado Aceptar.");
            //         aceptado = true; // acumular valores
            //         break;
            //     case "c":
            //         Console.WriteLine("Has seleccionado Cancelar.");
                    
            //         break;
            //     default:
            //         Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
            //         break;
            // }
            // Console.WriteLine();

            // Console.WriteLine("la edad total es: {0}", edad_grupo );
            Console.WriteLine("la cantidad de entradas menores es: {0}",menor1 );
                        Console.WriteLine("la cantidad de entradas menor2 es: {0}",menor2 );
            Console.WriteLine("la cantidad de entradas menor3 es: {0}",menor3 );
            Console.WriteLine("la cantidad de entradas mayor es: {0}",mayor );


            Console.WriteLine("la cantidad de entradas es: {0}",entradas );
            Console.WriteLine("el total en pesos es: {0}", total_grupo );

            Console.WriteLine("presione una tecla para volver al menu principal");
            Console.ReadKey();        
            // Console.WriteLine("la edad total es: {0}", edad_grupo );
            return ( edad_grupo, edad, total_de_grupos, total_grupo) ;
        }
    }
}
