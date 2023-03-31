namespace task4
{
    class JuniorProgrammer : Programmer
    {
        public int TotalPrograms { get; set; }

        public JuniorProgrammer(string lastName, int programsWritten, int programmingLanguages, int totalPrograms)
            : base(lastName, programsWritten, programmingLanguages)
        {
            TotalPrograms = totalPrograms;
        }

        public override int GetQualityWithP(int totalPrograms, int correctPrograms)
        {
            int q = GetQuality();
            return q * correctPrograms / TotalPrograms;
        }

        public override string ToString()
        {
            return base.ToString() + $", Total Programs: {TotalPrograms}";
        }
    }
}