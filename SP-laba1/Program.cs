//Fn WorldLength(s,n);
//Основные слова: дружба, любовь , счастье?!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_laba1
{
    class Program
    {
        private int FnWorldLength(string s, int n)
        {   
            s = Console.ReadLine();
            string[] words = s.Split(new[] { ' ', ',', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                
                n = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Кол-во букв: {0}", words[n].Length);

            }
            return (0);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("**Функция WorldLength(s,n)**");
            Console.Write("Введите предложение: ");
            
            Console.Write("Введите номер-слово: ");
            

            Console.ReadKey();
        }
        
    }
}
