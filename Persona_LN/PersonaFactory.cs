using Persona_EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_LN
{
    public class PersonaFactory
    {
        public static Persona AddPersona(string pId, string pNombre, string pCorreo, string pTelefono, DateTime pNacimiento)
        {
            Persona persona = new Persona()
            {
                Id = pId,
                Nombre = pNombre,
                Correo = pCorreo,
                Telefono = pTelefono,
                Nacimiento = pNacimiento
            };
            return persona;
        }
    }
}
