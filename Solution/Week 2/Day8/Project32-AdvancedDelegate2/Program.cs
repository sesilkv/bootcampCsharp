namespace MyProgram;

public delegate T MyDelegate<T>(T a, T b);

class Program {
    static void Main() {
        MyDelegate<int> operation = Calculation<int>.Add;
        int add = operation(2, 3);
        Console.WriteLine(add);

        MyDelegate<String> operation2 = Calculation<String>.Add;
        string x = operation2("2", "3");
        Console.WriteLine(x);

        operation = Calculation<int>.Multiply;
        int multiply = operation(2, 3);
        Console.WriteLine(multiply);
    }
}

static class Calculation<T> {

    public static T? Add(T a, T b) {
        if(a is int x && b is int y) {
            return (T)(object)(x + y);
        }
        else if(a is string e && b is string t) { 
            return (T)(object)(e + t);
        }
        else {
            throw new NotSupportedException("Operation not supported for this data type.");
        }
    }

    public static int Multiply(int a, int b) {
        if(a is int x && b is int y) { 
            return a*b;
        } else {
            throw new NotSupportedException("Operation not supported for this data type.");
        }
    }
}