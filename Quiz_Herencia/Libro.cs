using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Herencia
{
    internal class Libro : Material
    {
        private string Editorial = "";
        public Libro(string titulo, string autor, int codigo, int fecha_a, bool estado) : base(titulo, autor, codigo, fecha_a, estado)
        {
        }
        public void setEditorial(string editorial)
        {
            Editorial = editorial;
        }
        public string getEditorial() { return Editorial; }

        public override void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine("Editorial: " + getEditorial());
        }
    }
}
