
using Microsoft.VisualBasic;

namespace SimpleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n");
            Console.WriteLine("Hello C#TrainningSessionsJala World");
            Console.WriteLine("Please welcome. Let's explore diferent type of data");
            Console.WriteLine("\n-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n\n");

            Console.WriteLine("As an Integer, My age: ");
            int MyAge = 31;
            Console.WriteLine(MyAge + "\n");
            double MyAge2 = MyAge;
            float MyAge3 = MyAge;
            string MyAge4 = MyAge.ToString();
            Console.WriteLine("=> And as a double(Implicit): " + MyAge2);
            Console.WriteLine("=> And as a float(Implicit): " + MyAge3);
            Console.WriteLine("=> And as a string(Explicit): " + MyAge4);
            Console.WriteLine("\n                 -:-                 \n");

            Console.WriteLine("As a Double, My last couse's degree: ");
            double MyLtDegree = 81.55;
            Console.WriteLine(MyLtDegree + "\n");
            int MyLtDegree2 = (int)MyLtDegree;
            float MyLtDegree3 = (float)MyLtDegree;
            Console.WriteLine("=> And as an int(Explicit): " + MyLtDegree2);
            Console.WriteLine("=> And as an float(Explicit): " + MyLtDegree3);
            Console.WriteLine("\n                 -:-                 \n");

            Console.WriteLine("As a Float, The very nature's constant: TT");
            float Pi = 3.14159f;
            Console.WriteLine(Pi + "\n");
            int Pi2 = (int)Pi;
            double Pi3 = Pi;
            Console.WriteLine("=> And as an int(Explicit): " + Pi2);
            Console.WriteLine("=> And as a double(Explicit): " + Pi3);
            Console.WriteLine("\n                 -:-                 \n");

            Console.WriteLine("As a Bool, The status of my home's kitchen(AV/NOT-AV): ");
            bool AvailableKitchen = true;
            string FlagToString = AvailableKitchen.ToString();
            Console.WriteLine(AvailableKitchen + "\n");
            Console.WriteLine("=> And as a string(explicit): " + FlagToString);
            Console.WriteLine("\n                 -:-                 \n");

            Console.WriteLine("As a String, Virgil's book name: ");
            string VirgilisBook = "Aneid";
            Console.WriteLine(VirgilisBook + "\n");
            string VirlgilsBookLetters = VirgilisBook.Count().ToString();
            int VirlgilsBookLettersNum;

            Console.WriteLine("Let's count its amount of letters as a string: " + VirlgilsBookLetters);

            bool success = int.TryParse(VirlgilsBookLetters, out VirlgilsBookLettersNum);
            if (success)
            {
                Console.WriteLine("=> And parsed that amount as an integer: " + VirlgilsBookLettersNum);
            }
            else {
                Console.WriteLine("Something goes wrong when trying to count the letters in <Aneid> word");
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("That's All Folks !!");
            Console.WriteLine("\n\n");
        }
    }
}