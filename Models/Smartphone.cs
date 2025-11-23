namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Implementar as propriedades faltantes de acordo com o diagrama - Feito!

        // Propriedades do diagrama
        public string Numero { get; set; }        
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }

 
        // Passar os parâmetros do construtor para as propriedades - Feito!

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}