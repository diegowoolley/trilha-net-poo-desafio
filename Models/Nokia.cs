namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
           nomeApp = "Instalando Aplicativo: Whatsapp";
           Console.WriteLine(nomeApp);
        }
       
    }
}