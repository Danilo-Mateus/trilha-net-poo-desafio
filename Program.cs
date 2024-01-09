using System;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste com Nokia
            Nokia nokia = new Nokia("123456789", "Nokia 8", "IMEI123", "64GB");
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            // Teste com iPhone
            Iphone iphone = new Iphone("987654321", "iPhone 12", "IMEI456", "128GB");
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.ReadLine();
        }
    }
}