namespace MyNewApp
{
   public class Person
    {
        private string last;
        private string first;

        public Person(string lastName, string firstName)
        {
            last = lastName;
            first = firstName;
        }
    }
}


public class mySampleClass  
{  
    public mySampleClass()  
    {  
        // This is the no parameter constructor method.  
        // First Constructor  
    }  
    public mySampleClass(int Age)  
    {  
        // This is the constructor with one parameter.  
        // Second Constructor  
    }  
    public mySampleClass(int Age, string Name)  
    {  
        // This is the constructor with two parameters.  
        // Third Constructor  
    }  
    // rest of the class members goes here.  
} 

mySampleClass obj = new mySampleClass()  
mySampleClass obj = new mySampleClass(12)
mySampleClass obj = new mySampleClass(12, "Test")