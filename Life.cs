using StateMachine.animals;
using StateMachine.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    public class Life
    {
        private List<Animal> subscriptors = new List<Animal>()
        {
            new Pig(EAnimalType.PIG, 40),
            new Cat(EAnimalType.CAT, 30),
            new Dog(EAnimalType.DOG, 100),
            new Skeleton(EAnimalType.SKELETON, 100),
        };


        public bool isLiving = true;

        public void run()
        {
            do
            {
                Console.WriteLine("h - Boldog | s - Szomorú | b - Unott | a - Átlagos");
                Console.WriteLine("Kérlek add meg, hogy milyen volt a hangulatod: ");
                string feel = Console.ReadLine().Substring(0, 1);

                addFeelToSubscriptors(parseFeel(feel));
                printSubscriptors();
            } while (checkAlives());
        }

        public bool checkAlives()
        {
            int alive = 0;
            subscriptors.ForEach(sub =>
            {
                if (sub.lifePoint > 0)
                {
                    alive++;
                }
            });

            return alive > 0 ? true : false;
        }
        public void addFeelToSubscriptors(EFeelings feel) => subscriptors.ForEach(sub => sub.Behave(feel));
        public void printSubscriptors() => subscriptors.ForEach(sub => { Console.WriteLine(sub); });
        public EFeelings parseFeel(string feel)
        {
            switch (feel)
            {
                case "h":
                    return EFeelings.HAPPY;
                case "s":
                    return EFeelings.SAD;
                case "b":
                    return EFeelings.BORED;
                case "a":
                    return EFeelings.AVARAGE;
            }

            return EFeelings.HAPPY;
        }
    }
}
