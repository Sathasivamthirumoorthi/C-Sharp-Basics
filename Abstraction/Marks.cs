using System;

namespace MyProblem{

    abstract class Marks{
        public abstract double getPercentage();
    }

    class StudentA : Marks{

        private int subject1;
        private int subject2;
        private int subject3;

        public StudentA(int subject1, int subject2, int subject3){
            this.subject1 = subject1;
            this.subject2 = subject2;
            this.subject3 = subject3;

        }
        public override double getPercentage()
        {
            double total = (subject1 + subject2 + subject3);
            double percentage = (total / 300.0) * 100;
            return Math.Round(percentage,2);;
        }
    }

     class StudentB : Marks{

        private int subject1;
        private int subject2;
        private int subject3;
        private int subject4;

        public StudentB(int subject1, int subject2, int subject3 , int subject4){
            this.subject1 = subject1;
            this.subject2 = subject2;
            this.subject3 = subject3;
            this.subject4 = subject4;
        }
        public override double getPercentage()
        {
            double total = (subject1 + subject2 + subject3 + subject4);
            double percentage = (total / 400.0) * 100;
            return Math.Round(percentage,2);
        }
    }

    // class TestMarks{
    //     public static void Main(string[] args){
    //         StudentA shiva = new StudentA(70,90,90);
    //         Console.WriteLine(" Percentage {0} ",shiva.getPercentage());

    //         StudentB Ari = new StudentB(99,99,99,99);
    //         Console.WriteLine(" Percentage {0} ",Ari.getPercentage());
    //     }
    // }

}