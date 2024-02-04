using System;

namespace project32
{
    public abstract class baseArray
    {
        public abstract void printArray();
        public abstract double getAverageArrayValue();
        public abstract void fillArray(bool isNotRandom);
        public baseArray(bool isNotRandom){}        
        protected abstract void getRandomArray();
        protected abstract void getFormUserArray();
    }
}