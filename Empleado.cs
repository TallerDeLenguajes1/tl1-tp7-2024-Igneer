namespace espacioEmpleado;

class Empleado
{
    private string nombre = "";
    public string Nombre { get => nombre; set => nombre = value; }

    private string apellido = "";
    public string Apellido { get => apellido; set => apellido = value; }

    private DateTime fechaNac;
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }

    private char civil;
    public char Civil { get => civil; set => civil = value; }

    private DateTime fechaIngreso;
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    private double sueldoBasico;
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }

    private enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    public int antiguedad(){
        int dias;
        DateTime fechaActual = DateTime.Now;
        dias = fechaActual.Subtract(this.fechaIngreso).Days;
        return dias/365;
    }
    public int anios(){
        int dias;
        DateTime fechaActual = DateTime.Now;
        dias = fechaActual.Subtract(this.fechaNac).Days;
        return dias/365;
    }

    public void jubilacion()
    {
        if(anios() < 65)
        {
            System.Console.WriteLine($"Le faltan {65-anios()} anios para jubilarse\n");
        }else
        {
            System.Console.WriteLine($"Ya puede jubilarse\n");
        }
    }
}