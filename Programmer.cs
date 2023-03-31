namespace task4
{
    public class Programmer
    {
        public string LastName
        {
            get; 
            set;
        }

        public int ProgramsWritten
        {
            get; 
            set;
        }

        public int ProgrammingLanguages
        {
            get; 
            set;
        }

        public Programmer(string lastName, int programsWritten, int programmingLanguages)
        {
            LastName = lastName;
            ProgramsWritten = programsWritten;
            ProgrammingLanguages = programmingLanguages;
        }

        public int GetQuality()
        {
            return ProgramsWritten * ProgrammingLanguages;
        }
        
        public string GetName()
        {
            return LastName;
        }

        public virtual int GetQualityWithP(int totalPrograms, int correctPrograms)
        {
            int q = GetQuality();
            return q * correctPrograms / totalPrograms;
        }

        public override string ToString()
        {
            return $"Programmer: {LastName}, Programs Written: {ProgramsWritten}, Programming Languages: {ProgrammingLanguages}";
        }
    }
}