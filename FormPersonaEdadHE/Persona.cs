using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPersonaEdadHE
{
    public class Persona
    {
        #region Atributos
        private string Nombre;
        private long DocumentoIdentidad;
        private DateTime FechaNacimiento;
        #endregion
        #region Propiedades
        public string p_nombre
        {
            set { Nombre = value; }
            get { return Nombre; }
        }
        public long p_dni
        {
            set { DocumentoIdentidad = value; }
            get { return DocumentoIdentidad; }
        }
        public DateTime p_fechanacimiento
        {
            set { FechaNacimiento = value; }
            get { return FechaNacimiento; }
        }
        #endregion
        #region Constructores
        public Persona() { }
        public Persona(string nombre, long documentoIdentidad, DateTime fechaNacimiento, string p_nombre, long p_dni, DateTime p_fechanacimiento)
        {
            Nombre = nombre;
            DocumentoIdentidad = documentoIdentidad;
            FechaNacimiento = fechaNacimiento;
            this.p_nombre = p_nombre;
            this.p_dni = p_dni;
            this.p_fechanacimiento = p_fechanacimiento;
        }
        #endregion
        #region Metodos
        public int EdadPersona()
        {
            int edad = 0;
            try
            {
                if (FechaNacimiento.Date > DateTime.Today) throw new Exception("La fecha ingresada no es correcta");
                else
                {
                    edad = DateTime.Today.AddTicks(-FechaNacimiento.Ticks).Year - 1;
                    return edad;
                }
            }
            catch (Exception)
            {
                return -1;
            }
            return (int)DocumentoIdentidad;
            #endregion
        }
    }
}
