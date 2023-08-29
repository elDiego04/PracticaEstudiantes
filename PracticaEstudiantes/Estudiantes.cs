using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;



class Estudiantes
{
    public string nombre;
    public string apellido;
    public double nota1;
    public double nota2;
    public double nota3;
    public string programa;
    public int edad;

    public Estudiantes()
    {
        this.nombre = "Ninguno";
        this.apellido = "Ninguno";
        this.nota1 = 0.0;
        this.nota2 = 0.0;
        this.nota3 = 0.0;
        this.programa = "Sistemas";
        this.edad = 17;

    }

    public Estudiantes(string nombre, string apellido, double nota1, double nota2, double nota3, string programa,
        int edad)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.nota1 = nota1;
        this.nota2 = nota2;
        this.nota3 = nota3;
        this.programa = programa;
        this.edad = edad;

    }

    public Estudiantes(string nombre, string apellido, double nota1, double nota2, double nota3)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.nota1 = nota1;
        this.nota2 = nota2;
        this.nota3 = nota3;
        this.programa = "Sistemas";
        this.edad = 17;

    }

    public Estudiantes(string nombre, string apellido)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        Write("\nIngrese nota 1: ");
        this.nota1 = Convert.ToDouble(nota1);
        Write("\nIngrese nota 2: ");
        this.nota2 = Convert.ToDouble(nota1);
        Write("\nIngrese nota 3: ");
        this.nota3 = Convert.ToDouble(nota1);
        Write("\nIngrese programa: ");
        this.programa = ReadLine();
        Write("\nIngrese nota 1: ");
        this.edad = Convert.ToInt32(edad);

    }

    public string Saludar()
    {
        int hora = DateTime.Now.Hour;
        if (this.nombre.Equals("Ninguno")) this.nombre = "";
        if (this.apellido.Equals("Ninguno")) this.apellido = "";
        if (hora > 0 && hora < 12)
            return "Buenos días " + this.nombre + " " + this.apellido + " estudiante de " + this.programa;
        else if (hora >= 12 && hora < 18)
            return "Buenas tardes" + this.nombre + " " + this.apellido + " estudiante de " + this.programa;
        return "Buenas noches " + this.nombre + " " + this.apellido + " estudiante de " + this.programa;

    }

    public double Definitiva()
    {
        return Math.Round((this.nota1 + this.nota2 + this.nota3) / 3, 2);
    }

    public int Clasificar()
    {
        double def = this.Definitiva();
        if (def <= 2.0)
            return 1;
        else if (def <= 4.0)
            return 2;
        return 3;
    }

    public string Citar()
    {
        if (this.Clasificar() == 1 && this.edad < 18 && this.programa.Equals("Sistemas"))
            return "DEBE CITARSE AL ACUDIENTE ";
        return "NO ES NECESARIO CITARSE AL ACUDIENTE";

    }

    public void Informe(string mensaje)
    {
        WriteLine("\n======================================================");
        BackgroundColor = ConsoleColor.DarkBlue;
        WriteLine($"       --> Información {mensaje}  <--             ");
        BackgroundColor = ConsoleColor.Black;
        WriteLine("======================================================");
        WriteLine(this.Saludar());
        if (!this.nombre.Equals(""))
        {
            WriteLine($"Edad Estudiante: {this.edad}");
            WriteLine(
                $"Definitiva     : {this.Definitiva():n} Nota1: {this.nota1:n1} Nota2: {this.nota2:n1} Nota3: {this.nota3:n1}");
            WriteLine($"Clasificación  : {this.Clasificar()}");
            WriteLine(this.Citar());
        }

    }
}

