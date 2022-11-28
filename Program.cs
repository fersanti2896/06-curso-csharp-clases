// See https://aka.ms/new-console-template for more information
using Clases.Clases;
using Clases.Struct;

Console.WriteLine("¡Clases!\n");

var carro1 = new Carro();
//carro1.Marca = "Volvo";
carro1.Anio = 2020;

Console.WriteLine($"{ carro1.NombreComercial } Kilometraje: { carro1.Kilometraje }");

carro1.Acelear();
//carro1.Detener();   

Console.WriteLine($"{ carro1.NombreComercial } Kilometraje: { carro1.Kilometraje }");
Console.WriteLine(carro1.Marca);

var calculadora = new Calculadora();
var resultadoDT = calculadora.CalcularDuploTriplo(5);

/* Ejemplo 1: Sin deconstructor */
var valor = resultadoDT.Valor;
var duplo = resultadoDT.Duplo;
var triplo = resultadoDT.Triplo;    

Console.WriteLine($"El valor es: { valor }");
Console.WriteLine($"El duplo es: { duplo }");
Console.WriteLine($"El triplo es: { triplo }");

/* Ejemplo 2: Con deconstructor */
int valor2, duplo2, triplo2;
resultadoDT.Deconstructor(out valor2, out duplo2, out triplo2);

Console.WriteLine($"El valor es: { valor2 }");
Console.WriteLine($"El duplo es: { duplo2 }");
Console.WriteLine($"El triplo es: { triplo2 }");

/* Miembros estáticos */
var carroA = new Carro();
var carroB = new Carro();
var carroC = new Carro();
var carroD = new Carro();

Console.WriteLine($"Han sido instanciados: { Carro.ConteoInstancia }");

/* Usando método de extensión */
var msg = @"Esto es un mensaje 

ATTE. Fer Santi";

var cantidadMsg = msg.ContarPalabras();
Console.WriteLine($"Cantidad de palabras { cantidadMsg } ");

/* Sin usar método de extensión */
var cantidadMsg2 = Extensiones.ContarPalabras(msg);
Console.WriteLine($"Cantidad de palabras { cantidadMsg2 } ");

/* TIPOS ANÓNIMOS */

/* Clase normal */
var coche = new Carro() { Marca = "Yoyota", Anio = 2022 };

/* Tipo anónimo (clase sin nombre) */
var persona = new { Nombre = "Marisol", Apellido = "Contreras", Edad = 25 };
Console.WriteLine($"Persona { persona }");

/* Agregando propiedades o inferiendo nombres de propiedades */
var duenio = "Fer Santi";
var cochePersonalizado = new { coche.Marca, coche.Anio, duenio };

Console.WriteLine($"Carro anónimo: { cochePersonalizado }");

/* Mutación no destructiva */
var personaMutada = persona with { Apellido = "Contreras de Nicolás" };
Console.WriteLine($"{ personaMutada }");

/* Struct: Tipo de valor */
var puntoA = new Punto(10, 5);