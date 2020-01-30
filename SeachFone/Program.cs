using System;

namespace SeachFone {
    class MainClass {
        public static void Main(string[] args) {
            string dados = "O numero de celular da Ana: (95) 99167-8545";
            RegexFactory factory = new RegexFactory();
            var numeros = factory.GetResult(dados);
            numeros.ForEach(Console.WriteLine);
        }
    }
}
