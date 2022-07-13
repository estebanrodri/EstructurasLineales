
namespace Estructuras_Lineales.Modelos
{
    internal class Persona
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }


        public Persona(string identificacion, string nombre, string primerApellido, string segundoApellido)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
        }

        public Persona()
        {

        }

        public override string ToString()
        {
            return "Persona - Identificación: " + Identificacion + " Nombre: " + Nombre + " Primer Apellido: " + PrimerApellido + " Segundo Apellido: " + SegundoApellido;
        }


        public bool Comparar(Persona Dato_Persona)
        {
            if (this.Identificacion.Equals(Dato_Persona.Identificacion) && this.Nombre.Equals(Dato_Persona.Nombre) &&
                this.PrimerApellido.Equals(Dato_Persona.PrimerApellido) && this.SegundoApellido.Equals(Dato_Persona.SegundoApellido))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
