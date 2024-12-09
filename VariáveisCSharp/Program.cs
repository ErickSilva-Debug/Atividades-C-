using System;

namespace variavel
{
    class Program
    {
        static void Main(string[] args)
        {
            var meunome = "Erick Silva";// para string sempre aspas duplas""
            Console.WriteLine(meunome);// deixa vazio write, não aparece nada 
            // não precisa colocar var, let e const para declarar uma variável 
            int numero = 2;
            Console.WriteLine(numero);//int recebe numero inteiro 
            double dec = 10.01;// decimal palavra-chave reservada no C#, proprio sistema consegue ver se o número e inteiro e flutuante
            Console.WriteLine(dec);
            Char carac = 'B';// aspas simples são caracteres unicos, so pode um caractere 
            Console.WriteLine(carac);
            string palavra = "C Sharp";// armazena texto
            Console.WriteLine(palavra);
            //pode fazer assim

            int outroNum;// declarou variável vazia
            outroNum = 10;// colocou que a variável recebe 10 
            Console.WriteLine(outroNum);

            bool verdadeiro;// bool armazena valores com dois estados: verdadeiro ou falso
            verdadeiro = true;
            Console.WriteLine(verdadeiro);

            // melhor as vezes colocar const, para não mudar a variável 
            const int myNum = 15;
            // myNum = 20; vai dar erro, porque myNum 15 e imutável não pode mudar na variável
            // para combinar texto e uma variável, use o + caractere 
            Console.Write(meunome + "\nHelloWorld");
            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;// aqui pode somar dois variáveis em um, pode colocar outra variável dentro da variável

            Console.WriteLine(fullName);
            const int x = 10;//vai dar erro se eu tirar o int 
            const int y = 10;
            Console.WriteLine(x + y);
            // consegue declarar muitas variáveis mesmo tipo.So separar por vírgulas
            int a = 5, b = 6, c = 50;
            Console.WriteLine(a + b + c);
            // identificadores em C# são nomes exclusivos coloca na variável 
            int minutosEstudo = 20;
            Console.WriteLine(minutosEstudo);
            float num = 15.2f;//o tipo float requer que o número tenha o sufixo f no final para indicar que é um valor do tipo float, sempre coloca o f quando você deixa em float 
            Console.WriteLine(num);

            //Outras formas de declaração de uma variável  
            //quando você usa var o C Sharp fica adivinhar qual tipo você esta usando 

            //dynamic variável que aceita troca de valor e de tipo durante a execução do programa.Isso significa que você pode armazenar qualquer tipo de dado em uma variável dynamic
            dynamic cor_favorita = "Azul";
            Console.WriteLine(cor_favorita);
            cor_favorita = "vermelho";
            Console.WriteLine(cor_favorita);


        }
    }
}