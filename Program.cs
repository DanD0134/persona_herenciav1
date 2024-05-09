using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{

    class Persona //clase padre
    {
        //declaracion de todas las variables que se usaran en el programa y en los hijos

        public string Nombre { get; set; }
        public string Fecha_Nac { get; set; }
       

        public string Edad { get; set; }
        //Constructor
        /*public Persona(string nombre, string fecha_nac, string carrera_puesto, string edad, int dni_mat, int sueldo)
        {
            Nombre = nombre;
            Fecha_Nac = fecha_nac;
            Carrera_Puesto = carrera_puesto;
            Edad = edad;
            DNI_Mat = dni_mat;
            Sueldo = sueldo;
        }*/
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
        //aqui va el constructor para cargar datos en las cajas de memoria
        //nombre, edad, fecha de nacimiento(es un tipo cadena!!!!! string)
    }

    class Alumno : Persona //clase hija alumno
    {
        public string Carrera { get; set; }
        public int Matricula { get; set; }

        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
    }
    class Empleado : Persona //clase hija
    {
        public int DNI { get; set; }
        public int Sueldo { get; set; }
        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
    }

    class Docente : Persona //clase Hija
    {
        public int Matricula { get; set; }
        public int Sueldo { get; set; }
        //variables
        //atributos
        //metodos
        //colocar todos los comentarios necesarios para exlicar
        //el funcinamiento de su código
    }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
