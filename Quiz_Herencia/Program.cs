using Quiz_Herencia;

internal class Program
{
    private static void Main(string[] args)
    {
        int respuesta = 0;
        List<Usuario> Usuarios = new List<Usuario>();
        List<Material> Materiales = new List<Material>();

        Estudiante estudiante1 = new Estudiante("Juan", "Perez", 12, "Correo@Correo.com");
        estudiante1.setPrograma("Sistemas");
        Usuarios.Add(estudiante1);

        Estudiante estudiante2 = new Estudiante("Pedro", "Marín", 21, "Correo2@Correo2.com");
        estudiante2.setPrograma("Arquitectura");
        Usuarios.Add(estudiante2);

        Docente docente = new Docente("Mario", "Bros", 13, "Correo3@Correo3.com");
        docente.setFacultad("Ingenieria");
        docente.setDepartamento("Sistemas");
        docente.setTipo_C("Catedra");
        Usuarios.Add(docente);

        Administrativo admin = new Administrativo("Maria", "Cruz", 31, "Correo4@Correo4.com");
        admin.setDependencia("Bienestar");
        Usuarios.Add(admin);

        Libro libro = new Libro("Narnia", "C.S lewis", 1, 1900, true);
        libro.setEditorial("Vida");
        Materiales.Add(libro);


        Libro libro2 = new Libro("Narnia 2", "C.S lewis", 2, 1902, true);
        libro2.setEditorial("Vida");
        Materiales.Add(libro2);

        Libro libro3 = new Libro("Algoritmos", "Luis Joyanes", 3, 1980, true);
        libro3.setEditorial("Logic pro");
        Materiales.Add(libro3);

        Libro libro4 = new Libro("Algoritmos 2", "Luis Joyanes", 4, 1981, true);
        libro3.setEditorial("Logic pro");
        Materiales.Add(libro4);

        Libro libro5 = new Libro("Algoritmos 3", "Luis Joyanes", 5, 1982, true);
        libro3.setEditorial("Logic pro");
        Materiales.Add(libro5);

        Libro libro6 = new Libro("Algoritmos 4", "Luis Joyanes", 6, 1983, true);
        libro3.setEditorial("Logic pro");
        Materiales.Add(libro6);

        Libro libro7 = new Libro("Algoritmos 5", "Luis Joyanes", 7, 1984, true);
        libro3.setEditorial("Logic pro");
        Materiales.Add(libro7);

        Revista revista = new Revista("Semana", "Desconocido", 8, 2000, true);
        revista.setNumero(120);
        revista.setVolumen(2);
        Materiales.Add(revista);

        Revista revista2 = new Revista("Semana", "Desconocido", 9, 2000, true);
        revista.setNumero(120);
        revista.setVolumen(2);
        Materiales.Add(revista2);

        Revista revista3 = new Revista("Semana", "Desconocido", 10, 2000, true);
        revista.setNumero(120);
        revista.setVolumen(2);
        Materiales.Add(revista3);

        CD cd = new CD("Algebra", "Valcur", 11, 2020, true);
        cd.setTipo("Libro digital");
        Materiales.Add(cd);


        Console.WriteLine("***Bienvenido***");

        
        while (respuesta != 4)
        {
            Console.WriteLine("¿Deseas?\n 1 Ver los usuarios registrados\n 2 Ver los materiales\n 3 Sancionar un usuario\n 4 Salir");
            Console.WriteLine("***************************");
            respuesta = int.Parse(Console.ReadLine());

            switch(respuesta)
            {
                case 1:
                    foreach (Usuario usuario in Usuarios)
                    {
                        usuario.MostrarInformacion();
                        Console.WriteLine("-----------------------------------------------------------------");
                    }
                    break;
                case 2:
                    foreach (Material material in Materiales)
                    {
                        material.mostrarInformacion();
                        Console.WriteLine("-----------------------------------------------------------------");
                    }
                    break;
                case 3:
                    int documento = 0;
                    Console.Write("Ingresa el documento de identidad del usuario: ");
                    documento = int.Parse(Console.ReadLine());
                    Console.WriteLine("***************************");
                    foreach (Usuario usuario in Usuarios)
                    {
                        if (usuario.getDocumento_I() == documento)
                        {
                            usuario.setEstado(false);
                            usuario.MostrarInformacion();
                            Console.WriteLine("***************************");
                        }
                        
                    }
                    break;
                    case 4:
                    break;
            }

        }

        
    }
}