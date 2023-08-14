## BOOTCAMP SOFTWARE ENGINEER FORMULATRIX
This note is use for documentation bootcamp software engineer at formulatrix Indonesia.

### Gilbert Lua


---


**DAY 1 - 31/7/2023**
> TO DO TASKS
- [x] Installation VS Code and Extension need
- [x] Learn basic git (clone, commit, push, pull)
- [x] Learn Dev Standard and coding standard 
- [x] Reference to learning c#  
- [x] Learn basic of class diagram 

----
1. **Installation VS Code and Extension need** 
2. **Learn basic git (clone, commit, push, pull)**
3. **Learn Dev Standard and coding standard**

    in this case, we try to using code styling like pascal case and camel case. 

    Pascal case is use for declare a class or method, start with Capslock for first word, and the second word so on. camel case is use for declare a variable, start with small case and capslock to second word


    *Pascal Case*
    ```csharp
    class FindName{
        public void PrintName(){
            Console.WriteLine("name");      
        }
    }
    ```

    *Camel Case*
    ```csharp
    class FindName{
        public string? myName = "gilbert";
        public void PrintName(){
            Console.WriteLine(myName);
        }
    }
    ```

4. **Reference to learning c#**
5. **Learn how to make a dotnet solution directory**
   
   We start with make a directory for dotnet solution directory, to do this we make this bash script using cmd

   ```sh
   mkdir dotnet_solution_dir
   cd dotnet_solution_dir
   dotnet new sln
   mkdir project1
   cd project1
   dotnet new console
   ```
   the bash script above is use to create a dotnet new solution directory, when we try it will generate new file with extension .sln.
   inside this directory then create a directory for console application with `dotnet new console`, it will generate 2 folder call bin and obj, then .csproj and Program.cs.
   
   use `dotnet build` then `dotnet run` to excecute this program. or just run `dotnet run` it will automaticaly build it first.

6. **Learn basic of class diagram**
   
   A class diagram is a type of UML (Unified Modeling Language) diagram used in software engineering to represent the static structure of a system or application. It provides a visual representation of the classes, their attributes, methods, and the relationships between different classes within the system.
   
   - Class
    
        Represents a blueprint for objects, defining their attributes and behaviors. A class is depicted as a rectangle with three compartments: the top compartment contains the class name, the middle compartment contains the attributes, and the bottom compartment contains the methods.

   - Atributes
        
        Represents the characteristics or properties of a class. These are typically listed in the middle compartment of the class rectangle.

   - Methods 

        Represents the behaviors or operations that the class can perform. These are usually listed in the bottom compartment of the class rectangle.


    |||
    |---|---|
    |x|**information**|
    |**CAT**|The Class Name|
    |**isFemale**|The atributes|
    |**Scratch**|The behaviour or method|



---
**DAY 2 - 1/8/2023**
> TO DO TASKS
- [x] Continue class diagram
- [x] Access Modifier
- [x] Constructor 
- [x] 4 Pilars OOP
  - Encapsulation
  - Abstraction
  - Inheritance
  - Polymorphism   
---

1. Continue class diagram
   
   in this case we continue learn about class diagram. we try to explain this to simple console application

   Assume that we have a class `Cat` with atribute and method show belows

   atribute :
   ```csharp
   public string? catName;
   public string? catAge;
   ```
   method :
   ```csharp
   public void ScratchCat(){
        Console.WriteLine("Cat Scratch");
   }
   ```

   to access this code above, we have to declare the instance into properties like this
   ```csharp
   Cat _cat = new Cat();
   //assign the cat name and age
   _cat.catName = "miko";
   _cat.catAge = 2;

   //call method
   _cat.ScratchCat();
   ```


1. Access Modifier
   
   In C#, access modifiers are keywords that determine the visibility and accessibility of types (classes, structs, enums, delegates) and their members (fields, properties, methods, constructors) within a program. They control which parts of the code can access and interact with specific elements. C# provides five main access modifiers:

   - public

        The most permissive access modifier. Members marked as public are accessible from any code within the same assembly or from other assemblies that reference the assembly where the public member is defined.

   - private

        The most restrictive access modifier. Members marked as private are only accessible within the same class or struct where they are defined. They are not accessible from any other code, including derived classes.
    
   - protected

        Members marked as protected are accessible within the same class or struct where they are defined and from any derived classes. They are not accessible from unrelated code or classes outside the inheritance hierarchy.

   - internal

        Members marked as internal are accessible within the same assembly but not from outside the assembly. This means that any code in the same project or assembly can access internal members, but code from external assemblies cannot.

   - protected internal

        This access modifier combines the behaviors of both protected and internal. Members marked as protected internal are accessible within the same assembly and also from derived classes, even if they are in a different assembly.

