using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Herencia
{
    internal class Material
    {
        private string Titulo;
        private string Autor;
        private int Codigo;
        private int  Fecha_A;
        private bool Estado;

        public Material(string titulo, string autor, int codigo, int fecha_a, bool estado)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
            this.Fecha_A = fecha_a;
            this.Estado = estado;
        }
        public string getTitulo() { return Titulo; }
        public string getAutor() { return Autor; }
        public int getCodigo() { return Codigo; }
        public int getFecha_A() { return Fecha_A; }
        public void setEstado(bool estado) { Estado = estado; }
        public bool getEstado() { return Estado; }

        public virtual void mostrarInformacion()
        {
            Console.WriteLine("Titulo: " + getTitulo());
            Console.WriteLine("Autor: " + getAutor());
            Console.WriteLine("Codigo: " + getCodigo());
            Console.WriteLine("Año: " + getFecha_A());
            if (getEstado() == true) { Console.WriteLine("Estado: Disponible"); }
            else { Console.WriteLine("Estado: No disponible "); }
        }
    }
}
