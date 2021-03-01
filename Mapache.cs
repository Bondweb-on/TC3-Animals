using System;

namespace Animal
{
    enum TipoAlimentacion
    {
        CARNIVORO,
        HERBIVORO,
        OMNIVORO
    }
    class Mapache
    {
        // Qué atributos tiene un mapache?
        // Es macho o hembra?
        // Está vivo?
        // Tamaño
        // Peso
        // Color
        // Es vivíparo u ovíparo?
        // Tipo de alimentación
        
        bool hembra;
        bool vivo;
         float tamanio; //cm
        float peso; //kg
        //public -> Podemos mostrar en otras clases.
        public string color;

        public string nombre;
        // Representa una propiedad de los mapaches en general
        // static => Le corresponde a la clase y no al objeto
        public static bool viviparo = true;
        public static TipoAlimentacion tipoAlimentacion = TipoAlimentacion.OMNIVORO;

        // Método constructor
        public Mapache(bool hembra, float tamanio, float peso, string color, string nombre)
        {
            // Anteponer this. a las variables de los objetos
            // variables de instancia
            //this -> este objeto (el objeto que se esta construyendo)
            this.vivo = true;

            // variables locales
            // bool vivo = false;

            // variables estaticas
            // Mapache.viviparo = true;

            this.hembra = hembra;

            this.tamanio = tamanio;

            this.peso = peso;

            this.color = color;

            this.nombre = nombre;
        }

        private string ObtenerNombreAMostrar()
        {
            string nombreAMostrar;
            if(this.nombre != null)
            {
                //Sí hay un nombre definido
                nombreAMostrar = this.nombre;
            }
            else
            {
                nombreAMostrar = "Mapache";
            }
            return nombreAMostrar;
        }

        // Qué hace un mapache?
        // Moverse
        // --Respirar
        // Comer
        // --Existir
        // --Reproducirse
        // Trepar
        // --Vivir?
        // --Morir?
        // Comunicarse/Hacer ruidos
        public void Moverse()
        {
            //Console.WriteLine("*Mapache se mueve*");
            string nombreAMostrar = ObtenerNombreAMostrar();

            Console.WriteLine("*" + nombreAMostrar + " se mueve*");
            //Console.WriteLine($"*{this.nombre} se mueve*");
        }

        public void Comer()
        {
            //Console.WriteLine("*Mapache entra en el bote de basura*");
            string nombreAMostrar = ObtenerNombreAMostrar();

            Console.WriteLine("*" + nombreAMostrar + " entra en el bote de basura*");
        }

        public void Trepar()
        {
            //Console.WriteLine("*Mapache se sube a un arbol*");
            string nombreAMostrar = ObtenerNombreAMostrar();

            Console.WriteLine("*" + nombreAMostrar + " se sube a un arbol*");
        }

        public void Hablar()
        {
            Console.WriteLine("*Happy mapache noises*");
        }

    
    }
}