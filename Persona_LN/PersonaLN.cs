using Persona_DB;
using Persona_EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona_LN
{
    public class PersonaLN
    {
        public Persona GetPersonaById(string pId)
        {
            PersonaDB personaDB = new PersonaDB();
            Persona persona = personaDB.GetPersonaById(pId);
            return FullPropPersona(persona);
        }
        public List<Persona> GetAllPersona()
        {
            PersonaDB personaDB = new PersonaDB();
            List<Persona> listaPersona = personaDB.GetAllPersona();
            return FullPropPersonas(listaPersona);
        }
        public Persona SavePersona(Persona pPersona)
        {
            PersonaDB personaDB = new PersonaDB();
            return personaDB.SavePersona(pPersona);
        }
        public Persona InsertPersona(Persona pPersona)
        {
            PersonaDB personaDB = new PersonaDB();
            return personaDB.InsertPersona(pPersona);
        }
        public Persona UpdatePersona(Persona pPersona)
        {
            PersonaDB personaDB = new PersonaDB();
            return personaDB.UpdatePersona(pPersona);
        }
        public bool DeletePersona(string pId)
        {
            PersonaDB personaDB = new PersonaDB();
            return personaDB.DeletePersona(pId);
        }
        public string CalculateAge(Persona persona)
        {
            // Crear fechas
            DateTime nacimiento = persona.Nacimiento;
            DateTime hoy = DateTime.Now;

            // Años
            int edadAnos = hoy.Year - nacimiento.Year;
            if (hoy.Month < nacimiento.Month || (hoy.Month == nacimiento.Month &&
            hoy.Day < nacimiento.Day))
                edadAnos--;

            // Meses
            int edadMeses = hoy.Month - nacimiento.Month;
            if (hoy.Day < nacimiento.Day)
                edadMeses--;
            if (edadMeses < 0)
                edadMeses += 12;

            return edadAnos.ToString() + " Años y " + edadMeses.ToString() + " Meses";
        }
        private Persona FullPropPersona(Persona persona)
        {
            persona.Edad = this.CalculateAge(persona);
            return persona;
        }
        private List<Persona> FullPropPersonas(List<Persona> personas)
        {
            List<Persona> listaPersona = new List<Persona>();
            foreach (Persona persona in personas)
            {
                persona.Edad = this.CalculateAge(persona);
                listaPersona.Add(persona);
            }
           
            return listaPersona;
        }
        public static bool ValidadeYear(DateTime date)
        {
            int countDays = (DateTime.Now - date).Days;
            
            bool result = true;
            if (countDays <= 365 )
            {
                result = false;
            }
            return result;
        }
    }
}
