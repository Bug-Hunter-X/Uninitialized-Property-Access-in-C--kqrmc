public class MyClass
{
    public int MyProperty { get; set; } = 0; // Initialized in declaration

    public void MyMethod()
    {
        //Now MyProperty is initialized
        int x = MyProperty; 
    }
}