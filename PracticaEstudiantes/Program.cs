using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Estudiantes estudiante1 = new Estudiantes();
        estudiante1.Informe("Estudiante #1");
        Estudiantes estudiante2 = new Estudiantes("Jairo", "Ramirez", 5.0, 4.0, 3.0, "Electrónica", 46);
        estudiante2.Informe("Estudiante #2");
        Estudiantes estudiante3 = new Estudiantes("Alejandra", "García", 2.5, 2.2, 0.5);
        estudiante3.Informe("Estudiante #3");
        Estudiantes estudiante4 = new Estudiantes("Juan", "Pérez");
        estudiante4.Informe("Estudiante #4");
        Estudiantes estudiante5 = new Estudiantes("Hernan", "Marin", 1.0, 2.8, 3.0, "Sistemas", 15);
        estudiante5.Informe("Estudiante #5");


    }
}

