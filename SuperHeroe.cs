using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    public class SuperHeroe
    {
        // Crear atributos y encapsulamiento

        public static int cantidadHeroes;
        public string Nombre { get; set; }
        public string IdentidadSecreta { get; set; }
        public string Ciudad { get; set; }
        public bool PuedeVolar { get; set; }
        public Superpoder Superpoder { get; set; }

        // Cosntructor
        public SuperHeroe()
        {
            this.Superpoder = new Superpoder();
            cantidadHeroes++;
        }

        // Funciones
        public void Imprimir()
        {
            Console.WriteLine($"\n----------------- Super Heroe número {cantidadHeroes} ----------------- ");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Identidad secreta: {this.IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {this.Ciudad}");
            Console.WriteLine($"Puede volar: {this.PuedeVolar}");
            Console.WriteLine($"Super poder: {this.Superpoder.Nombre}");
            Console.WriteLine($"Descripción: {this.Superpoder.Descripcion}");
            Console.WriteLine($"Nivel: {this.Superpoder.Nivel}");

        }

    }
}
