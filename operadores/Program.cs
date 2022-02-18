using System;
namespace operadores
{
 class Program
 {
     static void Main(String[] args)
    {
         float area, lado, radio;
         string opcion = "";

         while (opcion != "Circulo" || opcion != "Triangulo" || opcion != "Cuadrado")
           {
              Console.WriteLine("Ingrese la figura que desea encontrar el area (Circulo, Triangulo, Cuadrado)");
              opcion = Console.ReadLine();

                if (opcion=="Cuadrado")
                {
                    
                    Console.WriteLine("El valor del lado");
                    lado= float.Parse(Console.ReadLine());
                    lado = lado * lado;
                    Console.WriteLine("El area es " + lado);
                 }
                 else if(opcion=="Triangulo"){

                    Console.WriteLine("El valor del lado");
                    lado= float.Parse(Console.ReadLine());
                    lado = lado * lado * lado;
                    Console.WriteLine("El area es " + lado);
                }
                else if (opcion=="Circulo"){
                    Console.WriteLine("El valor del radio");
                    radio= float.Parse(Console.ReadLine());
                    radio = radio *Math.PI;
                    Console.WriteLine("El area es " + radio);
                }
                
            }

        }
        
 }
}