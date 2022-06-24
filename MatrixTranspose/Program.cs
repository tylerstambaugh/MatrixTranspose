

string output = Transpose.String("abc\n" +
    "def\n" +
    "hij");

Console.WriteLine($"output length:{output.Length}");

foreach(char c in output)
{
    Console.WriteLine($"c = {c}");
}

Console.WriteLine(Transpose.String("abc \n" +
    "def \n" +
    "hij"));

Console.ReadLine();



//var lines =
//         "ABC\n" +
//         "123";
//var expected =
//            "A1\n" +
//            "B2\n" +
//            "C3";

//var lines =
//       "A\n" +
//       "1";
//var expected = "A1";

//var lines =
//          "FRACTURE\n" +
//          "OUTLINED\n" +
//          "BLOOMING\n" +
//          "SEPTETTE";
//var expected =
//    "FOBS\n" +
//    "RULE\n" +
//    "ATOP\n" +
//    "CLOT\n" +
//    "TIME\n" +
//    "UNIT\n" +
//    "RENT\n" +
//    "EDGE";

public static class Transpose
{
    public static string String(string input)
    {
        string returnString = "";

        for(int i = 0; i < input.Length; i++)
        {

        }


        returnString = input;

        return returnString;
    }
}