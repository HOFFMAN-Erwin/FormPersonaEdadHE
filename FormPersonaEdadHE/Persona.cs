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
    }
}
