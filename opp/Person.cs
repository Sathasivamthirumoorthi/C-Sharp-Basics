// Create a class hierarchy for a school system with classes like "Person", "Teacher", "Student", and "Administrator".

namespace MyProblem{
    class Person{
        private string name;
        private string age;
        private string gender;

        public string Name{
            get{return name;}
            set{name = value;}
        }

        public string Age{
            get{return age;}
            set{age = value;}
        }

         public string Gender{
            get{return gender;}
            set{gender = value;}
        }

        

        public Person(string name,string age, string gender){
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

    }

    class Teacher : Person{

        private string subject;

        public string Subject{
            get{return subject;}
            set{subject = value;}
        }

        public Teacher(string name,string age,string gender,string subject) : base(name,age,gender){
            this.subject = subject;
        }
    
        public void teach(){
            Console.WriteLine("I can teach");
        }
    }


       class Student : Person{

        private string grade;

        public string Grade{
            get{return grade;}
            set{grade = value;}
        }

        public Student(string name,string age,string gender,string grade) : base(name,age,gender){
            this.grade = grade;
        }
    
        public void study(){
            Console.WriteLine("I can study");
        }
    }


    class Administrator : Person{

        private string department;

        public string Department{
            get{return department;}
            set{department = value;}
        }

        public Administrator(string name,string age,string gender,string department) : base(name,age,gender){
            this.department = department;
        }
    
        public void manage(){
            Console.WriteLine("I can manage - Administrator");
        }
    }
}