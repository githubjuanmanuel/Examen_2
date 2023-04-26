using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Herencia
{
    internal class Administrativo : Usuario
    {
        private string Dependencia = "";
        public Administrativo(string nombre, string apellido, int documento_i, string correo) : base(nombre, apellido, documento_i, correo)
        {
        }
        public void setDependencia(string dependencia)
        {
            Dependencia= dependencia;
        }
        public string getDependencia() { return Dependencia; }
    }
}
