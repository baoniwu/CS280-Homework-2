using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS280_Homework_1._2;

namespace CS280_Homework_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = "";
            string nationalno = "";
            string abilities = "";
            float height = 0.0f;
            float weight = 0.0f;
            string category = "";
            string gender = "";

            Console.WriteLine("請輸入一隻Pokemon:");
            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("NationalNo: ");
            nationalno = Console.ReadLine();

            Console.Write("Abilities: ");
            abilities = Console.ReadLine();

            Console.Write("Height: ");
            try
            {
                height = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Height輸入錯誤，請輸入數字");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            Console.Write("Weight: ");
            try
            {
                weight = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Weight輸入錯誤，請輸入數字");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            Console.Write("Category: ");
            category = Console.ReadLine();

            Console.Write("Gender: ");
            gender = Console.ReadLine();

            Pokemon pokemon = new Pokemon();
            pokemon.Name = name;
            pokemon.NationalNo = nationalno;
            pokemon.Abilities = abilities;
            pokemon.Height = height;
            pokemon.Weight = weight;
            pokemon.Category = category;
            pokemon.Gender = gender;

            Console.WriteLine("建立完成！");
        }
    }
}