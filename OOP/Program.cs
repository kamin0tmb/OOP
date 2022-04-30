using System;

namespace OOP
{
    
    abstract class ComputerPart
    {
        public abstract void Work();
    }
    class Processor : ComputerPart
    {
        public override void Work()
        {
            throw new NotImplementedException();
        }
    }
    class MotherBoard : ComputerPart
    {
        public override void Work()
        {
            throw new NotImplementedException();
        }
    }
    class GraficCard : ComputerPart
    {
        public override void Work()
        {
            throw new NotImplementedException();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {

        }

    }
}