this show how access modifier works

```csharp
using System;

namespace AccessModifiersExample
{
    // Public class accessible from any code
    public class MyClass
    {
        // Public field accessible from any code
        public int publicField;

        // Private field accessible only within this class
        private int privateField;

        // Protected field accessible within this class and derived classes
        protected int protectedField;

        // Internal field accessible within the same assembly
        internal int internalField;

        // Protected internal field accessible within the same assembly and from derived classes
        protected internal int protectedInternalField;

        // Public method accessible from any code
        public void PublicMethod()
        {
            // Can access all fields here (public, private, protected, internal, protected internal)
            publicField = 1;
            privateField = 2;
            protectedField = 3;
            internalField = 4;
            protectedInternalField = 5;
        }
    }

    // Derived class can access protected members of the base class
    public class MyDerivedClass : MyClass
    {
        public void AccessProtectedField()
        {
            // Can access protectedField and protectedInternalField from the base class
            protectedField = 10;
            protectedInternalField = 20;
        }
    }
}

```

### DAY7 8/8/2023
- [x] delegate

    delegate is a type that represents a reference to a method with a specific signature, allowing methods to be treated as first-class objects. Delegates enable the creation of callback mechanisms, event handling, and dynamic method invocation, making them essential for implementing features like event-driven programming and asynchronous operations. Delegates provide a level of abstraction that promotes decoupling of components and facilitates flexible and extensible code designs by allowing methods to be passed as arguments, stored in variables, and invoked dynamically.

    delegate passing method as an argument
    Type of class:
    - class
    - struct
    - enum
    - generic class
    - delegate
    - abstract
    - interface

### DAY 8 8/9/2023

- [x] Delegate using generic

    we can use delegate using generic that allows any of data type to process it

    ```csharp
    public delegate object MyDelegate<T>(T a, T b);
    ```

    to use this delegate can be used like this;
    
    ```csharp
    MyDelegate<int> newDelegate = new(int a, int b);
    ```
    the generic is passing to interger

- [x] Publisher using delegate
    
    In C#, a publisher typically refers to an object or class that raises events. An event is a mechanism that allows a class to provide notifications to other classes when certain actions or state changes occur. The class that raises (or publishes) the event is referred to as the publisher, and the classes that receive and handle these notifications are referred to as subscribers.

    ```csharp
        using System;
        // Publisher class
        class Button
        {
            // Define an event
            public event EventHandler Click;

            // Method that triggers the event
            public void OnClick()
            {
                Click?.Invoke(this, EventArgs.Empty);
            }
        }

        // Subscriber class
        class Program
        {
            static void Main()
            {
                Button button = new Button();
                
                // Subscribe to the event
                button.Click += Button_Click;
                
                // Simulate a button click
                button.OnClick();
            }

            // Event handler method
            static void Button_Click(object sender, EventArgs e)
            {
                Console.WriteLine("Button was clicked!");
            }
        }

    ```

- [x] Publisher using Event
- [x] Exception

    In C#, an exception is an object that represents an error or an unexpected condition that occurs during the execution of a program. When an exception occurs, the normal flow of the program is disrupted, and the runtime environment looks for code that can handle or catch the exception to prevent the program from crashing.

    C# provides a structured exception handling mechanism using try, catch, finally, and optionally, throw blocks. Here's how it works:

    ```cs
    try
    {
        // Code that might cause an exception
        if (someCondition)
        {
            throw new Exception("An error occurred.");
        }
    }
    catch (Exception ex)
    {
        // Code to handle the exception
        Console.WriteLine("Exception caught: " + ex.Message);
    }

    ```

    > learn again about parse and try parse

---

### DAY 8 8/9/2023

#### Operator Overloading

