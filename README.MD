### BOOTCAMP SOFTWARE ENGINEER FORMULATRIX
This note is use for documentation bootcamp software engineer at formulatrix Indonesia.

**Gilbert Lua**

### DAY 1 - **31/7/2023**
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
   > use `dotnet build` then `dotnet run` to excecute this program. or just run `dotnet run` it will automaticaly build it first.


 
