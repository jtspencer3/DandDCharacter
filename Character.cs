namespace DandDCharacter
{
     public struct _Character
    {
        private string charName;
        private string ownerName;
        private int strength;
        private int dexterity;            
        private int  constitution;
        private int intelligence;
        private int wisdom;
        private int charisma;
        private string ancestry;
        
        public string CharName
        {
            get { return charName; }
            set { charName = value; }
        }
        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }
        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }
        public int Dexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }
        public int Constitution
        {
            get { return constitution; }
            set { constitution = value; }
        }
        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }
        public int Wisdom
        {
            get { return wisdom; }
            set { wisdom = value; }
        }
        public int Charisma
        {
            get { return charisma; }
            set { charisma = value; }
        }
        public string Ancestry 
        {
            get { return ancestry; }
            set { ancestry = value; 
                if(value != "human" || value != "elf" || value != "dwarf" || value != "halfling" || value != "half-elf" || value != "half-orc")
                    {
                        value = "dwarf";
                    }
            }
        }
    }
}