using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace sessia
{
    public partial class Form1 : Form
    {
        private Button[] buttons;
        private Game game;

        public Form1()
        {
            InitializeComponent();

            // Инициализация массива кнопок, предположим, что вы назвали их button1..button9
            buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            game = Game.GetInstance();

            // Назначение обработчика для всех кнопок
            for (int i = 0; i < buttons.Length; i++)
            {
                int index = i; // чтобы захватить правильное значение в лямбде
                buttons[i].Click += (sender, e) => PlayerMove(index);
            }

            ResetGrid();
        }
        private int playerWins = 0;
        private int aiWins = 0;
        private int draws = 0;

        private void ResetGrid()
        {
            foreach (var btn in buttons)
            {
                btn.Enabled = true;
                btn.Text = " ";
            }
        }

        private void PlayerMove(int index)
        {
            if (game.PlayerStep(index))
            {
                UpdateButton(index, "x");
                string result = game.CheckEnd();
                if (!string.IsNullOrEmpty(result))
                {
                    MessageBox.Show(result);
                    ResetGrid();
                    return;
                }

                int aiMove = game.AIStep();
                if (aiMove >= 0)
                {
                    UpdateButton(aiMove, "0");
                    result = game.CheckEnd();
                    if (!string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show(result);
                        ResetGrid();
                        return;
                    }
                }
            }
        }

        private void UpdateButton(int index, string symbol)
        {
            buttons[index].Text = symbol;
            buttons[index].Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}