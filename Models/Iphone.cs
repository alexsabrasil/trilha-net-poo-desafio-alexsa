namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, string capacidade) : base(numero, modelo, imei, capacidade)
        {
            // TODO: Atribuir o valor da propriedade Capacidade
            Capacidade = capacidade;
        }

        // TODO: Adicionar a propriedade Capacidade à classe Iphone
        public string Capacidade { get; set; }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone.");
        }
    }
}



