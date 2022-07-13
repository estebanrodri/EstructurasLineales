using Estructuras_Lineales.Abstraccion;
using Estructuras_Lineales.Modelos;
using Estructuras_Lineales.Pila;
using Estructuras_Lineales.Cola;
using System;

namespace Estructuras_Lineales
{
    internal class Consola
    {
        static void Main(string[] args)
        {
            Consola consola = new Consola();
            consola.ProbarFuncionamientoEstructuraPila();
            //consola.ProbarFuncionamientoEstructuraCola();
            Console.ReadLine();
        }


        private void ProbarFuncionamientoEstructuraPila()
        {
            Console.WriteLine("Estructura Lineal: Pila");
            IPila_TAD PILA = new EstructuraPila();

            Console.WriteLine("Se inicializa la Pila");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Pila Actual: \n" + PILA.MostrarPila() + "\n");

            // Everardo Carolina Ana Juan
            Persona Persona1 = new Persona { Identificacion = "209875421", Nombre = "Juan", PrimerApellido = "Ramírez", SegundoApellido = "Villalta" };
            Persona Persona2 = new Persona { Identificacion = "206467013", Nombre = "Ana", PrimerApellido = "Gonzales", SegundoApellido = "Rodríguez" };
            Persona Persona3 = new Persona { Identificacion = "209675890", Nombre = "Carolina", PrimerApellido = "Ramírez", SegundoApellido = "Oreamuno" };
            Persona Persona4 = new Persona { Identificacion = "208661123", Nombre = "Everardo", PrimerApellido = "Jiménez", SegundoApellido = "Valverde" };

            PILA.Push(Persona1);
            Console.WriteLine("Push: " + PILA.Peek().ToString() + "\n");
            Console.WriteLine("Pila Actual: \n" + PILA.MostrarPila());

            PILA.Push(Persona2);
            Console.WriteLine("Push: " + PILA.Peek().ToString() + "\n");
            Console.WriteLine("Pila Actual: \n" + PILA.MostrarPila());

            PILA.Push(Persona3);
            Console.WriteLine("Push: " + PILA.Peek().ToString() + "\n");
            Console.WriteLine("Pila Actual: \n" + PILA.MostrarPila());

            PILA.Push(Persona4);
            Console.WriteLine("Push: " + PILA.Peek().ToString() + "\n");
            Console.WriteLine("Pila Actual: \n" + PILA.MostrarPila());

            Console.WriteLine("Pop: " + PILA.Pop().ToString() + "\n");
            Console.WriteLine("Pila Actual: \n" + PILA.MostrarPila());

            Console.WriteLine("Cantidad de elementos: " + PILA.Count().ToString() + "\n");
            Console.WriteLine("¿Está en la Pila " + Persona1.Nombre + "?: " + PILA.Contains(Persona1).ToString() + "\n");

            Console.WriteLine("ToString(): El Próximo Convertido en String: " + PILA.ToString() + "\n");

            Console.WriteLine("GetType(): El Tipo de datos de la Pila es: " + PILA.GetType() + "\n");


            Persona[] Personas = PILA.ToArray();
            Console.WriteLine("ToArray: Se obtiene la PILA en un Arreglo de Datos de Tipo Persona" + "\n");
            PILA.Clear();
            Console.WriteLine("Clear: Se borran todos los elementos de la PILA" + "\n");
            Console.WriteLine("Pila Actual: \n" + PILA.MostrarPila() + "\n");

            Console.WriteLine("Recorremos el Arreglo de Personas" + "\n");
            foreach (Persona Persona in Personas)
            {
                Console.WriteLine("Persona en el Array: " + Persona.ToString() + "\n");
            }

        }

        private void ProbarFuncionamientoEstructuraCola()
        {
            Console.WriteLine("Estructura Lineal: Cola");
            ICola_TAD COLA = new EstructuraCola();

            Console.WriteLine("Se inicializa la Cola");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Cola Actual: \n" + COLA.MostrarCola() + "\n");

            //    Juan Ana Carolina Everardo
            Persona Persona1 = new Persona { Identificacion = "209875421", Nombre = "Juan", PrimerApellido = "Ramírez", SegundoApellido = "Villalta" };
            Persona Persona2 = new Persona { Identificacion = "206467013", Nombre = "Ana", PrimerApellido = "Gonzales", SegundoApellido = "Rodríguez" };
            Persona Persona3 = new Persona { Identificacion = "209675890", Nombre = "Carolina", PrimerApellido = "Ramírez", SegundoApellido = "Oreamuno" };
            Persona Persona4 = new Persona { Identificacion = "208661123", Nombre = "Everardo", PrimerApellido = "Jiménez", SegundoApellido = "Valverde" };

            COLA.Enqueue(Persona1);
            Console.WriteLine("Enqueue: " + Persona1.ToString() + "\n");
            Console.WriteLine("Cola Actual: \n" + COLA.MostrarCola() + "\n");

            COLA.Enqueue(Persona2);
            Console.WriteLine("Enqueue: " + Persona2.ToString() + "\n");
            Console.WriteLine("Cola Actual: \n" + COLA.MostrarCola() + "\n");

            COLA.Enqueue(Persona3);
            Console.WriteLine("Enqueue: " + Persona3.ToString() + "\n");
            Console.WriteLine("Cola Actual: \n" + COLA.MostrarCola() + "\n");

            COLA.Enqueue(Persona4);
            Console.WriteLine("Enqueue: " + Persona4.ToString() + "\n");
            Console.WriteLine("Cola Actual: \n" + COLA.MostrarCola() + "\n");

            Console.WriteLine("Dequeue: " + COLA.Dequeue().ToString() + "\n");
            Console.WriteLine("Cola Actual: \n" + COLA.MostrarCola() + "\n");

            Console.WriteLine("Observar Peek: " + COLA.Peek().ToString() + "\n");
            Console.WriteLine("Cola Actual: \n" + COLA.MostrarCola() + "\n");


            Console.WriteLine("Cantidad de elementos: " + COLA.Count().ToString() + "\n");
            Console.WriteLine("¿Está en Cola "+ Persona3.Nombre + "?: " + COLA.Contains(Persona3).ToString() + "\n");

            Console.WriteLine("ToString: El Próximo Convertido en String: " + COLA.ToString() + "\n");

            Persona[] Personas = COLA.ToArray();
            Console.WriteLine("ToArray: Se obtiene la COLA en un Arreglo de Datos de Tipo Persona" + "\n");
            COLA.Clear();
            Console.WriteLine("Clear: Se borran todos los elementos de la COLA" + "\n");
            Console.WriteLine("Cola Actual: \n" + COLA.MostrarCola() + "\n");

            Console.WriteLine("Recorremos el Arreglo de Personas" + "\n");
            foreach (Persona Persona in Personas)
            {
                Console.WriteLine("Persona en el Array: " + Persona.ToString() + "\n");
            }
        }



    }
}
