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
            try
            {
                name = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Name輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            Console.Write("NationalNo: ");
            try
            {
                nationalno = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("NationalNo輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            Console.Write("Abilities: ");
            try
            {
                abilities = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Abilities輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            Console.Write("Height: ");
            try
            {
                height = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Height輸入錯誤");
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
                Console.WriteLine("Weight輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            Console.Write("Category: ");
            try
            {
                category = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Category輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            Console.Write("Gender: ");
            try
            {
                gender = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gender輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            Pokemon pokemon = new Pokemon();
            pokemon.NationalNo = nationalno;
            pokemon.Name = name;
            pokemon.Height = height;
            pokemon.Weight = weight;
            pokemon.Category = category;
            pokemon.Abilities = abilities;
            pokemon.Gender = gender;
        }
    }
}