using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSemana1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caballo miCaballo = new Caballo("Boni");
            Humano miHumano = new Humano("Jorge");
            Gorila miGorila = new Gorila("Taz");
            Ballena miBallena = new Ballena("Fey");
            Cocodrilo miCocodrilo = new Cocodrilo("Sancheza");

            Mamifero[] almacenAnimales = new Mamifero[3];
            almacenAnimales[0] = miCaballo;
            almacenAnimales[1] = miHumano;
            almacenAnimales[2] = miGorila;
            almacenAnimales[3] = miBallena;
            almacenAnimales[4] = miCocodrilo;

            for(int i = 0; i < 3; i++)
            {
                almacenAnimales[i].pensar();
            }

            Mamifero miMamifero = new Mamifero("");
            miMamifero.pensar();

            miCaballo.cuidarCrias();
            miHumano.getNombre();
            miGorila.Trepar();

        }

       
              
    }

    abstract class Animales
    {
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public abstract void getNombre();
    }


    interface IAnimalesTerrestres
    {
        int numeroPatas();
    }

    class Reptil:Animales
    {
        public Reptil(String nombre)
        {
            String nombreSerVivo = nombre;
        }

        public override void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombreServVivo);

        }

        private String nombreServVivo;
    }

    class Mamifero:Animales
    {
        public Mamifero(String nombre)
        {
            String nombreSerVivo = nombre;
        }

        public void pensar()
        {
            Console.WriteLine("Pensamientos básico instintivos");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuidar de las crias hasta que se valgan por si solar");
        }


        public override void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
        }

        private String nombreSerVivo;

    }
        class Ballena : Mamifero
        {
            public Ballena (String nombreBallena) : base(nombreBallena)
            {
               
            }

            public void nadar()
            {
                Console.WriteLine("Soy capaz de nadar");
            }
        }

        class Caballo : Mamifero
        {
            public Caballo (String nombreCaballo) : base(nombreCaballo)
            {

            }

            public void Galopar()
            {
                Console.WriteLine("Soy capaz de galopar");
            }
        }

        class Humano : Mamifero
        {
          public Humano (String nombreHumano) : base(nombreHumano)
            {

            }

            public void Pensar()
            {
                Console.WriteLine("Soy capaz de pensar?");
            }
        }

        class Gorila : Mamifero
        {
            public Gorila(String nombreGorila) : base(nombreGorila)
            {

            }
            
            public void Trepar()
            {
                Console.WriteLine("Soy capaz de trepar");
            }
        }

        class Cocodrilo : Mamifero
        {
            public Cocodrilo(String nombreCocodrilo) : base(nombreCocodrilo)
            {

            }
            public void muerde()
            {
                Console.WriteLine("Soy capaz de morder");
            }

        }

    
}
