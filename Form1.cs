using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void calculateButton_Click(object sender, EventArgs e)
        {
            string lastName = lastNameTextBox.Text;
            int programsWritten = (int)programsWrittenNumericUpDown.Value;
            int programmingLanguages = (int)programmingLanguagesNumericUpDown.Value;

            Programmer programmer = new Programmer(lastName, programsWritten, programmingLanguages);
            JuniorProgrammer juniorProgrammer = new JuniorProgrammer(lastName, programsWritten, programmingLanguages, (int)totalProgramsNumericUpDown.Value);

            int totalPrograms = (int)totalProgramsNumericUpDown.Value;
            int correctPrograms = (int)correctProgramsNumericUpDown.Value;

            string name = programmer.GetName();
            int quality = programmer.GetQuality();
            int qualityWithP = programmer.GetQualityWithP(totalPrograms, correctPrograms);
            int juniorQualityWithP = juniorProgrammer.GetQualityWithP(totalPrograms, correctPrograms);

            resultLabel.Text = $"Programmer Name:{name}\nProgrammer Quality: Q=(число программ)*(число языков){quality}\nProgrammer Quality with P: {qualityWithP}\nJunior Programmer Quality with P: {juniorQualityWithP}";
        }
    }
}