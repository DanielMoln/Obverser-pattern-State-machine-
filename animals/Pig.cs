using StateMachine.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine.animals
{
    public class Pig : Animal
    {
        public Pig(EAnimalType type, int lifePoint)
        {
            this.type = type;
            this.lifePoint = lifePoint;
        }

        public override void Behave(EFeelings feel)
        {
            if (lifePoint <= 0) return;

            switch (feel)
            {
                case EFeelings.HAPPY:
                    this.lifePoint -= 10;
                    break;
                case EFeelings.SAD:
                    this.lifePoint -= 1;
                    break;
                case EFeelings.BORED:
                    this.lifePoint += 10;
                    break;
                case EFeelings.AVARAGE:
                    this.lifePoint += 1;
                    break;
            }
        }

        public override string ToString()
        {
            return $"\nMalacka:\n { (this.lifePoint > 0 ? "\tÉlet:" + this.lifePoint : "meghalt :(") }\n";
        }
    }
}
