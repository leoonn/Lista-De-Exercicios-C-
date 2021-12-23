using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Exercicios.Entities.AbstractExercise;
using Exercicios.Entities.ExerciseProducts;


namespace Exercises
{
    class Program
    {
        static void Main()
        {
            new Exercise().Exercise7();
        }
    }
    class Exercise
    {
        public void Exercise1() //Trocar a ou A por & em um frase sem utilizar o replace
        {
            Console.WriteLine("Digite uma frase");
            string phrase = Console.ReadLine();
            int countphrase = phrase.Length;
            int count = 0;
            if (phrase.Trim().Length > 0)
            {
                var builder = new StringBuilder(phrase);
                while (count < countphrase)
                {
                    if (builder[count] == 'a' || builder[count] == 'A')
                    {
                        builder[count] = '&';
                    }
                    count++;
                }
                phrase = builder.ToString();
            }
            Console.WriteLine(phrase);
        }

        public void Exercise2() //Gravar em um arquivo Os dados do usuario
        {
            Console.WriteLine("Digite seu nome: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Digite seu Cpf: ");
            string Cpf = Console.ReadLine();
            Console.WriteLine("Digite seu Rg: ");
            string Rg = Console.ReadLine();
            Console.WriteLine("Digite seu Email: ");
            string Email = Console.ReadLine();

            string path = "UserData.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            StreamWriter writer = new StreamWriter(path);

            writer.WriteLine("Name: " + Name);
            writer.WriteLine("Cpf: " + Cpf);
            writer.WriteLine("Rg: " + Rg);
            writer.WriteLine("Email: " + Email);

            writer.Close();



            String[] Lines = File.ReadAllLines(path);

            foreach (string item in Lines)
            {
                Console.WriteLine(item);
            }

        }

