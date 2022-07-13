using Estructuras_Lineales.Abstraccion;
using Estructuras_Lineales.Modelos;
using System;

namespace Estructuras_Lineales.Cola
{
    internal class EstructuraCola : ICola_TAD
    {
        private Nodo PrimerElemento;
        private Nodo UltimoElemento;
        private int CantidadDeElementos;

        public EstructuraCola()
        {
            PrimerElemento = null;
            CantidadDeElementos = 0;
        }

        public void Clear()
        {
            PrimerElemento.Nodo_Siguiente = null;
            PrimerElemento = null;
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
                Nodo Actual = PrimerElemento;
                while (Actual != null)
                {
                    Persona PersonaActual = Actual.Dato_Persona;

                    if (PersonaActual.Comparar(Persona))
                    {
                        return true;
                    }
                    Actual = Actual.Nodo_Siguiente;
                }
                return false;
            }
        }

        public int Count()
        {
            return CantidadDeElementos;
        }

        public Persona Dequeue()
        {
            if (EstaVacio())
            {
                return null; // La Cola está vacía
            }
            else
            {
                Nodo Actual = PrimerElemento;
                Persona Persona = new Persona(Actual.Dato_Persona.Identificacion, Actual.Dato_Persona.Nombre,
                                              Actual.Dato_Persona.PrimerApellido, Actual.Dato_Persona.SegundoApellido);
                Nodo Siguiente = Actual.Nodo_Siguiente;
                PrimerElemento = Siguiente;
                CantidadDeElementos--;
                return Persona;
            }
        }

        public void Enqueue(Persona persona)
        {
            Nodo NuevoNodo = new Nodo(persona);

            if (EstaVacio())
            {
                PrimerElemento = NuevoNodo;
                PrimerElemento.Nodo_Siguiente = null;
                UltimoElemento = NuevoNodo;
            }
            else
            {

                UltimoElemento.Nodo_Siguiente = NuevoNodo;
                NuevoNodo.Nodo_Siguiente = null;
                NuevoNodo.Nodo_Anterior = UltimoElemento;
                UltimoElemento = NuevoNodo;
            }
            CantidadDeElementos++;
        }

        public Persona Peek()
        {
            if (EstaVacio())
            {
                return null; // La Cola está vacía
            }
            else
            {
                Nodo Actual = PrimerElemento;
                Persona Persona = Actual.Dato_Persona;
                return Persona;
            }
        }

        public Persona[] ToArray()
        {
            Persona[] Personas = new Persona[CantidadDeElementos];
            Nodo Actual = PrimerElemento;
            int NumeroElemento = 0;
            while (Actual != null)
            {
                Persona Persona = new Persona(Actual.Dato_Persona.Identificacion, Actual.Dato_Persona.Nombre,
                                              Actual.Dato_Persona.PrimerApellido, Actual.Dato_Persona.SegundoApellido);
                Personas[NumeroElemento] = Persona;
                NumeroElemento++;
                Actual = Actual.Nodo_Siguiente;
            }
            return Personas;
        }

        Type ICola_TAD.GetType()
        {
            return PrimerElemento.Dato_Persona.GetType();
        }

        public override string ToString()
        {
            return PrimerElemento.Dato_Persona.ToString();
        }

        private bool EstaVacio()
        {
            return CantidadDeElementos == 0;
        }

        public string MostrarCola()
        {
            Nodo Actual = PrimerElemento;
            string ElementosCola = "";
            while (Actual != null)
            {
                Persona PersonaActual = Actual.Dato_Persona;
                ElementosCola += "| " + PersonaActual.Nombre + " | ";
                Actual = Actual.Nodo_Siguiente;
            }
            return ElementosCola;
        }
    }
}
