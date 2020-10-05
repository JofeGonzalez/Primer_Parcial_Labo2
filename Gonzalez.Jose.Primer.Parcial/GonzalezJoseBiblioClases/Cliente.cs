using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GonzalezJoseBiblioClases
{
    public class Cliente:Persona
    {
        public string direccion { get; set; }


        public Cliente(string nombre, string apellido, int dni, string direccion) : base(nombre, apellido, dni)
        {
            this.direccion = direccion;
        }

        public void SetDireccion(string direccion)
        {
            this.direccion = direccion;
        }
        public string GetDireccion()
        {
            return direccion;
        }
    }
}
