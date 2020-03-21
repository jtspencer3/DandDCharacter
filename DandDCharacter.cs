using System;
using System.IO;

namespace DandDCharacter
{
    public class DandDCharacter
    {

        public static int RollFourDice()
        {
            int[] rolls = new int[4];
            bool swapped = false;
            
            // Generate Array of Random Items

            for (int i = 0; i < 4; i++)
            {
                Random rnd = new Random();
                rolls[i] = rnd.Next(1, 6);
            }

            while(!swapped)
            {
                for (int i = 0; i < 3; i++)
                {
                    if(rolls[i] > rolls[i + 1])
                    {
                        int hold = rolls[i];
                        rolls[i] = rolls[i+1];
                        rolls[i+1] = hold;
                    }
                    swapped = true;
                }
            }

            int sum = rolls[1] + rolls[2] + rolls[3];
            return sum;

        }

        public static _Character GenerateCharacter(_Character Character = new _Character())
        {
            Console.WriteLine("Enter the name of your character: ");
            Character.CharName = Console.ReadLine();
            Console.WriteLine("Enter your name: ");
            Character.OwnerName = Console.ReadLine();
            Console.WriteLine("Select an ancestry from the list:\n \nhuman \nelf \nhalfling \ndwarf \nhalf-elf \nhalf-orc ");
            Character.Ancestry = Console.ReadLine();
            
            Random rnd = new Random();
            int dice = rnd.Next(1, 6);
            Character.Strength = RollFourDice();
            Character.Dexterity = RollFourDice();
            Character.Constitution = RollFourDice();
            Character.Intelligence = RollFourDice();
            Character.Wisdom = RollFourDice();
            Character.Charisma = RollFourDice();

            return Character;
            
        }

        public static _Character DisplayCharacter(_Character Character)
        {
            Console.WriteLine("Character Name: "  + Character.CharName + "\n" +
                "Player Name: " + Character.OwnerName + "\n" +
                "Ancestry: " + Character.Ancestry + "\n" + 
                "Strength: " + Character.Strength + "\n" +
                "Dexterity: " + Character.Dexterity + "\n" + 
                "Constitution: " + Character.Constitution + "\n" +
                "Intelligence: " + Character.Intelligence + "\n" + 
                "Wisdom: " + Character.Wisdom + "\n" + 
                "Charisma: " + Character.Charisma);

                return Character;
        }

        public static void SaveCharacter(_Character Character)
        {
            Console.WriteLine("What would you like the file to be saved as? (extension will be .txt)");
            string file = Console.ReadLine();
            string fileExt = Path.GetExtension(file);
            if(fileExt != ".txt")
            {
                file = Path.GetFileNameWithoutExtension(file);
                file = file + ".txt";
            }

            using(StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(Character.CharName);
                writer.WriteLine(Character.OwnerName);
                writer.WriteLine(Character.Strength);
                writer.WriteLine(Character.Dexterity);
                writer.WriteLine(Character.Constitution);
                writer.WriteLine(Character.Intelligence);
                writer.WriteLine(Character.Wisdom);
                writer.WriteLine(Character.Charisma);
                writer.WriteLine(Character.Ancestry);
            }

            Console.WriteLine("\nCharacter Saved as " + file);
            
        }

        public static _Character LoadCharacter()
        {
            _Character Character = new _Character();
            Console.WriteLine("What file would you like to load?");
            string fileName = Console.ReadLine();
            string fileExt = Path.GetExtension(fileName);
            if(fileExt != ".txt")
            {
                fileName = Path.GetFileNameWithoutExtension(fileName);
                fileName = fileName + ".txt";
            }

            using(StreamReader reader = new StreamReader(fileName))
            {
                string cName = reader.ReadLine();
                Character.CharName = cName;
                string oName = reader.ReadLine();
                Character.OwnerName = oName;
                string strnth = reader.ReadLine();
                Character.Strength = int.Parse(strnth);
                string dext = reader.ReadLine();
                Character.Dexterity = int.Parse(dext);
                string Consti = reader.ReadLine();
                Character.Constitution = int.Parse(Consti);
                string intelli = reader.ReadLine();
                Character.Intelligence = int.Parse(intelli);
                string wisd = reader.ReadLine();
                Character.Wisdom = int.Parse(wisd);
                string crsma = reader.ReadLine();
                Character.Charisma = int.Parse(crsma);
                Character.Ancestry = reader.ReadLine();

                Console.WriteLine("File Loaded");


            }



            return Character;

        }
    }
}