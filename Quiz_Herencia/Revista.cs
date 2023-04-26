using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Herencia
{
    internal class Revista : Material
    {
        private int Numero = 0;
        private int Volumen = 0;
        public Revista(string titulo, string autor, int codigo, int fecha_a, bool estado) : base(titulo, autor, codigo, fecha_a, estado)
        {
        }
        public void setNumero (int numero) { Numero = numero; }
        public int getNumero() { return Numero; }
        public void setVolumen(int volumen) {  Volumen = volumen; }
        public int getVolumen() {  return Volumen; }
        public override void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine("Número: " + getNumero());
            Console.WriteLine("Volumen: " + getVolumen());
        }
    }
}
