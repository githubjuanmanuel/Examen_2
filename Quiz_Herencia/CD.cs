using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Herencia
{
    internal class CD : Material
    {
        private string Tipo = "";
        public CD(string titulo, string autor, int codigo, int fecha_a, bool estado) : base(titulo, autor, codigo, fecha_a, estado)
        {
        }
        public void setTipo(string tipo) { Tipo = tipo; }
        public string getTipo() {  return Tipo; }
        public override void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine("Tipo: " + getTipo());
        }
    }
}
