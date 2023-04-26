using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Herencia
{
    internal class Estudiante : Usuario
    {
        private string Programa = "";
        public Estudiante(string nombre, string apellido, int documento_i, string correo) : base(nombre, apellido, documento_i, correo)
        {
        }
        public void setPrograma(string programa)
        {
            Programa = programa;
        }
        public string getPrograma() { return Programa; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Programa: " + getPrograma());
        }
    }
}
