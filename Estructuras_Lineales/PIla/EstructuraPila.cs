using Estructuras_Lineales.Abstraccion;
using Estructuras_Lineales.Modelos;
using System;

namespace Estructuras_Lineales.Pila
{
    internal class EstructuraPila : IPila_TAD
    {
        private Nodo ElementoCima;
        private int CantidadDeElementos;

        public EstructuraPila()
        {
            ElementoCima = null;
            CantidadDeElementos = 0;
        }

        public void Clear()
        {
            ElementoCima.Nodo_Siguiente = null;
            ElementoCima = null;
            CantidadDeElementos = 0;
        }

        public bool Contains(Persona Persona)
        {
            if (Persona == null)
            {
                return false;
            }
            else
            {
                Nodo Actual = ElementoCima;
                while (Actual != null)
                {
                    Persona PersonaActual = Actual.Dato_Persona;

                    if (PersonaActual.Comparar(Persona))
                    {
                        return true;
                    }
                    Actual = Actual.Nodo_Anterior;
                }
                return false;
            }
        }

        public int Count()
        {
            return CantidadDeElementos;
        }

        public Persona Peek()
        {
            if(EstaVacio())
            {
                return null; // La Pila está vacía
            }
            else
            {
                Nodo Actual = ElementoCima;
                Persona Persona = Actual.Dato_Persona;
                return Persona;
            }
        }

        public Persona Pop()
        {
            if (EstaVacio())
            {
                return null; // La Pila está vacía
            }
            else
            {
                Nodo Actual = ElementoCima;
                Persona Persona = new Persona(Actual.Dato_Persona.Identificacion, Actual.Dato_Persona.Nombre,
                                              Actual.Dato_Persona.PrimerApellido, Actual.Dato_Persona.SegundoApellido);
                Nodo Anterior = Actual.Nodo_Anterior;
                ElementoCima = Anterior;
                CantidadDeElementos--;
                return Persona;
            }
        }

        public void Push(Persona persona)
        {
            Nodo NuevoNodo = new Nodo(persona);

            if (EstaVacio())
            {
                ElementoCima = NuevoNodo;
                ElementoCima.Nodo_Siguiente = null;
            }
            else
            {
                ElementoCima.Nodo_Siguiente = NuevoNodo;
                NuevoNodo.Nodo_Siguiente = null;
                NuevoNodo.Nodo_Anterior = ElementoCima;
                ElementoCima = NuevoNodo;
            }
            CantidadDeElementos++;
        }

        public Persona[] ToArray()
        {
            Persona[] Personas = new Persona[CantidadDeElementos];
            Nodo Actual = ElementoCima;
            int NumeroElemento = 0;
            while (Actual != null)
            {
                Persona Persona = new Persona(Actual.Dato_Persona.Identificacion, Actual.Dato_Persona.Nombre,
                                              Actual.Dato_Persona.PrimerApellido, Actual.Dato_Persona.SegundoApellido);
                Personas[NumeroElemento] = Persona;
                NumeroElemento++;
                Actual = Actual.Nodo_Anterior;
            }
            return Personas;
        }

        Type IPila_TAD.GetType()
        {
            return ElementoCima.Dato_Persona.GetType();
        }

        public override string ToString()
        {
            return ElementoCima.Dato_Persona.ToString();
        }

        public string MostrarPila()
        {
            Nodo Actual = ElementoCima;
            string ElementosPila = "-------------------------\n";
            while (Actual != null)
            {
                Persona PersonaActual = Actual.Dato_Persona;
                ElementosPila += "-- " + PersonaActual.Nombre + "\n-------------------------\n";
                Actual = Actual.Nodo_Anterior;
            }
            return ElementosPila;
        }

        private bool EstaVacio()
        {
            return CantidadDeElementos == 0;
        }

    }
}
