using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



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
        Informe();
    }

    public Estudiantes(string nombre, string apellido, double nota1, double nota2, double nota3, string programa, int edad)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.nota1 = nota1;
        this.nota2 = nota2;
        this.nota3 = nota3;
        this.programa = programa;
        this.edad = edad;
        Informe();
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
        Informe();
    }


    public string Saludar()
    {
        TimeSpan horaActual = DateTime.Now.TimeOfDay;
        if (horaActual < TimeSpan.FromHours(12))
        {
            return $"Buenos dias {nombre} {apellido}, ¡Bienvenido al programa de {programa}!";
        }
        else if (horaActual < TimeSpan.FromHours(18))
        {
            return $"Buenos tardes {nombre} {apellido}, ¡Bienvenido al programa de {programa}!";
        }
        else
        {
            return $"Buenos noches {nombre} {apellido}, ¡Bienvenido al programa de {programa}!";
        }

    }
    public double Definitiva()
    {
        return (this.nota1 + this.nota2 + this.nota3) / 3;
    }
    public int Clasificar()
    {
        if (this.Definitiva() <= 2.0) { return 1; }
        else if (this.Definitiva() <= 4.0) { return 2; }
        else { return 3; }

    }
    public string Citar()
    {
        if (this.Clasificar() == 1 && this.edad < 18 && this.programa == "Sistemas") { return "DEBE CITARSE AL ACUDIENTE "; }
        else { return "NO ES NECESARIO CITARSE AL ACUDIENTE"; }

    }

    public void Informe()
    {
        string mensajeSaludo = Saludar();
        double definitiva = Math.Round(Definitiva(), 2);
        int clasificacion = Clasificar();
        string mensajeCita = Citar();

        Console.WriteLine(mensajeSaludo);
        Console.WriteLine($"Definitiva: {definitiva}");
        Console.WriteLine($"Clasificación: {clasificacion}");
        Console.WriteLine($"Cita: {mensajeCita}");
        Console.WriteLine("NOTAS: ");
        Console.WriteLine($"NOTA 1: {nota1}");
        Console.WriteLine($"NOTA 2: {nota2}");
        Console.WriteLine($"NOTA 3: {nota3}");
        Console.WriteLine($"EDAD: {edad}");
    }
}


