public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a disposed object
        using (var context = new MyDbContext())
        {
            // ... some code that uses the context ...
        }

        // This will throw an exception because the context is already disposed
        var result = context.MyTable.FirstOrDefault();
    }
}