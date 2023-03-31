namespace task4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.programsWrittenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.programmingLanguagesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalProgramsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.correctProgramsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.programsWrittenNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmingLanguagesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalProgramsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctProgramsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(10, 10);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.lastNameTextBox.TabIndex = 0;
            // 
            // programsWrittenNumericUpDown
            // 
            this.programsWrittenNumericUpDown.Location = new System.Drawing.Point(10, 40);
            this.programsWrittenNumericUpDown.Name = "programsWrittenNumericUpDown";
            this.programsWrittenNumericUpDown.Size = new System.Drawing.Size(200, 22);
            this.programsWrittenNumericUpDown.TabIndex = 1;
            // 
            // programmingLanguagesNumericUpDown
            // 
            this.programmingLanguagesNumericUpDown.Location = new System.Drawing.Point(10, 70);
            this.programmingLanguagesNumericUpDown.Name = "programmingLanguagesNumericUpDown";
            this.programmingLanguagesNumericUpDown.Size = new System.Drawing.Size(200, 22);
            this.programmingLanguagesNumericUpDown.TabIndex = 2;
            // 
            // totalProgramsNumericUpDown
            // 
            this.totalProgramsNumericUpDown.Location = new System.Drawing.Point(10, 100);
            this.totalProgramsNumericUpDown.Name = "totalProgramsNumericUpDown";
            this.totalProgramsNumericUpDown.Size = new System.Drawing.Size(200, 22);
            this.totalProgramsNumericUpDown.TabIndex = 3;
            // 
            // correctProgramsNumericUpDown
            // 
            this.correctProgramsNumericUpDown.Location = new System.Drawing.Point(10, 130);
            this.correctProgramsNumericUpDown.Name = "correctProgramsNumericUpDown";
            this.correctProgramsNumericUpDown.Size = new System.Drawing.Size(200, 22);
            this.correctProgramsNumericUpDown.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(10, 160);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(200, 30);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(10, 200);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(583, 144);
            this.resultLabel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(230, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Число программ, написанных программистом";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(230, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(507, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Число языков программирования, которыми он пишет программу";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(230, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(478, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Число всех программ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(230, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(450, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Число программ, которые работаю правильно (P)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.programsWrittenNumericUpDown);
            this.Controls.Add(this.programmingLanguagesNumericUpDown);
            this.Controls.Add(this.totalProgramsNumericUpDown);
            this.Controls.Add(this.correctProgramsNumericUpDown);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.programsWrittenNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmingLanguagesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalProgramsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctProgramsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.NumericUpDown programsWrittenNumericUpDown;
        private System.Windows.Forms.NumericUpDown programmingLanguagesNumericUpDown;
        private System.Windows.Forms.NumericUpDown totalProgramsNumericUpDown;
        private System.Windows.Forms.NumericUpDown correctProgramsNumericUpDown;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label resultLabel;
        
        #endregion
    }
}