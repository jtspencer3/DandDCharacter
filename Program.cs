using System;

namespace DandDCharacter
{
    public class Program
    {
        static void Main(string[] args)
        {
            _Character Character = DandDCharacter.GenerateCharacter();
            string input = "";
            int selection = 0;
            
            while(true)
            {
                PrintMenu();             
                input = Console.ReadLine();                
                selection = int.Parse(input);                               
 
                switch(selection)
                {
                    
                    case 1:
                        Character = DandDCharacter.GenerateCharacter();
                        break;
                    case 2:
                        DandDCharacter.SaveCharacter(Character);
                        break;
                    case 3:
                        Character = DandDCharacter.LoadCharacter();
                        break;
                    case 4:
                        DandDCharacter.DisplayCharacter(Character);
                        break;
                    case 5:
                        return;
                    default: 
                        Console.WriteLine("Error: Enter 1-5: ");
                        Character = new _Character();
                        input = Console.ReadLine();
                        selection = int.Parse(input);
                        break;


                }
            }

        }

        static void PrintMenu()
        {
            Console.WriteLine("\nMain Menu \n -------");
            Console.WriteLine("1) Generate a New Character");
            Console.WriteLine("2) Save Current Character");
            Console.WriteLine("3) Load a Character");
            Console.WriteLine("4) Display Current Character");
            Console.WriteLine("5) Exit");
        } 
    }
}
