using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;



class Estudiantes
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Nota3 { get; set; }
    public string Programa { get; set; }
    public int Edad { get; set; }

    public Estudiantes()
    {
        this.Nombre = "Ninguno";
        this.Apellido = "Ninguno";
        this.Nota1 = 0.0;
        this.Nota2 = 0.0;
        this.Nota3 = 0.0;
        this.Programa = "Sistemas";
        this.Edad = 17;

    }

    public Estudiantes(string nombre, string apellido, double nota1, double nota2, double nota3, string programa,
        int edad)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Nota1 = nota1;
        this.Nota2 = nota2;
        this.Nota3 = nota3;
        this.Programa = programa;
        this.Edad = edad;

    }

    public Estudiantes(string nombre, string apellido, double nota1, double nota2, double nota3)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Nota1 = nota1;
        this.Nota2 = nota2;
        this.Nota3 = nota3;
        this.Programa = "Sistemas";
        this.Edad = 17;

    }

    public Estudiantes(string nombre, string apellido)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        Write("\nIngrese nota 1: ");
        this.Nota1 = Convert.ToDouble(Nota1);
        Write("\nIngrese nota 2: ");
        this.Nota2 = Convert.ToDouble(Nota1);
        Write("\nIngrese nota 3: ");
        this.Nota3 = Convert.ToDouble(Nota1);
        Write("\nIngrese programa: ");
        this.Programa = ReadLine();
        Write("\nIngrese nota 1: ");
        this.Edad = Convert.ToInt32(Edad);

    }

    public string Saludar()
    {
        int hora = DateTime.Now.Hour;
        if (this.Nombre.Equals("Ninguno")) this.Nombre = "";
        if (this.Apellido.Equals("Ninguno")) this.Apellido = "";
        if (hora > 0 && hora < 12)
            return "Buenos días " + this.Nombre + " " + this.Apellido + " estudiante de " + this.Programa;
        else if (hora >= 12 && hora < 18)
            return "Buenas tardes" + this.Nombre + " " + this.Apellido + " estudiante de " + this.Programa;
        return "Buenas noches " + this.Nombre + " " + this.Apellido + " estudiante de " + this.Programa;

    }

    public double Definitiva()
    {
        return Math.Round((this.Nota1 + this.Nota2 + this.Nota3) / 3, 2);
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
        if (this.Clasificar() == 1 && this.Edad < 18 && this.Programa.Equals("Sistemas"))
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
        if (!this.Nombre.Equals(""))
        {
            WriteLine($"Edad Estudiante: {this.Edad}");
            WriteLine(
                $"Definitiva     : {this.Definitiva():n} Nota1: {this.Nota1:n1} Nota2: {this.Nota2:n1} Nota3: {this.Nota3:n1}");
            WriteLine($"Clasificación  : {this.Clasificar()}");
            WriteLine(this.Citar());
        }

    }
}

