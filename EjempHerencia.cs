/*
 * Created by SharpDevelop.
 * User: Arturo
 * Date: 27/03/2014
 * Time: 10:42 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
class Persona
{
 public string Nombre; // Campo de cada objeto Persona que almacena su nombre
 public int Edad; // Campo de cada objeto Persona que almacena su edad
 public string NIF; // Campo de cada objeto Persona que almacena su NIF
void Cumpleaños() // Incrementa en uno de edad del objeto Persona
{
  Edad++;
}
     public Persona (string nombre, int edad, string nif) // Constructor de Persona
	{
      Nombre = nombre;
      Edad = edad;
      NIF = nif;
     }
}
class Trabajador: Persona
{
public int Sueldo; // Campo de cada objeto Trabajador que almacena cuánto gana
        Trabajador(string nombre, int edad, string nif, int sueldo): base(nombre, edad, nif)
{       // Inicializamos cada Trabajador en base al constructor de Persona
       Sueldo = sueldo;
   
       }
public static void Main()
{
   Trabajador p = new Trabajador("Josan", 22, "77588260-Z", 100000);
   Console.WriteLine ("Nombre="+p.Nombre);
   Console.WriteLine ("Edad="+p.Edad);
   Console.WriteLine ("NIF="+p.NIF);
   Console.WriteLine ("Sueldo="+p.Sueldo);
    }
}
