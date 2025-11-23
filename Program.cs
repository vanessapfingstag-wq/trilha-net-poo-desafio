using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone - Feito!

class Program
{
    static void Main(string[] args)
    {
        // Teste com Nokia
        Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia Tijolão", imei: "000111222", memoria: 64);

        Console.WriteLine("### Testando Nokia ###");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Teste com iPhone
        Smartphone iphone = new Iphone(numero: "987654", modelo: "iPhone 15 Pro Max", imei: "999888777", memoria: 256);

        Console.WriteLine("### Testando iPhone ###");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}


