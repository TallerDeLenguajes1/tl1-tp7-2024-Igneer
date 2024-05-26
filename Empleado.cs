namespace espacioEmpleado;
enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

class Empleado
{
    private string nombre = "";
    public string Nombre { get => nombre; set => nombre = value; }

    private string apellido = "";
    public string Apellido { get => apellido; set => apellido = value; }

    private DateTime fechaNac;
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }

    private char estadoCivil;
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }

    private DateTime fechaIngreso;
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    private double sueldoBasico;
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }

    private Cargos cargo;
    public Cargos Cargo { get => cargo; set => cargo = value; }
    public int antiguedad(){
        int dias;
        DateTime fechaActual = DateTime.Now;
        dias = fechaActual.Subtract(fechaIngreso).Days;
        return dias/365;
    }
    public int edad(){
        int dias;
        DateTime fechaActual = DateTime.Now;
        dias = fechaActual.Subtract(fechaNac).Days;
        return dias/365;
    }

    public int jubilacion()
    {
        if(edad() < 65)
        {
            return(65-edad());
        }else
        {
           return 0;
        }
    }

    public double salario()
    {
        double adicional;
        if(antiguedad()<20)
        {
            adicional = sueldoBasico*((double)antiguedad()/100); 
        }else
        {
            adicional = sueldoBasico*0.25;
        }

        if(cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
        {
            adicional *= 1.50; 
        }

        if(estadoCivil == 'c')
        {
            adicional += 150000;
        }

        return(sueldoBasico + adicional);
    }
}