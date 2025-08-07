using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPropriedades.models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Nome
        {
            //get
            //{
            //    return _nome.ToUpper();
            //}
            get => _nome.ToUpper(); //Body Expressions modo de simplificar o código em uma linha simples
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}";

        //public int Idade { get; set; }
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto.ToUpper()}, Idade: {Idade}");
        }
    }
}