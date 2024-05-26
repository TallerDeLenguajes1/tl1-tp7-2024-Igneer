namespace Empleado;

class Empleado
{
    private string nombre = "";
    public string Nombre { get => nombre; set => nombre = value; }

    private string apellido = "";
    public string Apellido { get => apellido; set => apellido = value; }

    private DateTime fechaNac;
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }

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
    public int antiguedad(DateTime Ingreso){
        int dias;
        DateTime fechaActual = DateTime.Now;
        dias = fechaActual.Subtract(Ingreso).Days;
        return dias/365;
    }
    public int anios(DateTime Nacimiento){
        int dias;
        DateTime fechaActual = DateTime.Now;
        dias = fechaActual.Subtract(Nacimiento).Days;
        return dias/365;
    }

    public void jubilacion(int edad)
    {
        
    }

}