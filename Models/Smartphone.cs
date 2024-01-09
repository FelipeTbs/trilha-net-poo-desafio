namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public Smartphone(string numero, string modelo, string codigoIMEI, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = codigoIMEI;
            Memoria = memoria;
        }

        //public void AdmimMostrarDadosCelular(){
        //    Console.WriteLine($"modelo: {Modelo}, IMEI: {IMEI} e memória: {Memoria}");
        //}

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