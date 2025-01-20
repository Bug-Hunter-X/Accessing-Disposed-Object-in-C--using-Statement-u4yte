# Accessing Disposed Object in C# using Statement

This repository demonstrates a common error in C# where an object is accessed after it has been disposed of. The `bug.cs` file contains the buggy code, and `bugSolution.cs` provides the corrected version.

The error occurs because the `MyDbContext` object is disposed of at the end of the `using` block. Any attempt to access it afterwards will result in an exception.

The solution involves ensuring that all operations involving the disposed object are completed within the `using` block or by using a different approach to manage object lifecycles.