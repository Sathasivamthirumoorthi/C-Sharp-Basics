using System;

namespace MyProblem{

    abstract class Marks{
        public abstract double getPercentage();
    }

    class CSE : Marks{

        private int maths;
        private int compilerDesign;
        private int evs;

        public CSE(int maths, int compilerDesign, int evs){
            this.maths = maths;
            this.compilerDesign = compilerDesign;
            this.evs = evs;

        }
        public override double getPercentage()
        {
            double total = (maths + compilerDesign + evs);
            double percentage = (total / 300.0) * 100;
            return Math.Round(percentage,2);;
        }
    }

     class IT : Marks{

        private int maths;
        private int compilerDesign;
        private int evs;
        private int python;

        public IT(int maths, int compilerDesign, int evs , int python){
            this.maths = maths;
            this.compilerDesign = compilerDesign;
            this.evs = evs;
            this.python = python;
        }
        public override double getPercentage()
        {
            double total = (maths + compilerDesign + evs + python);
            double percentage = (total / 400.0) * 100;
            return Math.Round(percentage,2);
        }
    }

    // class TestMarks{
    //     public static void Main(string[] args){
    //         CSE shiva = new CSE(70,90,90);
    //         Console.WriteLine(" Percentage {0} ",shiva.getPercentage());

    //         IT Ari = new IT(99,99,99,99);
    //         Console.WriteLine(" Percentage {0} ",Ari.getPercentage());
    //     }
    // }

}