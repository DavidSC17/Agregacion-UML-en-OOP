// David Sanchez Castañeda
using System;
public class Departamento
{
    public string Nombre {get; set;}
    public void MostrarProfesor(Profesor p)
    {
        Console.WriteLine("Profesor:" + p.Nombre);
        Console.WriteLine("Departamento:" + Nombre);
    }
}
public class Profesor
{
     public string Nombre {get; set;} 
}
public class Program
{
    static void Main()
    {
        //la creacion del objeto profesor
        Profesor Profe=new Profesor ();
        Profe.Nombre="Vera";
        
        //la creacion del objeto departamento
        Departamento POO=new Departamento();
        POO.Nombre="Programacion Orientada a Objetos";
        
        POO.MostrarProfesor(Profe);
    }
}
