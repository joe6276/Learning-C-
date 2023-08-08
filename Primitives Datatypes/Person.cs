
namespace Primitives_Datatypes
{
    public  class Person
    {   
        public string Name { get; set; }
        public int Age { get; set; }

       public int tax = 0;
        public string Title { get; set; }   
        public Person(string n , int x)
        {
          Name=n;
          Age=x;
        }
        public void Talk()
        {
            Console.WriteLine("Talking...");
        }

        public void calculateTax(ref int tax , out string Title)//Method Parameter //private to this method
                                             //scope if upto when this method completes to execute
        {

            ///computation to calculate tax 
            tax = 18;
            Console.WriteLine(tax);
            Title = "dsfhgvfdsgh";
        }
    }
}
