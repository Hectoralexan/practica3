using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{


    
    public abstract class Bebida
    {
        public string Tipo { get; set; }
        public string Categoria { get; set; }
        public string CaracteristicasCliente { get; set; }
        public string Empleados { get; set; }

        public abstract void Preparar();
    }

 
    public class BebidaCaliente : Bebida
    {
        public override void Preparar()
        {
            Console.WriteLine($"Preparando {Categoria} {Tipo} para {CaracteristicasCliente} con la ayuda de {Empleados}...");
            Console.WriteLine("Calentando la bebida...");
            Console.WriteLine("Sirviendo la bebida caliente.");
        }
    }

    
    public class BebidaFria : Bebida
    {
        public override void Preparar()
        {
            Console.WriteLine($"Preparando {Categoria} {Tipo}  para {CaracteristicasCliente} con la ayuda de {Empleados}...");
            Console.WriteLine("Mezclando los ingredientes...");
            Console.WriteLine("Sirviendo la bebida fría.");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Tipo de bebida (caliente/fría): ");
            string tipoBebida = Console.ReadLine();

            Console.Write("Categoría de bebida (Bebidas calientes café/té/leche - Bebidas frías refresco/jugo/cerveza): ");
            string categoriaBebida = Console.ReadLine();

            Console.Write("Nombre del cliente ");
            string caracteristicasCliente = Console.ReadLine();

            Console.Write("Empleados que ayudarán en la preparación: ");
            string empleados = Console.ReadLine();

            
            Bebida bebida;
            if (tipoBebida == "caliente")
            {
                bebida = new BebidaCaliente();
            }
            else if (tipoBebida == "fría")
            {
                bebida = new BebidaFria();
            }
            else
            {
                Console.WriteLine("Tipo de bebida no reconocido.");
                return;
            }

           
            bebida.Tipo = tipoBebida;
            bebida.Categoria = categoriaBebida;
            bebida.CaracteristicasCliente = caracteristicasCliente;
            bebida.Empleados = empleados;

            
            bebida.Preparar();
        }
    }
}


