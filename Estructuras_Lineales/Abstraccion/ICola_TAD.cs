using Estructuras_Lineales.Modelos;
using System;

namespace Estructuras_Lineales.Abstraccion
{
    internal interface ICola_TAD
    {

        /**
         * Encolar
         * */
        void Enqueue(Persona persona);

        /**
         * Desencolar
         * */
        Persona Dequeue();

        /**
         * Observar elemento de la cabecera
         * */
        Persona Peek();

        /**
         * Limpiar Pila
         * */
        void Clear();

        /**
         * Contiene
         * */
        bool Contains(Persona persona);

        /**
         * ObtieneTipo
         * */
        Type GetType();

        /**
         * Elemento de la cabecera convertido en String
         * */
        string ToString();

        /**
         * en Arreglo
         * */
        Persona[] ToArray();

        /**
         * Cantidad
         * */
        int Count();

        /**
         * Imprimir la Estructura de Datos Cola
         * */
        string MostrarCola();
    }
}
