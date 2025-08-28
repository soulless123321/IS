namespace AverageCalculator
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.inputBoxE = new System.Windows.Forms.TextBox();
            this.inputBoxD = new System.Windows.Forms.TextBox();
            this.inputBoxC = new System.Windows.Forms.TextBox();
            this.inputBoxB = new System.Windows.Forms.TextBox();
            this.inputBoxA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.resultLabelE = new System.Windows.Forms.Label();
            this.resultLabelD = new System.Windows.Forms.Label();
            this.resultLabelC = new System.Windows.Forms.Label();
            this.resultLabelB = new System.Windows.Forms.Label();
            this.resultLabelA = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "int",
            "double",
            "decimal",
            "float"});
            this.typeComboBox.Location = new System.Drawing.Point(150, 90);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(150, 25);
            this.typeComboBox.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.SteelBlue;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(150, 360);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(120, 35);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Вычислить";
            this.calculateButton.UseVisualStyleBackColor = false;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.LightGray;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.clearButton.Location = new System.Drawing.Point(280, 360);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 35);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.inputBoxE);
            this.groupBoxInput.Controls.Add(this.inputBoxD);
            this.groupBoxInput.Controls.Add(this.inputBoxC);
            this.groupBoxInput.Controls.Add(this.inputBoxB);
            this.groupBoxInput.Controls.Add(this.inputBoxA);
            this.groupBoxInput.Controls.Add(this.label5);
            this.groupBoxInput.Controls.Add(this.label4);
            this.groupBoxInput.Controls.Add(this.label3);
            this.groupBoxInput.Controls.Add(this.label2);
            this.groupBoxInput.Controls.Add(this.label1);
            this.groupBoxInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBoxInput.Location = new System.Drawing.Point(150, 130);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(250, 220);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Входные параметры";
            // 
            // inputBoxE
            // 
            this.inputBoxE.Location = new System.Drawing.Point(120, 180);
            this.inputBoxE.Name = "inputBoxE";
            this.inputBoxE.Size = new System.Drawing.Size(120, 25);
            this.inputBoxE.TabIndex = 5;
            // 
            // inputBoxD
            // 
            this.inputBoxD.Location = new System.Drawing.Point(120, 145);
            this.inputBoxD.Name = "inputBoxD";
            this.inputBoxD.Size = new System.Drawing.Size(120, 25);
            this.inputBoxD.TabIndex = 4;
            // 
            // inputBoxC
            // 
            this.inputBoxC.Location = new System.Drawing.Point(120, 110);
            this.inputBoxC.Name = "inputBoxC";
            this.inputBoxC.Size = new System.Drawing.Size(120, 25);
            this.inputBoxC.TabIndex = 3;
            // 
            // inputBoxB
            // 
            this.inputBoxB.Location = new System.Drawing.Point(120, 75);
            this.inputBoxB.Name = "inputBoxB";
            this.inputBoxB.Size = new System.Drawing.Size(120, 25);
            this.inputBoxB.TabIndex = 2;
            // 
            // inputBoxA
            // 
            this.inputBoxA.Location = new System.Drawing.Point(120, 40);
            this.inputBoxA.Name = "inputBoxA";
            this.inputBoxA.Size = new System.Drawing.Size(120, 25);
            this.inputBoxA.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Параметр E:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Параметр D:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Параметр C:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Параметр B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметр A:";
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.resultLabelE);
            this.groupBoxResults.Controls.Add(this.resultLabelD);
            this.groupBoxResults.Controls.Add(this.resultLabelC);
            this.groupBoxResults.Controls.Add(this.resultLabelB);
            this.groupBoxResults.Controls.Add(this.resultLabelA);
            this.groupBoxResults.Controls.Add(this.label6);
            this.groupBoxResults.Controls.Add(this.label7);
            this.groupBoxResults.Controls.Add(this.label8);
            this.groupBoxResults.Controls.Add(this.label9);
            this.groupBoxResults.Controls.Add(this.label10);
            this.groupBoxResults.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBoxResults.Location = new System.Drawing.Point(410, 130);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(300, 220);
            this.groupBoxResults.TabIndex = 8;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Результаты вычислений";
            // 
            // resultLabelE
            // 
            this.resultLabelE.AutoSize = true;
            this.resultLabelE.ForeColor = System.Drawing.Color.Green;
            this.resultLabelE.Location = new System.Drawing.Point(120, 183);
            this.resultLabelE.Name = "resultLabelE";
            this.resultLabelE.Size = new System.Drawing.Size(15, 19);
            this.resultLabelE.TabIndex = 9;
            this.resultLabelE.Text = "-";
            // 
            // resultLabelD
            // 
            this.resultLabelD.AutoSize = true;
            this.resultLabelD.ForeColor = System.Drawing.Color.Green;
            this.resultLabelD.Location = new System.Drawing.Point(120, 148);
            this.resultLabelD.Name = "resultLabelD";
            this.resultLabelD.Size = new System.Drawing.Size(15, 19);
            this.resultLabelD.TabIndex = 8;
            this.resultLabelD.Text = "-";
            // 
            // resultLabelC
            // 
            this.resultLabelC.AutoSize = true;
            this.resultLabelC.ForeColor = System.Drawing.Color.Green;
            this.resultLabelC.Location = new System.Drawing.Point(120, 113);
            this.resultLabelC.Name = "resultLabelC";
            this.resultLabelC.Size = new System.Drawing.Size(15, 19);
            this.resultLabelC.TabIndex = 7;
            this.resultLabelC.Text = "-";
            // 
            // resultLabelB
            // 
            this.resultLabelB.AutoSize = true;
            this.resultLabelB.ForeColor = System.Drawing.Color.Green;
            this.resultLabelB.Location = new System.Drawing.Point(120, 78);
            this.resultLabelB.Name = "resultLabelB";
            this.resultLabelB.Size = new System.Drawing.Size(15, 19);
            this.resultLabelB.TabIndex = 6;
            this.resultLabelB.Text = "-";
            // 
            // resultLabelA
            // 
            this.resultLabelA.AutoSize = true;
            this.resultLabelA.ForeColor = System.Drawing.Color.Green;
            this.resultLabelA.Location = new System.Drawing.Point(120, 43);
            this.resultLabelA.Name = "resultLabelA";
            this.resultLabelA.Size = new System.Drawing.Size(15, 19);
            this.resultLabelA.TabIndex = 5;
            this.resultLabelA.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Параметр E:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Параметр D:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Параметр C:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Параметр B:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Параметр A:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 70);
            this.panel1.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(70, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(450, 30);
            this.label11.TabIndex = 1;
            this.label11.Text = "Калькулятор средних арифметических значений";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(150, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 19);
            this.label12.TabIndex = 10;
            this.label12.Text = "Выберите тип:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxResults);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.label12);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxResults.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox inputBoxE;
        private System.Windows.Forms.TextBox inputBoxD;
        private System.Windows.Forms.TextBox inputBoxC;
        private System.Windows.Forms.TextBox inputBoxB;
        private System.Windows.Forms.TextBox inputBoxA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.Label resultLabelE;
        private System.Windows.Forms.Label resultLabelD;
        private System.Windows.Forms.Label resultLabelC;
        private System.Windows.Forms.Label resultLabelB;
        private System.Windows.Forms.Label resultLabelA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}