using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

class Program
{
    static void Main(String[] args)
    {
        Estudiantes estudiante1 = new Estudiantes();

        Estudiantes estudiante2 = new Estudiantes("Diego", "Salazar", 4.5, 3.0, 5.0, "Sistemas", 19);

        Estudiantes estudiante3 = new Estudiantes("Gladys", "Castrillon", 1.0, 2.0, 3.0);
    }
}

