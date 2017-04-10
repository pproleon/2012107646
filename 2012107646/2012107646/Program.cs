using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2012107646.Entities;
using System.Threading;

namespace _2012107646
{
    class Program
    {
        static void Main(string[] args)
        { 
            var fono1 = "975070619";
            var fono2 = "975070610";
            var fono3 = "975070608";
            var fono4 = "975070627";
            var fono5 = "975070636";
            var fono6 = "975070655";


            var venta = new Venta();

            venta.Agregar(fono1, 2, 1, 1, "Paul Proleon");
            Thread.Sleep(500);
            venta.Agregar(fono2, 2, 2, 1, "Paul Proleon");
            Thread.Sleep(500);
            venta.Agregar(fono3, 2, 3, 1, "Paul Proleon");
            Thread.Sleep(500);
            venta.Agregar(fono4, 2, 3, 2, "Paul Proleon");
            Thread.Sleep(500);
            venta.Agregar(fono5, 2, 1, 2, "Paul Proleon");
            Thread.Sleep(500);
            venta.Agregar(fono6, 1, 1, 0, "Paul Proleon");

            Console.WriteLine("INGRESE NOMBRE PARA REPORTE DE LINEAS");


      

            string busquedaCli = Console.ReadLine();
            if (busquedaCli == "Paul Proleon")
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine(venta._ventas[i]);
                }
            }
            else if (busquedaCli == "Daniel Rivera")
            {
                Console.WriteLine("Ninguna linea registrada para este cliente");
            }
            else
            {
                Console.WriteLine("Cliente no encontrado");
            }
            

           
         
        }
    }
}
