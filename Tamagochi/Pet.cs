using System;
using System.Collections.Generic;
using System.Linq;

namespace Tamagochi
{
    public class Pet
    {

        int hunger = 0;
        int boredom = 0;
        List<string> words = new List<string>() { "Hi" };
        bool isAlive = true;
        Random generator = new Random();
        public string name;

        public void Feed()
        {
            hunger -= 2;
            hunger = Math.Max(hunger, 0);
        }
        public void Hi()
        {
            int word = generator.Next(0, words.Count);
            System.Console.WriteLine(words[word]);
            ReduceBoredom();
        }
        public void Tick()
        {
            hunger++;
            boredom++;

            if (boredom == 10 || hunger == 10)
            {
                isAlive = false;
            }
        }
        public void Teach(string word)
        {
            words.Add(word);
            ReduceBoredom();
        }
        public void PrintStats()
        {
            System.Console.WriteLine("Hunger = " + hunger);
            System.Console.WriteLine("Boredom = " + boredom);
        }
        public bool GetAlive()
        {
            return isAlive;

        }
        private void ReduceBoredom()
        {
            boredom -= 2;
            boredom = Math.Max(boredom, 0);
        }



    }
}