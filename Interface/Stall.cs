using System;

namespace MyProblem{

    interface Stall{
        public void display(); 
    }


    class GoldStall : Stall{
        
        private string stallName;
        private int cost;
        private string ownerName;
        private int tvset;

        public GoldStall(){
            this.stallName = "";
            this.cost = 0;
            this.ownerName = "";
            this.tvset = 0;
        }

        public GoldStall(string stallName,int cost, string ownerName , int tvset){
            this.stallName = stallName;
            this.cost = cost;
            this.ownerName = ownerName;
            this.tvset = tvset;
        }

        public void display(){
            Console.WriteLine("stallName   :   {0}" , stallName);
            Console.WriteLine("Cost : {0}",  cost);
            Console.WriteLine("Owner : Name {0}",ownerName);
            Console.WriteLine("tvset : {0}" ,tvset);
        }
    }


    class PremiumStall  : Stall{
        
        private string stallName;
        private int cost;
        private string ownerName;
        private int projector;

        public PremiumStall(){
            this.stallName = "";
            this.cost = 0;
            this.ownerName = "";
            this.projector = 0;
        }

        public PremiumStall(string stallName,int cost, string ownerName , int projector){
            this.stallName = stallName;
            this.cost = cost;
            this.ownerName = ownerName;
            this.projector = projector;
        }

        public void display(){
            Console.WriteLine("stallName   :   {0}" , stallName);
            Console.WriteLine("Cost : {0}",  cost);
            Console.WriteLine("Owner : Name {0}",ownerName);
            Console.WriteLine("Projector : {0}" ,projector);
        }
    }



     class ExecutiveStall  : Stall{
        
        private string stallName;
        private int cost;
        private string ownerName;
        private int screen;

        public ExecutiveStall(){
            this.stallName = "";
            this.cost = 0;
            this.ownerName = "";
            this.screen = 0;
        }

        public ExecutiveStall(string stallName,int cost, string ownerName , int screen){
            this.stallName = stallName;
            this.cost = cost;
            this.ownerName = ownerName;
            this.screen = screen;
        }

        public void display(){
            Console.WriteLine("stallName : {0}" , stallName);
            Console.WriteLine("Cost : {0}",  cost);
            Console.WriteLine("Owner : {0}",ownerName);
            Console.WriteLine("Projector : {0}" ,screen);
        }
    }


    // class TestStall{
    //     public static void Main(string[] args){

    //         Console.WriteLine("Choose stall type");
    //         Console.WriteLine("1 Gold Stall");
    //         Console.WriteLine("2 Premium Stall");
    //         Console.WriteLine("3 Executive Stall");

    //         int stall;
    //         stall = Convert.ToInt32(Console.ReadLine());
    //         string stallName;
    //         int cost;
    //         string owner;
    //         switch(stall){
    //             case 1:
                  
    //                 int tv;
    //                 Console.WriteLine("Enter stall Name ");
    //                 stallName = Console.ReadLine();
    //                 Console.WriteLine("Enter stall cost ");
    //                 cost =  Convert.ToInt32(Console.ReadLine());
    //                 Console.WriteLine("Enter stall Owner ");
    //                 owner = Console.ReadLine();
    //                 Console.WriteLine("Enter number of tv ");
    //                 tv = Convert.ToInt32(Console.ReadLine());

    //                 Console.WriteLine();

    //                 GoldStall goldStall = new GoldStall(stallName,cost,owner,tv);

    //                 goldStall.display();

    //             break;

    //             case 2:
            
    //                 int projector;
    //                 Console.WriteLine("Enter stall Name ");
    //                 stallName = Console.ReadLine();
    //                 Console.WriteLine("Enter stall cost ");
    //                 cost =  Convert.ToInt32(Console.ReadLine());
    //                 Console.WriteLine("Enter stall Owner ");
    //                 owner = Console.ReadLine();
    //                 Console.WriteLine("Enter number of projector ");
    //                 projector = Convert.ToInt32(Console.ReadLine());

    //                 Console.WriteLine();

    //                 PremiumStall premiumStall = new PremiumStall(stallName,cost,owner,projector);

    //                 premiumStall.display();

    //                 break;


    //             case 3:
            
    //                 int screen;
    //                 Console.WriteLine("Enter stall Name ");
    //                 stallName = Console.ReadLine();
    //                 Console.WriteLine("Enter stall cost ");
    //                 cost =  Convert.ToInt32(Console.ReadLine());
    //                 Console.WriteLine("Enter stall Owner ");
    //                 owner = Console.ReadLine();
    //                 Console.WriteLine("Enter number of projector ");
    //                 screen = Convert.ToInt32(Console.ReadLine());

    //                 Console.WriteLine();

    //                 ExecutiveStall executiveStall = new ExecutiveStall(stallName,cost,owner,screen);

    //                 executiveStall.display();

    //             break;
    //         }

            

    //     }
    // }


    
}