- operator overloading

    Operator overloading is a concept that exists in several programming languages, including C#. It allows you to define custom behaviors for operators when they are used with instances of your own classes. This can make your code more expressive and intuitive. In C#, you can overload a variety of operators, such as +, -, *, /, ==, !=, etc.

    > interface is implement

- enum


    In C#, an enum, short for "enumeration," is a distinct value type that represents a set of named constant values. Enumerations are used to define a list of named integer constants, making your code more readable and understandable when dealing with specific sets of related values.

    ```cs

    enum DaysOfWeek {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program {
        static void Main(string[] args) {
            DaysOfWeek today = DaysOfWeek.Wednesday;

            if (today == DaysOfWeek.Wednesday) {
                Console.WriteLine("It's Wednesday!");
            }
        }
    }
    ```
- enumerator

    an enumerator is an object that allows you to iterate over a collection of items, such as elements in an array or elements in a collection like a list. Enumerators provide a way to sequentially access and process each element of the collection one by one.

    The concept of enumerators is closely related to the concept of iterators. An enumerator implements the IEnumerator interface, and it works in conjunction with the IEnumerable interface. The IEnumerable interface defines a method named GetEnumerator() that returns an enumerator (IEnumerator object), which is then used to iterate through the elements of the collection.

    ```cs
    using System;
    using System.Collections;

    class Program {
        static void Main(string[] args) {
            int[] numbers = { 1, 2, 3, 4, 5 };

            IEnumerable enumerable = numbers; // Convert the array to an IEnumerable

            IEnumerator enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext()) {
                int number = (int)enumerator.Current;
                Console.WriteLine(number);
            }
            
            enumerator.Dispose(); // Dispose the enumerator when done
        }
    }

    ```

- try catch finaly


    In C#, try, catch, and finally are keywords used for exception handling. Exception handling is a mechanism to gracefully handle runtime errors and exceptions that might occur during the execution of a program. Here's how these keywords work:

    try: The try block encloses the code that might throw an exception. You place the potentially risky code within this block.

    catch: The catch block is used to handle exceptions that are thrown within the corresponding try block. If an exception occurs in the try block, the runtime looks for a suitable catch block to handle the exception based on the type of exception thrown.

    finally: The finally block is used to specify code that should be executed regardless of whether an exception occurred or not. This block is optional.

    Here's a basic example of how try, catch, and finally are used in C#:


    ```cs

    using System;

    class Program {
        static void Main(string[] args) {
            try {
                int numerator = 10;
                int denominator = 0;
                int result = numerator / denominator; // This will cause an exception
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally {
                Console.WriteLine("This will always execute.");
            }
        }
    }

    ```



### DAY 11 8/14/2023

- Collection 
    - Array
        
        - array is fixed size, and can't include value out of the index size
        - to solve it can be using ArrayList

            `ArrayList list = new();`
    - List
        - accesible using index
        - dynamic size
        - type safety

            to add
            ```csharp
                List<int> intList = new();
                intList.Add(1);
                intList.Add(2);
            ```

            to remove by index

            ```csharp
                List<int> intList = new();
                intList.Add(1);
                intList.RemoveAt(1);//it will remove value of index 1
            ```
            and more tool see in this [link](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-7.0)


    - HashSet
    
        In C#, a HashSet is an unordered collection of unique elements. It is defined under the System.Collections.Generic namespace1. The HashSet class is based on the model of mathematical sets and provides high-performance set operations similar to accessing the keys of the Dictionary<TKey,TValue> or Hashtable collections1.

        ```csharp

                    // Create a HashSet of integers.
            HashSet<int> evenNumbers = new HashSet<int>();

            // Add some even numbers to the set.
            evenNumbers.Add(0);
            evenNumbers.Add(2);
            evenNumbers.Add(4);
            evenNumbers.Add(6);
            evenNumbers.Add(8);

            // Create another HashSet of integers.
            HashSet<int> oddNumbers = new HashSet<int>();

            // Add some odd numbers to the set.
            oddNumbers.Add(1);
            oddNumbers.Add(3);
            oddNumbers.Add(5);
            oddNumbers.Add(7);
            oddNumbers.Add(9);

            // Merge the two sets.
            evenNumbers.UnionWith(oddNumbers);

            // Display the contents of the merged set.
            foreach (int number in evenNumbers)
            {
                Console.Write(number + " ");
            }

        ```

        class diagram it can make using 
        `mermaid live`



 
