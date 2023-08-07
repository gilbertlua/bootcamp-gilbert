- Upcast and Downcast
    
    Upcast is convert data from a big data type into small data type
    ```csharp
    double b = 20;
    int a = (int)b;
    ```

    Downcast is convert data from small data type into big data type
    ```csharp
    int a =20;
    double b = a;
    ```
- Patern and matching
- Ref, in, out

    `ref` is use for passing address and change the value without return

    ex
    ```csharp
    void Main(){
        int a = 20;
        MultiplyByTwo(ref a);
    }
    void MultiplyByTwo(ref x){
        x*2;
    }
    ```
    the method MultiplyByTwo will change a value because its using ref x.

    `in` is use for passing address read only it can't be changes the value.

    ```csharp
    void Main(){
        int a = 20;
        MultiplyByTwo(in a);
    }
    void MultiplyByTwo(in x){
        x*2;
    }
    void ChangeTheValue(in x){
        x*2;
    }    
    ```


    

    
    
- Const and readonly
- Enum
- Value & reference type