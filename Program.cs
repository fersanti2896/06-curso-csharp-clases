// See https://aka.ms/new-console-template for more information
using Clases.Clases;

Console.WriteLine("Hello, World!");

Persona ConstruirPersona(string nombre, string apellido, DateTime fechaNac) {
    var persona = new Persona();
    persona._nombre = nombre;
    persona._apellido = apellido;
    persona._fechaNacimiento = fechaNac;

    return persona;
}

Console.WriteLine(ConstruirPersona("Fer", "Santi", new DateTime(1996, 12, 16)));