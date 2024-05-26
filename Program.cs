/* EJERCICIO CALCULADORA */

// // See https://aka.ms/new-console-template for more information
// using EspacioCalculadora;

// Calculadora calculadora = new Calculadora();
// // Si definiera pips?, no se que dijo el profe, pero si quisiera hacer calculador.Sumar(3).Sumar(3), tengo que definirla como lo que comente en la clase calculadora, asi podria hacer que se llamara a sí misma

// System.Console.WriteLine("----------Calculadora----------");
// string aux;
// int seguirOperando = 1;
// int opcion;
// double numero;
// System.Console.WriteLine("Ingrese el primer numero con el que iniciar la calculadora:");
// aux = Console.ReadLine();
// double.TryParse(aux, out numero);
// calculadora.Sumar(numero);
// while(seguirOperando!=0)
// {
//     System.Console.WriteLine("Ingrese la operacion a realizar:");
//     System.Console.WriteLine("1 - Sumar");
//     System.Console.WriteLine("2 - Restar");
//     System.Console.WriteLine("3 - Multiplicar");
//     System.Console.WriteLine("4 - Dividir");
//     System.Console.WriteLine("5 - Limpiar calculadora");
//     aux = Console.ReadLine();
//     int.TryParse(aux, out opcion);
//     //opcion = Convert.ToInt32(aux); otra forma de pedir que me ingrese el usuario, sin embargo, si no puede guardarlo se rompe el programa, error fatal
//     System.Console.WriteLine("\nIngrese el numero con el que operar:");
//     aux = Console.ReadLine();
//     double.TryParse(aux, out numero);
//     switch(opcion){
//         case 1:
//             calculadora.Sumar(numero);
//             break;
//         case 2:
//             calculadora.Restar(numero);
//             break;
//         case 3:
//             calculadora.Multiplicar(numero);
//             break;
//         case 4:
//             calculadora.Dividir(numero);
//             break;
//         case 5:
//             calculadora.Limpiar();
//             break;
//     }

//     System.Console.WriteLine($"\nResultado: {calculadora.Resultado}");
//     System.Console.WriteLine("\nQuiere seguir operando?(1:si, 0:no):\n");
//     aux = Console.ReadLine();
//     int.TryParse(aux, out seguirOperando);
// }

/* EJERCICIO EMPLEADO */

using System.Security.Cryptography;
using espacioEmpleado;

Empleado[] empleado = new Empleado[3];

Random aleatorio = new Random();

int proximoAJubilacion = 0;

double montoTotal = 0;

string[] Nombres = ["Jose", "Andres", "Maximo"];
string[] Apellidos = ["Rodriguez", "Castillos", "Salome"];
char[] estado = {'c','s'};

for (int i=0; i < empleado.Length; i++)
{
    empleado[i] = new Empleado();
    empleado[i].Nombre = Nombres[aleatorio.Next(0,3)];
    empleado[i].Apellido = Apellidos[aleatorio.Next(0,3)];
    empleado[i].FechaNac = new DateTime(aleatorio.Next(1950, 2023),aleatorio.Next(1,13),aleatorio.Next(1,32));
    empleado[i].EstadoCivil = estado[aleatorio.Next(0,2)];
    empleado[i].FechaIngreso = new DateTime(aleatorio.Next(1950, 2023),aleatorio.Next(1,13),aleatorio.Next(1,32));
    empleado[i].SueldoBasico = (double)aleatorio.Next(1,1000000);
    empleado[i].Cargo = Cargos.Ingeniero;
    if(i>0 && empleado[i].jubilacion()<empleado[proximoAJubilacion].jubilacion())
    {
        proximoAJubilacion = i;
    }
    montoTotal += empleado[i].SueldoBasico + empleado[i].salario();
}

System.Console.WriteLine("El empleado mas proximo a jubilarse es:");
System.Console.WriteLine($"Nombre: {empleado[proximoAJubilacion].Nombre}");
System.Console.WriteLine($"Apellido: {empleado[proximoAJubilacion].Apellido}");
System.Console.WriteLine($"Fecha de nacimiento: {empleado[proximoAJubilacion].FechaNac.ToString("dd-MM-yyyy")}");
System.Console.WriteLine($"Edad: {empleado[proximoAJubilacion].edad()}");
System.Console.WriteLine($"Fecha de ingreso: {empleado[proximoAJubilacion].FechaIngreso.ToString("dd-MM-yyyy")}");
System.Console.WriteLine($"Antiguedad: {empleado[proximoAJubilacion].antiguedad()}");
if(empleado[proximoAJubilacion].EstadoCivil == 'c')
{
    System.Console.WriteLine("Estado Civil: Casado");
}else
{
    System.Console.WriteLine("Estado Civil: Soltero");
}
if(empleado[proximoAJubilacion].jubilacion() == 0)
{
    System.Console.WriteLine("Puede jubilarse");
}else
{
    System.Console.WriteLine($"Le faltan {empleado[proximoAJubilacion].jubilacion()} anios para jubilarse");
}
System.Console.WriteLine($"Sueldo Basico: ${empleado[proximoAJubilacion].SueldoBasico}");
System.Console.WriteLine($"Salario: ${empleado[proximoAJubilacion].salario()}");

System.Console.WriteLine($"\nMonto total en concepto de salarios de todos los empleados: ${montoTotal}");