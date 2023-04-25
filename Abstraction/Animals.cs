using System;

namespace MyProblem{

    abstract class Animals{
        public abstract void cat();
        public abstract void dog();

    }

    class Cats : Animals{
        public override void cat()
        {   
            Console.WriteLine("Cats meow");
        }

        public override void dog()
        {   
        }

    }

    class Dogs : Animals{
        public override void cat()
        {   
        }

        public override void dog()
        {   
            Console.WriteLine("Dogs barks");

        }

    }

}