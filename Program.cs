// See https://aka.ms/new-console-template for more information
using Clases.Clases;

Console.WriteLine("¡Clases!\n");

var carro1 = new Carro();
//carro1.Marca = "Volvo";
carro1.Anio = 2020;

Console.WriteLine($"{ carro1.NombreComercial } Kilometraje: { carro1.Kilometraje }");

carro1.Acelear();
//carro1.Detener();   

Console.WriteLine($"{ carro1.NombreComercial } Kilometraje: { carro1.Kilometraje }");

Console.WriteLine(carro1.Marca);