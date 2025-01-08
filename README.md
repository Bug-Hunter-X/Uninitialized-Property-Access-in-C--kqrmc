# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been initialized.  Uninitialized properties can lead to unexpected behavior, often resulting in exceptions or incorrect calculations.  The `bug.cs` file showcases this issue, while `bugSolution.cs` provides a corrected version.

## Bug

The `bug.cs` file contains a class with a property `MyProperty` that is not explicitly initialized. The `MyMethod` attempts to read the value of `MyProperty` without assigning a value to it.  This will lead to `MyProperty` having a default value (0 for int), but highlighting a potential problem for non-default values.

## Solution

The `bugSolution.cs` file shows how to correctly initialize the property either in the declaration or before its first use.