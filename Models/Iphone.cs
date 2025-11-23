namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone" - Feito!
    public class Iphone : Smartphone
    {
        // Construtor - Feito!

        public Iphone(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
        {
        }
        // Sobrescrever o método "InstalarAplicativo" - Feito!

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"iNSTALANDO {nomeApp} no Iphone...");
        }
    }

}