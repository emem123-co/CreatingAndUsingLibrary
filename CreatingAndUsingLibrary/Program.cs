using StringLib;
using LibraryReference;
namespace CreatingAndUsingLibrary;

internal class Program
{
    static void Main(string[] args)
    {
        var sl = new StringLibClass(); //assigning an instance of the class within the String Library to a variable called "sl".
        var newStr = sl.Concat("Hello", "World!"); 
        Console.WriteLine(newStr);

        var answer = LibraryReferenceClass.Add(11, 22); //(this is a call to a static method in Class 1. Because the method in the other class is static, we are able to refernce using Class1.Add because the property "Add" belongs to the Class1 and is defined there, i.e. it does not have to be defined in the instance of the class. 
                //this is like making the "move" method in the knight class static, defining the "move" properties as belonging to all knight pieces. Color and position methods would not be static, as these will change depending on the specific knight within the knights.
        Console.WriteLine(answer);

        var answerSub = LibraryReferenceClass.Sub(11, 22);
        Console.WriteLine(answerSub);
        
        var answerDiv = LibraryReferenceClass.Div(11, 22);
        Console.WriteLine(answerDiv);
        
        var answerMult = LibraryReferenceClass.Mult(11, 22);
        Console.WriteLine(answerMult);
     
        var answerMod = LibraryReferenceClass.Mod(22,11);
        Console.WriteLine($"11 % 22 is {answerMod}");
        
        var answerFact = LibraryReferenceClass.Fact(5);
        Console.WriteLine(answerFact);

        //var UC = new StringLibClass();
        //var strUPPER = sl.string = "lowercase";
        //Console.WriteLine(strUPPER);
    }


}