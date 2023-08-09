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

    