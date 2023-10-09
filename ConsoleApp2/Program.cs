using System;

class MyBoolean
{
    private bool value;

    public MyBoolean(bool value)
    {
        this.value = value;
    }

    public static bool operator ==(MyBoolean left, MyBoolean right)
    {
        return left.value == right.value;
    }

    public static bool operator !=(MyBoolean left, MyBoolean right)
    {
        return left.value != right.value;
    }

    public override bool Equals(object obj)
    {
        if (obj is MyBoolean)
        {
            return this == (MyBoolean)obj;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return value.GetHashCode();
    }

    public override string ToString()
    {
        return value.ToString();
    }

    public static implicit operator bool(MyBoolean myBool)
    {
        return myBool.value;
    }

    public static implicit operator MyBoolean(bool value)
    {
        return new MyBoolean(value);
    }
}

class Program
{
    static void Main()
    {
        MyBoolean trueValue = new MyBoolean(true);
        MyBoolean falseValue = new MyBoolean(false);

        Console.WriteLine(trueValue == trueValue);   // True
        Console.WriteLine(trueValue != falseValue);  // True
        Console.WriteLine(trueValue == falseValue);  // False
        Console.WriteLine(trueValue != trueValue);   // False

        // Также можно использовать MyBoolean как bool
        bool regularBool = trueValue;
        Console.WriteLine(regularBool); // True

        MyBoolean myBool = false;
        Console.WriteLine(myBool); // False
    }
}