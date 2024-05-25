namespace EspacioCalculadora;
public class Calculadora
{
    private double dato = 0;
    public double Resultado
    {
        get{return dato;}
        //set{dato = value;}

        //Esas lineas son equivalentes a hacer get => dato; y set => dato = value;
    }

    //Si yo uso otro nombre para hacer la propiedad, tengo que vincularla con la variable private, especificando el get y el set retornando
    public void Sumar(double Termino)
    {
        this.dato += Termino;
    }

    // public Calculadora Sumar(double Termino)
    // {
    //     this.dato += Termino;
    //     return this;
    // }

    public void Restar(double Termino)
    {
        this.dato -= Termino;
    }

    public void Multiplicar(double Termino)
    {
        this.dato *= Termino;
    }

    public void Dividir(double Termino)
    {
        this.dato /= Termino;
    }

    public void Limpiar()
    {
        this.dato = 0;
    }
}

