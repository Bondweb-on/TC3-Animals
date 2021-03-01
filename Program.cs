using System;

namespace Animal
{
    class Program
    {
        // En POO, las funciones y procedimientos se llaman métodos
        // En todo programa, se debe incluir un punto inicial
        // El nombre estándar para el método que inicia un programa
        // es "main": static void Main
        // 
        // void -> no devuelve ningún valor (es un procedimiento)
        // static -> entorno estático; trabajando a nivel clase en vez de objeto
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            DecirHolaMundo();
            
            //Usar clase como tipo de variable
            //new -> contruir algo
            //new Mapache() -> Llamar al metodo constructor y crear un nuevo Mapache
            Mapache mapache1 = new Mapache(true, 40f, 3.5f, "gris", "Mia"); 

            Mapache mapache2 = new Mapache(false, 55f, 4.1f, "marrón", "Ramón");

            Mapache mapache3 = new Mapache(false, 50f, 7.2f, "gris", "Paco Peréz");  

            // Tiene un nombre vacío
            // Mapache mapache4 = new Mapache(false, 50f, 4.5f, "gris", "");
            // No tiene nombre
            Mapache mapache4 = new Mapache(false, 50f, 4.5f, "gris", null);

            //Mostrar información de uno de los mapaches.
            //Console.WriteLine(mapache2);  //Animals.Mapache
            Console.WriteLine("Mapache #2");
            Console.WriteLine("Color: " + mapache2.color);
            Console.WriteLine("Nombre: " + mapache2.nombre);

            Console.WriteLine("Mapache #4");
            Console.WriteLine("Nombre: " + mapache4.nombre);

            //acciones
            mapache3.Moverse();
            mapache4.Moverse();

            mapache2.Comer();
            mapache4.Comer();

            mapache1.Trepar();
            mapache4.Trepar();

            //Información general de mapaches
            Console.WriteLine("----------------");
            Console.WriteLine("Información general sobre mapaches");
            Console.WriteLine("");
            if (Mapache.viviparo)
            {
                Console.WriteLine("Vivíparo");
            }
            else
            {
                Console.WriteLine("Ovíparo");
            }
            if (Mapache.tipoAlimentacion == TipoAlimentacion.CARNIVORO)
            {
                Console.WriteLine("Carnívoro");
            }
            else if (Mapache.tipoAlimentacion == TipoAlimentacion.HERBIVORO)
            {
                Console.WriteLine("Herbívoro");
            }
            else if (Mapache.tipoAlimentacion == TipoAlimentacion.OMNIVORO)
            {
                Console.WriteLine("Omnívoro");
            }
        }

        static string ObtenerTextoAMostrar()
        {
            return "Hello World!";
        }
        
        static void DecirHolaMundo()
        {
            string textoAMostrar = ObtenerTextoAMostrar();
            Console.WriteLine(textoAMostrar);
        }
    }
}
