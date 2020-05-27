using System;

namespace _AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celulares iphone = new Celulares();
            iphone.cor = "Branco";
            iphone.modelo = "Iphone 5";
            iphone.tamanho = 9;
            iphone.ligado= true;
            iphone.envioMensagem = "Mensagem: Bom dia, como você está?";
            iphone.opçãoDesligar = "Executando: Desligar o celular";
            iphone.inválido = "Opção Inválida";
            iphone.ligação = "Executando: Ligando para Pedro";

            Console.WriteLine(iphone.FazerLigação());
            Console.WriteLine(iphone.EnviarMensagem());
            Console.WriteLine(iphone.Desligar());
        }
    }
}
