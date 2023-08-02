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





 
