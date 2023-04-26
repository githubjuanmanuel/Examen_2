using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Herencia
{
    internal class Docente : Usuario
    {
        private string Tipo_C = "";
        private string Departamento = "";
        private string Facultad = "";
        public Docente(string nombre, string apellido, int documento_i, string correo) : base(nombre, apellido, documento_i, correo)
        {
        }

        public void setTipo_C(string tipo) 
        { 
            Tipo_C = tipo;
        }
        public string getTipo_C() { return Tipo_C; }
        public void setDepartamento(string departamento)
        {
            Departamento = departamento;
        }
        public string getDepartamento() {  return Departamento; }
        public void setFacultad(string facultad)
        {
            Facultad = facultad;
        }
        public string getFacultad() {  return Facultad; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Tipo de contrato: " + getTipo_C());
            Console.WriteLine("Departamento: " + getDocumento_I());
            Console.WriteLine("Facultad: " + getFacultad());
        }
        public void levantarSancion(int pago)
        {
            if (pago == 1000)
            {
                setEstado(true);
                Console.WriteLine("Usuario habilitado");
            }
        }
    }
}
