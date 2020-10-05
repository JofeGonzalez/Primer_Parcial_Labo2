using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GonzalezJoseBiblioClases
{
    public class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }

        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = ValidarNombreYApellido(nombre);
        }

        public string GetNombre()
        {
            return nombre;
        }
        public void SetApellido(string apellido)
        {
            this.apellido = ValidarNombreYApellido(apellido);
        }

        public string GetApellido()
        {
            return apellido;
        }
        public void SetDni(int dni)
        {
            this.dni = dni;
        }

        public int GetDni()
        {
            return dni;
        }

        private string ValidarNombreYApellido(string validar)
        {
            string validado = null;
            for (int i = 0; i < validar.Length; i++)
            {
                if((validar[i] > 'a' && validar[i] < 'z') || (validar[i] > 'A' && validar[i] < 'Z'))
                {
                    validado = validar;
                } else
                {
                    validado = "Datos inválidos";
                }
            }
            return validado;
        }
    }
}
