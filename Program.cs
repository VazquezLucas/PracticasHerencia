using System;

namespace PracticasHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Caballo miBabieca=new Caballo("babieca");

            Humano miJuan = new Humano("Juan");

            Gorila miCopito = new Gorila("Copito");

            //Principio de substitucion.
            Mamiferos animal = new Mamiferos("Bucefalo");

            Caballo Bucefalo = new Caballo("Bucefalo");

            animal = Bucefalo;

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = miBabieca;
            almacenAnimales[1] = miJuan;
            almacenAnimales[2] = miCopito;

            almacenAnimales[1].getNombre();

            /*
            miJuan.getNombre();

            miBabieca.getNombre();

            miCopito.getNombre();
            */
        }
    }

    
    class Mamiferos:Object
    {
        public Mamiferos(String nombre) 
        {

            nombreSerVivo = nombre;

        }

        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si mismas");
        }

        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
        } 

        private String nombreSerVivo;
    }

    class Caballo : Mamiferos
    {

        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {



        }

        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
    }

    class Humano : Mamiferos
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {



        }
        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar ¿?");
        }
    }

    class Gorila : Mamiferos
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {



        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
    }
    
}