        public void Exercise3() //numero que aparece mais vezes e se for igual a outro numero mostrar o ultimo
        {
            Console.WriteLine("Digite uma sequencia numerica: ");
            double sequence = double.Parse(Console.ReadLine());
            List<List<char>> numbers = new List<List<char>>();

            for (int i = 0; i < 10; i++)
            {
                numbers.Add(new List<char>());
                for (int j = 0; j < sequence.ToString().Length; j++)
                {
                    if (sequence.ToString()[j] == char.Parse(i.ToString()))
                    {
                        numbers[i].Add(sequence.ToString()[j]);
                    }
                }
            }
            double min = double.MinValue;
            int whatList = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (min <= numbers[i].Count)
                {
                    min = numbers[i].Count;
                    whatList = i;
                }
            }
            Console.Write("O numero que aparece mais vezes é: " + whatList);
        }
        public void Exercise4() //Lanchonete poderia ter sido feito com classes mas um dia eu melhoro
        {
            List<Dictionary<string, int>> pedido = new List<Dictionary<string, int>>();
            Dictionary<string, int> OptionsSelected = new Dictionary<string, int>();
            Dictionary<string, int> options = new Dictionary<string, int>();
            string[] foods = { "Carne", "Frango", "batata", "refri", "salada", "maionese" };
            int[] foodsPrice = { 20, 16, 6, 4, 2, 1 };

            for (int i = 0; i < foods.Length; i++)
            {
                options.Add(foods[i], foodsPrice[i]);
            }

            Console.WriteLine("Seja Bem Vindo Ao Miranha Burguer!");
            string option = "";

            do
            {
                int quantidade = 1;
                Console.WriteLine("Selecione as opções para fazer seu pedido");
                for (int i = 0; i < options.Keys.Count; i++)
                {
                    Console.WriteLine(i + "-" + options.ElementAt(i).Key + " R$" + options.ElementAt(i).Value);
                }
                Console.WriteLine("P" + "-Pagamento");
                option = Console.ReadLine().ToLower();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Selecione a quantidade");
                        Console.WriteLine("para voltar a tela de seleção de seu pedido digite 0");
                        quantidade = int.Parse(Console.ReadLine());
                        if (quantidade == 0)
                        {
                            break;
                        }
                        for (int i = 0; i < quantidade; i++)
                        {

                            if (OptionsSelected != null)
                            {
                                Random rnd = new Random();
                                int rand = rnd.Next(1, 9999);
                                OptionsSelected.Add(options.ElementAt(0).Key + "[Cod: " + rand + "]", options.ElementAt(0).Value);
                                pedido.Add(OptionsSelected);
                            }
                            else
                            {
                                OptionsSelected.Add(options.ElementAt(0).Key, options.ElementAt(0).Value);
                                pedido.Add(OptionsSelected);
                            }
                        }
                        Console.WriteLine(quantidade + " " + options.ElementAt(0).Key + " adicionados ao seu pedido");
                        break;
                    case "1":
                        Console.WriteLine("Selecione a quantidade");
                        Console.WriteLine("para voltar a tela de seleção de seu pedido digite 0");
                        quantidade = int.Parse(Console.ReadLine());
                        if (quantidade == 0)
                        {
                            break;
                        }
                        for (int i = 0; i < quantidade; i++)
                        {

                            if (OptionsSelected != null)
                            {
                                Random rnd = new Random();
                                int rand = rnd.Next(1, 9999);
                                OptionsSelected.Add(options.ElementAt(1).Key + "[Cod: " + rand + "]", options.ElementAt(1).Value);
                                pedido.Add(OptionsSelected);
                            }
                            else
                            {
                                OptionsSelected.Add(options.ElementAt(1).Key, options.ElementAt(1).Value);
                                pedido.Add(OptionsSelected);
                            }
                        }
                        Console.WriteLine(quantidade + " " + options.ElementAt(1).Key + " adicionados ao seu pedido");
                        break;
                    case "2":
                        Console.WriteLine("Selecione a quantidade");
                        Console.WriteLine("para voltar a tela de seleção de seu pedido digite 0");
                        quantidade = int.Parse(Console.ReadLine());
                        if (quantidade == 0)
                        {
                            break;
                        }
                        for (int i = 0; i < quantidade; i++)
                        {

                            if (OptionsSelected != null)
                            {
                                Random rnd = new Random();
                                int rand = rnd.Next(1, 9999);
                                OptionsSelected.Add(options.ElementAt(2).Key + "[Cod: " + rand + "]", options.ElementAt(2).Value);
                                pedido.Add(OptionsSelected);
                            }
                            else
                            {
                                OptionsSelected.Add(options.ElementAt(2).Key, options.ElementAt(2).Value);
                                pedido.Add(OptionsSelected);
                            }
                        }
                        Console.WriteLine(quantidade + " " + options.ElementAt(2).Key + " adicionados ao seu pedido");
                        break;
                    case "3":
                        Console.WriteLine("Selecione a quantidade");
                        Console.WriteLine("para voltar a tela de seleção de seu pedido digite 0");
                        quantidade = int.Parse(Console.ReadLine());
                        if (quantidade == 0)
                        {
                            break;
                        }
                        for (int i = 0; i < quantidade; i++)
                        {

                            if (OptionsSelected != null)
                            {
                                Random rnd = new Random();
                                int rand = rnd.Next(1, 9999);
                                OptionsSelected.Add(options.ElementAt(3).Key + "[Cod: " + rand + "]", options.ElementAt(3).Value);
                                pedido.Add(OptionsSelected);
                            }
                            else
                            {
                                OptionsSelected.Add(options.ElementAt(3).Key, options.ElementAt(3).Value);
                                pedido.Add(OptionsSelected);
                            }
                        }
                        Console.WriteLine(quantidade + " " + options.ElementAt(3).Key + " adicionados ao seu pedido");
                        break;
                    case "4":
                        Console.WriteLine("Selecione a quantidade");
                        Console.WriteLine("para voltar a tela de seleção de seu pedido digite 0");
                        quantidade = int.Parse(Console.ReadLine());
                        if (quantidade == 0)
                        {
                            break;
                        }
                        for (int i = 0; i < quantidade; i++)
                        {

                            if (OptionsSelected != null)
                            {
                                Random rnd = new Random();
                                int rand = rnd.Next(1, 9999);
                                OptionsSelected.Add(options.ElementAt(4).Key + "[Cod: " + rand + "]", options.ElementAt(4).Value);
                                pedido.Add(OptionsSelected);
                            }
                            else
                            {
                                OptionsSelected.Add(options.ElementAt(4).Key, options.ElementAt(4).Value);
                                pedido.Add(OptionsSelected);
                            }
                        }
                        Console.WriteLine(quantidade + " " + options.ElementAt(4).Key + " adicionados ao seu pedido");
                        break;
                    case "5":
                        Console.WriteLine("Selecione a quantidade");
                        Console.WriteLine("para voltar a tela de seleção de seu pedido digite 0");
                        quantidade = int.Parse(Console.ReadLine());
                        if (quantidade == 0)
                        {
                            break;
                        }
                        for (int i = 0; i < quantidade; i++)
                        {
                            if (OptionsSelected != null)
                            {
                                Random rnd = new Random();
                                int rand = rnd.Next(1, 9999);
                                OptionsSelected.Add(options.ElementAt(5).Key + "[Cod: " + rand + "]", options.ElementAt(5).Value);
                                pedido.Add(OptionsSelected);
                            }
                            else
                            {
                                OptionsSelected.Add(options.ElementAt(5).Key, options.ElementAt(5).Value);
                                pedido.Add(OptionsSelected);
                            }
                        }
                        Console.WriteLine(quantidade + " " + options.ElementAt(5).Key + " adicionados ao seu pedido");
                        break;
                    case "p":

                        break;
                    case "Default":
                        Console.WriteLine("Opção incorreta");
                        break;
                }
            } while (option != "p");
            Console.WriteLine("Revise o seu pedido por favor ");
            int total = 0;

