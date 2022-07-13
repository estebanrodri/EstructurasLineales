
namespace Estructuras_Lineales.Modelos
{
    internal class Nodo
    {
        public Persona Dato_Persona { get; set; }
        public Nodo Nodo_Siguiente { get; set; }
        public Nodo Nodo_Anterior { get; set; }

        public Nodo(Persona Dato_Persona)
        {
            this.Dato_Persona = Dato_Persona;
            this.Nodo_Siguiente = null;
            this.Nodo_Anterior = null;
        }

        public Nodo()
        {
            this.Dato_Persona = null;
            this.Nodo_Siguiente = null;
            this.Nodo_Anterior = null;
        }

    }
}
