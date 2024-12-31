namespace TypesDemoCSharp_54;

class Program
{
    static void Main(string[] args)
    {
        //this is a comment
        
        //variables
        
        //type - name (camelCase) - value
        
        //word types

        string sethsName = "Seth";

        // sethsName = "Bob";
        //
        // Console.WriteLine(sethsName);

        char sethsMiddleInitial = 'S';
        
        //number types
        
        int sethsAge = 30;
        
        double sethsHeight = 5.8009023;

        decimal sethsAccount = 4500.00m;
        
        //fact type

        bool isCoding = false;
        
        //value and reference types
        
        //value types

        int a = 5;
        int b = a;

        a = 100;

        Console.WriteLine(a);
        Console.WriteLine(b);
        
        //reference types

        var p1 = new Point();

        p1.X = 5;

        var p2 = p1;

        p2.X = 100;

        Console.WriteLine(p1.X);
        Console.WriteLine(p2.X);
        
        //making a variable nullable (being able to give a null value)

        int? number = null;
    }
}
