using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GonzalezJoseBiblioClases
{
    public class Vendedor:Persona
    {
        public string turno { get; set; }
        private double sueldo { get; set; }

        public Vendedor(string nombre, string apellido, int dni, string turno, double sueldo):base(nombre,apellido,dni)
        {
            this.turno = turno;
            this.sueldo = sueldo;
        }
        public void SetTurno(string turno)
        {
            this.turno = turno;
        }

        public string GetTurno()
        {
            return turno;
        }
        public void SetSueldo(double sueldo)
        {
            this.sueldo = sueldo;
        }

        public double GetSueldo()
        {
            return sueldo;
        }
    }
}
