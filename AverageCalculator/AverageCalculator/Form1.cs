using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageCalculator
{
    public partial class MainForm : Form
    {
        private TextBox[] inputBoxes;
        private Label[] resultLabels;

        public MainForm()
        {
            InitializeComponent();
            InitializeArrays();
            WireEvents();
            typeComboBox.SelectedIndex = 0;
        }

        private void InitializeArrays()
        {
            inputBoxes = new TextBox[] { inputBoxA, inputBoxB, inputBoxC, inputBoxD, inputBoxE };
            resultLabels = new Label[] { resultLabelA, resultLabelB, resultLabelC, resultLabelD, resultLabelE };
        }

        private void WireEvents()
        {
            calculateButton.Click += CalculateButton_Click;
            clearButton.Click += ClearButton_Click;

            foreach (var box in inputBoxes)
            {
                box.TextChanged += InputBox_TextChanged;
            }
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            errorProvider.SetError(textBox, "");
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClearErrors();
                string selectedType = typeComboBox.SelectedItem?.ToString() ?? "double";

                switch (selectedType)
                {
                    case "int": CalculateForType<int>(); break;
                    case "double": CalculateForType<double>(); break;
                    case "decimal": CalculateForType<decimal>(); break;
                    case "float": CalculateForType<float>(); break;
                    default: CalculateForType<double>(); break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearErrors()
        {
            foreach (var box in inputBoxes)
            {
                errorProvider.SetError(box, "");
            }
        }

        private void CalculateForType<T>()
        {
            T[] values = new T[5];

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(inputBoxes[i].Text))
                    {
                        throw new ArgumentException($"Параметр {(char)('A' + i)} не может быть пустым");
                    }

                    values[i] = (T)Convert.ChangeType(inputBoxes[i].Text, typeof(T));
                }
                catch (FormatException)
                {
                    errorProvider.SetError(inputBoxes[i], "Неверный формат числа");
                    throw new FormatException($"Неверный формат для параметра {(char)('A' + i)}");
                }
                catch (OverflowException)
                {
                    errorProvider.SetError(inputBoxes[i], "Число слишком большое");
                    throw new OverflowException($"Переполнение для параметра {(char)('A' + i)}");
                }
            }

            T[] originalValues = (T[])values.Clone();
            MathOperations.ReplaceWithAverage(ref values[0], ref values[1], ref values[2], ref values[3], ref values[4]);

            for (int i = 0; i < 5; i++)
            {
                resultLabels[i].Text = $"{originalValues[i]} → {values[i]:F4}";
                resultLabels[i].ForeColor = Color.Green;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            foreach (var box in inputBoxes)
            {
                box.Text = "";
                errorProvider.SetError(box, "");
            }

            foreach (var label in resultLabels)
            {
                label.Text = "-";
                label.ForeColor = Color.Green;
            }
        }
    }
}