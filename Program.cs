using System;

namespace kilometros
{
    class Program
    {
        static void Main(string[] args)
        {
            float distancia,velocidad,tiempo;
            Console.WriteLine("ingrese distancia");
            distancia = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese velocidad");
            velocidad = float.Parse(Console.ReadLine());
            tiempo = distancia/velocidad;
            Console.WriteLine("el tiempo que tardara es de " + tiempo.ToString("0.00") + " horas");

        

        }
    }
}
