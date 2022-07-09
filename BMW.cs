namespace MyNewApp
{
    // Create a Car class
    class BMW
    {
        public string model;  // Create a field
// A constructor is a special method that is used to initialize objects. The advantage of a constructor, is that it is called when an object of a class is created. It can be used to set initial values for fields
        // Create a class constructor for the Car class
        public Car()
        {
            model = "Mustang"; // Set the initial value for model
        }
    }

//     Note that the constructor name must match the class name, and it cannot have a return type (like void or int).

// Also note that the constructor is called when the object is created.

// All classes have constructors by default: if you do not create a class constructor yourself, C# creates one for you. However, then you are not able to set initial values for fields.
}