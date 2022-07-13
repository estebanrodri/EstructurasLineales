using Estructuras_Lineales.Modelos;
using System;

namespace Estructuras_Lineales.Abstraccion
{
    internal interface IPila_TAD
    {
        /**
         * Apilar
         * */
        void Push(Persona persona);

        /**
         * Desapilar
         * */
        Persona Pop();

        /**
         * Observar elemento de la cima
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
         * Elemento de la cima convertido en String
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
         * Imprimir la Estructura de Datos Pila
         * */
        string MostrarPila();
    }
}
