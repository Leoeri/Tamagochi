using System;
using System.Collections.Generic;
using System.Linq;

namespace Tamagochi
{
    public class Pet
    {

        int hunger = 0;
        int boredom = 0;
        List<string> words = new List<string>();
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

            if (words.Count > 0)
            {
                int word = generator.Next(0, words.Count);
                System.Console.WriteLine(name + ": " + words[word]);
                ReduceBoredom();
            }
            else
            {
                System.Console.WriteLine(name + " does not know any words yet");
            }
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
            System.Console.WriteLine(name + " has learned " + word);
            ReduceBoredom();
        }
        public void PrintStats()
        {
            System.Console.WriteLine("Hunger = " + hunger);
            System.Console.WriteLine("Boredom = " + boredom);
            hunger--;
            boredom--;
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