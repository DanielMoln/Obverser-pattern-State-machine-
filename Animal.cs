using StateMachine.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    public abstract class Animal
    {
        public bool alive = true;
        public int maxLife;
        public int lifePoint;
        public EAnimalType type;

        public virtual void Behave(EFeelings feel) { }
    }
}
