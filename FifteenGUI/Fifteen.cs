using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.CodeDom.Compiler;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Reflection.Emit;
using WindowsFormsControlLibrary1;


namespace FifteenGUI
{
    public partial class Fifteen : Form
    {
        bool start = false;
        public Fifteen()
        {
            InitializeComponent();
            game = new Originator();
        }
        private int count = 0;
        Originator game;
        public PButton GetButton(int index)
        {
            switch (index)
            {
                case 0: return pButton0;
                case 1: return pButton1;
                case 2: return pButton2;
                case 3: return pButton3;
                case 4: return pButton4;
                case 5: return pButton5;
                case 6: return pButton6;
                case 7: return pButton7;
                case 8: return pButton8;
                case 9: return pButton9;
                case 10: return pButton10;
                case 11: return pButton11;
                case 12: return pButton12;
                case 13: return pButton13;
                case 14: return pButton14;
                case 15: return pButton15;
                default: return null;
            }
        }
        public void RefreshButtonField()
        {
            for (int position = 0; position < 16; position++)
            {
                int number = game.GetNumber(position);
                GetButton(position).Text = number.ToString();
                GetButton(position).Visible = (number > 0);
            }
        }

        
        private void start_game()
        {
            game.GameStart();
            for (int j = 0; j < 100; j++)
                game.ShiftRandom();
            RefreshButtonField();
            pButton0.Refresh(); pButton1.Refresh(); pButton2.Refresh(); pButton3.Refresh(); pButton4.Refresh(); pButton5.Refresh(); pButton6.Refresh(); pButton7.Refresh();
            pButton8.Refresh(); pButton9.Refresh(); pButton10.Refresh(); pButton11.Refresh(); pButton12.Refresh(); pButton13.Refresh(); pButton14.Refresh(); pButton15.Refresh();
            Label1.Text = "Ход: ";
        }

        private void Fifteen_Load(object sender, EventArgs e)
        {
            start_game();
        }

        
        private void startMenu_Click(object sender, EventArgs e)
        {
            start = true;
            start_game();
            startMenu.Text = "Начать заново";
            count = 0;
            gameTimer1.Enabled = true;
            start = true;
            gameTimer1.StartGame();
            RefreshButtonField();
        }

        private void Fifteen_Click(object sender, EventArgs e)
        {

            if (start)
            {
                int position = Convert.ToInt32(((PButton)sender).Tag);
                game.Shift(position);
                RefreshButtonField();
                Label1.Text = $"Ходов: {++count}";
                if (game.Check())
                {
                    gameTimer1.Enabled = false;
                    Label1.Text = "Ходов: 0";
                    string timer = gameTimer1.GetTimer();
                    gameTimer1.Stop();
                    MessageBox.Show($"Победа\nСделано ходов: {count}\nВремя игры: {timer}");
                    start = false;
                }
            }
        }

        private void CancelClick(object sender, EventArgs e)
        {
            if (start)
            {
                if (count == 0)
                    MessageBox.Show("Отменять нечего");
                else
                {
                    int PositionForCancel = game.GetPos();
                    game.Shift(PositionForCancel, 1);
                    RefreshButtonField();
                    Label1.Text = $"Ходов: {--count}";
                }
            }
        }

        private void Fifteen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
                CancelClick(sender, new EventArgs());
        }
    }
}
