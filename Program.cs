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

using espacioEmpleado;

Empleado empleado = new Empleado();

empleado.FechaNac = new DateTime(2009,02,1);
empleado.FechaIngreso = new DateTime(2009,02,01);
empleado.SueldoBasico = 650000;
empleado.EstadoCivil = 'c';
empleado.Cargo = Cargos.Especialista;

System.Console.WriteLine(empleado.FechaNac.ToString("dd-MM-yyyy"));
System.Console.WriteLine(empleado.edad());
System.Console.WriteLine(empleado.antiguedad());
empleado.jubilacion();

System.Console.WriteLine(empleado.salario());