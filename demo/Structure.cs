using System;
namespace demo
{

    public interface Iall
    {
        void display();
    }
    struct structure:Iall
    {
        int i;  // Variables cannot be initilise during declaration
        public structure(int i)
        {
            this.i = i;
        }
        public void display()
        {
            Console.WriteLine(i);
        }
        static void Main()
        {
            //new key word is not mandatory if we are initialising variables 
            structure m;
            m.i = 10;
            m.display();

            //using new keyword
            structure m2 = new structure(25);
            m2.display();
        }

    } 

}