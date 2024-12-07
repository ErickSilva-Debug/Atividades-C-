using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
   

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)// void significa que executa main sem voltar o valor. significa que será executado uma vez, por quê? porque o void falando para main não voltar outro valor, mesmo que seja o mesmo valor 
        {

            Console.WriteLine("Hello World!");//quando tiver erro no código, alguma referencia errada nele, sempre vai dar esse erro de aviso
            Console.WriteLine("viu");//aqui deu erro porque o texto esta colado, so colocar barra investida n 
            Console.ReadLine();//comando que usuário digitar pressionar enter 
            //lembra do ponto e virgula 
            Console.Write("daora");//Depois coloco readLine, quando dou enter o texto aparece 
            // significa \n um caractere para computador, diz para quebrar uma linha 
            //não e interessante você ficar colocando \n no final, e por isso existe uma função para nao é necessario colocar \n
            //Console.WriteLine e uma variação do Console.Write vai quebrar linhas
            
            
        }
    }
} 
