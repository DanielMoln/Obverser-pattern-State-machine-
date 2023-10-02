using StateMachine.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine.animals
{
    public class Skeleton : Animal
    {

        public Skeleton(EAnimalType type, int lifePoint)
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
                    this.lifePoint -= 40;
                    break;
                case EFeelings.SAD:
                    this.lifePoint -= 1;
                    break;
                case EFeelings.BORED:
                    this.lifePoint += 2;
                    break;
                case EFeelings.AVARAGE:
                    this.lifePoint += 2;
                    break;
            }
        }

        public override string ToString()
        {
            return $"\nTunyacsáp:\n {(this.lifePoint > 0 ? "\tÉlet:" + this.lifePoint : "meghalt :(")}\n";
        }
    }
}
