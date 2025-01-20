public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a disposed object
        using (var context = new MyDbContext())
        {
            // ... some code that uses the context ...
            var result = context.MyTable.FirstOrDefault(); // Access the object within the using block
        }

        // This line will not throw an exception because the context is no longer accessed after the using block
    }
}