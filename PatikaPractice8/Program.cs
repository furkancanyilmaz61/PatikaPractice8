using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir limit değeri giriniz:");
        int limit = int.Parse(Console.ReadLine());

        Console.WriteLine("While döngüsü ile:");
        int sayacWhile = 0;
        while (sayacWhile <= limit)
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayacWhile++;
        }

        Console.WriteLine(); // Boşluk bırakmak için

        Console.WriteLine("Do-While döngüsü ile:");
        int sayacDoWhile = 0;
        do
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayacDoWhile++;
        } while (sayacDoWhile <= limit);

        // Yorum: While ve do-while döngüleri arasındaki fark
        // While döngüsünde koşul başta kontrol edilir. Eğer koşul sağlanmıyorsa döngü hiç çalışmaz.
        // Do-while döngüsünde ise döngü en az bir kez çalışır, çünkü koşul sonda kontrol edilir.
    }
}
