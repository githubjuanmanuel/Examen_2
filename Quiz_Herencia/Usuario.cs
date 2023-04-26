using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Herencia
{
    internal class Usuario
    {

        private string Nombre;
        private string Apellido;
        private int Documento_I;
        private string Correo;
        private bool Estado = true;
        public Usuario(string nombre, string apellido, int documento_i, string correo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Documento_I = documento_i;
            this.Correo = correo;
        }

        public string getNombre() { return Nombre; }  
        public string getApellido() {  return Apellido; }   
        public int getDocumento_I() {  return Documento_I; }
        public string getCorreo() {  return Correo; }
        public void setEstado(bool estado) {  Estado = estado; }
        public bool getEstado() { return Estado; }

        public void aplicarSancion()
        {
            Estado = false;
            Console.WriteLine("Usuario sancionado");
        }
        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Nombe: " + getNombre());
            Console.WriteLine("Apellido: " + getApellido());
            Console.WriteLine("Documento: " + getDocumento_I());
            Console.WriteLine("Correo: " + getCorreo());
            if (getEstado() == true) { Console.WriteLine("Estado: habilitado"); }
            else { Console.WriteLine("Estado: sancionado"); }
        }
       

      
       

    }
}
