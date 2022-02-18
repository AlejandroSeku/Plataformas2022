namespace HolaAña
{
 class Program
 {
     static void Main(String[] args)
     {
         int numero1, numero2, suma, producto;

         Console.WriteLine("Suma y producto en dos números");

         Console.WriteLine("Digite el primer número");
         numero1=int.Parse(Console.ReadLine());

         Console.WriteLine("Digite el segundo número");         
         numero2=int.Parse(Console.ReadLine());

         suma=numero1+numero2;

         Console.WriteLine("La suma es " + suma);

     }
 }   
}