            for (int i = 0; i < pedido.Count; i++)
            {

                Console.WriteLine(pedido[i].ElementAt(i).Key + " " + "R$ " + pedido[i].ElementAt(i).Value);
                total += pedido[i].ElementAt(i).Value;
            }
            int optionContinue = 0;
            Console.WriteLine("O total do seu pedido é: " + total);
            Console.WriteLine("Seu pedido esta correto?");
            Console.WriteLine("Digite 0 para cancelar pedido e sair");
            Console.WriteLine("Digite 1 para continuar");
            optionContinue = int.Parse(Console.ReadLine());
            switch (optionContinue)
            {
                case 0:
                    return;
                case 1:
                    Console.WriteLine("Total a ser pago:  R$" + total);
                    double pay = 0;
                    Console.WriteLine("Troco para quanto?  ");
                    pay = double.Parse(Console.ReadLine());
                    double troco = pay - total;
                    Console.WriteLine("o troco a ser recebido é: R$" + troco);
                    break;
            }

        }

        public void Exercise5() //exercicio simples para entendimento de classe abstract
        {
            Console.WriteLine("Digite a cor do retangulo");
            string color = Console.ReadLine();
            Console.WriteLine("Digite o valor da largura do retangulo");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura do retangulo");
            double h = double.Parse(Console.ReadLine());

            Rectangle rec = new Rectangle(w, h, color);
            double result = rec.Area();
            Console.WriteLine(result + color);
        }
        public void Exercise6() //exercicio simples para entendimento de classe abstract
        {
            Console.WriteLine("Digite a cor do circulo");
            string color = Console.ReadLine();
            Console.WriteLine("Digite o valor da area total do circulo");
            double radius = double.Parse(Console.ReadLine());

            Circle circle = new Circle(radius, color);
            double result = circle.Area();
            Console.WriteLine(result + " " + color);
        }
        public void Exercise7()
        {
            List<Product> products = new List<Product>();
            Console.WriteLine("Digite quantos produtos voce deseja cadastrar");
            int productCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < productCount; i++)
            {
                Console.WriteLine($"Product #{i} Data: ");
                Console.WriteLine("produto comum, produto usado, produto importado Digite uma das opções(c/u/i)");
                char option = char.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do produto");
                string name = Console.ReadLine();
                Console.WriteLine("Digite o valor do produto");
                double price = double.Parse(Console.ReadLine());


                switch (option)
                {
                    case 'c':
                        products.Add(new Product(name, price));
                        break;
                    case 'u':
                        Console.WriteLine("Digite a data de fabricação do produto");
                        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        products.Add(new UsedProduct(name, price,date));
                        break;
                    case 'i':
                        Console.WriteLine("Adicione o valor da taxa alfandegaria");
                        double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        products.Add(new ImportedProduct(name, price, customFee));
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Payments");
            foreach (Product item in products)
            {
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}
