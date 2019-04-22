using System;

public class TextInput
{
    private string input = string.Empty;

    public virtual void Add(char c)
    {
        this.input += c;
    }

    public string GetValue()
    {
        return this.input;
    }
}

public class NumericInput : TextInput
{
    public override void Add(char c)
    {
        if (char.IsDigit(c))
        {
            base.Add(c);
        }
    }
}

public class UserInput
{
    public static void Main(string[] args)
    {
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue());
    }
}