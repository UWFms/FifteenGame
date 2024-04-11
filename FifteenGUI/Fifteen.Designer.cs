using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FifteenGUI
{
    partial class Fifteen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.Label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pButton15 = new WindowsFormsControlLibrary1.PButton();
            this.pButton14 = new WindowsFormsControlLibrary1.PButton();
            this.pButton13 = new WindowsFormsControlLibrary1.PButton();
            this.pButton12 = new WindowsFormsControlLibrary1.PButton();
            this.pButton11 = new WindowsFormsControlLibrary1.PButton();
            this.pButton10 = new WindowsFormsControlLibrary1.PButton();
            this.pButton9 = new WindowsFormsControlLibrary1.PButton();
            this.pButton8 = new WindowsFormsControlLibrary1.PButton();
            this.pButton7 = new WindowsFormsControlLibrary1.PButton();
            this.pButton6 = new WindowsFormsControlLibrary1.PButton();
            this.pButton5 = new WindowsFormsControlLibrary1.PButton();
            this.pButton4 = new WindowsFormsControlLibrary1.PButton();
            this.pButton3 = new WindowsFormsControlLibrary1.PButton();
            this.pButton2 = new WindowsFormsControlLibrary1.PButton();
            this.pButton1 = new WindowsFormsControlLibrary1.PButton();
            this.pButton0 = new WindowsFormsControlLibrary1.PButton();
            this.gameTimer1 = new WindowsFormsControlLibrary1.GameTimer();
            this.cancel_move = new WindowsFormsControlLibrary1.PButton();
            this.startMenu = new WindowsFormsControlLibrary1.PButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menu.Size = new System.Drawing.Size(734, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(601, 1);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(0, 13);
            this.Label1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pButton15, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.pButton14, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.pButton13, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pButton12, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pButton11, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.pButton10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pButton9, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pButton8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pButton7, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pButton6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pButton5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pButton4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pButton3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pButton2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pButton1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pButton0, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 687);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pButton15
            // 
            this.pButton15.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pButton15.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pButton15.ForeColor = System.Drawing.Color.Black;
            this.pButton15.Location = new System.Drawing.Point(552, 516);
            this.pButton15.Name = "pButton15";
            this.pButton15.Size = new System.Drawing.Size(177, 165);
            this.pButton15.TabIndex = 15;
            this.pButton15.Tag = "15";
            this.pButton15.Text = "*";
            this.pButton15.Click += new System.EventHandler(this.Fifteen_Click);
            // 
            // pButton14
            // 
            this.pButton14.BackColor = System.Drawing.Color.SkyBlue;
            this.pButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pButton14.ForeColor = System.Drawing.Color.Black;
            this.pButton14.Location = new System.Drawing.Point(369, 516);
            this.pButton14.Name = "pButton14";
            this.pButton14.Size = new System.Drawing.Size(177, 165);
            this.pButton14.TabIndex = 14;
            this.pButton14.Tag = "14";
            this.pButton14.Text = "*";
            this.pButton14.Click += new System.EventHandler(this.Fifteen_Click);
            // 
            // pButton13
            // 
            this.pButton13.BackColor = System.Drawing.Color.MintCream;
            this.pButton13.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pButton13.ForeColor = System.Drawing.Color.Black;
            this.pButton13.Location = new System.Drawing.Point(186, 516);
            this.pButton13.Name = "pButton13";
            this.pButton13.Size = new System.Drawing.Size(177, 165);
            this.pButton13.TabIndex = 13;
            this.pButton13.Tag = "13";
            this.pButton13.Text = "*";
            this.pButton13.Click += new System.EventHandler(this.Fifteen_Click);
            // 
            // pButton12
            // 
            this.pButton12.BackColor = System.Drawing.Color.LightCyan;
            this.pButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pButton12.ForeColor = System.Drawing.Color.Black;
            this.pButton12.Location = new System.Drawing.Point(3, 516);
            this.pButton12.Name = "pButton12";
            this.pButton12.Size = new System.Drawing.Size(177, 165);
            this.pButton12.TabIndex = 12;
            this.pButton12.Tag = "12";
            this.pButton12.Text = "*";
            this.pButton12.Click += new System.EventHandler(this.Fifteen_Click);
            // 
            // pButton11
            // 
            this.pButton11.BackColor = System.Drawing.Color.LightBlue;
            this.pButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pButton11.ForeColor = System.Drawing.Color.Black;
            this.pButton11.Location = new System.Drawing.Point(552, 345);
            this.pButton11.Name = "pButton11";
            this.pButton11.Size = new System.Drawing.Size(177, 165);
            this.pButton11.TabIndex = 11;
            this.pButton11.Tag = "11";
            this.pButton11.Text = "*";
            this.pButton11.Click += new System.EventHandler(this.Fifteen_Click);
            // 
            // pButton10
            // 
            this.pButton10.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pButton10.ForeColor = System.Drawing.Color.Black;
            this.pButton10.Location = new System.Drawing.Point(369, 345);
            this.pButton10.Name = "pButton10";
            this.pButton10.Size = new System.Drawing.Size(177, 165);
            this.pButton10.TabIndex = 10;
            this.pButton10.Tag = "10";
            this.pButton10.Text = "*";
            this.pButton10.Click += new System.EventHandler(this.Fifteen_Click);
            // 
            // pButton9
            // 
            this.pButton9.BackColor = System.Drawing.Color.SpringGreen;
            this.pButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pButton9.ForeColor = System.Drawing.Color.Black;
            this.pButton9.Location = new System.Drawing.Point(186, 345);
            this.pButton9.Name = "pButton9";
            this.pButton9.Size = new System.Drawing.Size(177, 165);
            this.pButton9.TabIndex = 9;
            this.pButton9.Tag = "9";
            this.pButton9.Text = "*";
            this.pButton9.Click += new System.EventHandler(this.Fifteen_Click);
            // 
            // pButton8
            // 
            this.pButton8.BackColor = System.Drawing.Color.GreenYellow;
            this.pButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pButton8.ForeColor = System.Drawing.Color.Black;
            this.pButton8.Location = new System.Drawing.Point(3, 345);
            this.pButton8.Name = "pButton8";
            this.pButton8.Size = new System.Drawing.Size(177, 165);
            this.pButton8.TabIndex = 8;
            this.pButton8.Tag = "8";
            this.pButton8.Text = "*";
            this.pButton8.Click += new System.EventHandler(this.Fifteen_Click);
            // 
            // pButton7
            // 
            this.pButton7.BackColor = System.Drawing.Color.RoyalBlue;
            this.pButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pButton7.ForeColor = System.Drawing.Color.Black;
            this.pButton7.Location = new System.Drawing.Point(552, 174);
            this.pButton7.Name = "pButton7";
            this.pButton7.Size = new System.Drawing.Size(177, 165);
            this.pButton7.TabIndex = 7;
            this.pButton7.Tag = "7";
            this.pButton7.Text = "*";
            this.pButton7.Click += new System.EventHandler(this.Fifteen_Click);
            // 
            // pButton6
            // 
            this.pButton6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pButton6.ForeColor = System.Drawing.Color.Black;
            this.pButton6.Location = new System.Drawing.Point(369, 174);
            this.pButton6.Name = "pButton6";
            this.pButton6.Size = new System.Drawing.Size(177, 165);
            this.pButton6.TabIndex = 6;
            this.pButton6.Tag = "6";
            this.pButton6.Text = "*";
            this.pButton6.Click += new System.EventHandler(this.Fifteen_Click);
            // 
            // pButton5
            // 
            this.pButton5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pButton5.ForeColor = System.Drawing.Color.Black;
            this.pButton5.Location = new System.Drawing.Point(186, 174);
            this.pButton5.Name = "pButton5";
            this.pButton5.Size = new System.Drawing.Size(177, 165);
            this.pButton5.TabIndex = 5;
            this.pButton5.Tag = "5";
            this.pButton5.Text = "*";
            this.pButton5.Click += new System.EventHandler(this.Fifteen_Click);
            // 
            // pButton4
            // 
            this.pButton4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pButton4.ForeColor = System.Drawing.Color.Black;
            this.pButton4.Location = new System.Drawing.Point(3, 174);
            this.pButton4.Name = "pButton4";
            this.pButton4.Size = new System.Drawing.Size(177, 165);
            this.pButton4.TabIndex = 4;
            this.pButton4.Tag = "4";
            this.pButton4.Text = "*";
            this.pButton4.Click += new System.EventHandler(this.Fifteen_Click);
            // 
            // pButton3
            // 
            this.pButton3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pButton3.ForeColor = System.Drawing.Color.Black;
            this.pButton3.Location = new System.Drawing.Point(552, 3);
            this.pButton3.Name = "pButton3";
            this.pButton3.Size = new System.Drawing.Size(177, 165);
            this.pButton3.TabIndex = 3;
            this.pButton3.Tag = "3";
            this.pButton3.Text = "*";
            this.pButton3.Click += new System.EventHandler(this.Fifteen_Click);
            // 
            // pButton2
            // 
            this.pButton2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pButton2.ForeColor = System.Drawing.Color.Black;
            this.pButton2.Location = new System.Drawing.Point(369, 3);
            this.pButton2.Name = "pButton2";
            this.pButton2.Size = new System.Drawing.Size(177, 165);
            this.pButton2.TabIndex = 2;
            this.pButton2.Tag = "2";
            this.pButton2.Text = "*";
            this.pButton2.Click += new System.EventHandler(this.Fifteen_Click);
            // 
            // pButton1
            // 
            this.pButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pButton1.ForeColor = System.Drawing.Color.Black;
            this.pButton1.Location = new System.Drawing.Point(186, 3);
            this.pButton1.Name = "pButton1";
            this.pButton1.Size = new System.Drawing.Size(177, 165);
            this.pButton1.TabIndex = 1;
            this.pButton1.Tag = "1";
            this.pButton1.Text = "*";
            this.pButton1.Click += new System.EventHandler(this.Fifteen_Click);
            // 
            // pButton0
            // 
            this.pButton0.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pButton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pButton0.ForeColor = System.Drawing.Color.Black;
            this.pButton0.Location = new System.Drawing.Point(3, 3);
            this.pButton0.Name = "pButton0";
            this.pButton0.Size = new System.Drawing.Size(177, 165);
            this.pButton0.TabIndex = 0;
            this.pButton0.Tag = "0";
            this.pButton0.Text = "*";
            this.pButton0.Click += new System.EventHandler(this.Fifteen_Click);
            // 
            // gameTimer1
            // 
            this.gameTimer1.Enabled = false;
            this.gameTimer1.Location = new System.Drawing.Point(679, 4);
            this.gameTimer1.Name = "gameTimer1";
            this.gameTimer1.Size = new System.Drawing.Size(50, 15);
            this.gameTimer1.TabIndex = 7;
            // 
            // cancel_move
            // 
            this.cancel_move.BackColor = System.Drawing.Color.White;
            this.cancel_move.ForeColor = System.Drawing.Color.Black;
            this.cancel_move.Location = new System.Drawing.Point(140, 2);
            this.cancel_move.Name = "cancel_move";
            this.cancel_move.Size = new System.Drawing.Size(100, 19);
            this.cancel_move.TabIndex = 6;
            this.cancel_move.Text = "Отменить ход";
            this.cancel_move.Click += new System.EventHandler(this.CancelClick);
            // 
            // startMenu
            // 
            this.startMenu.BackColor = System.Drawing.Color.White;
            this.startMenu.ForeColor = System.Drawing.Color.Black;
            this.startMenu.Location = new System.Drawing.Point(3, 2);
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(100, 19);
            this.startMenu.TabIndex = 5;
            this.startMenu.Text = "Начать игру";
            this.startMenu.Click += new System.EventHandler(this.startMenu_Click);
            // 
            // Fifteen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.gameTimer1);
            this.Controls.Add(this.cancel_move);
            this.Controls.Add(this.startMenu);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menu);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 750);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Fifteen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пятнашки";
            this.Load += new System.EventHandler(this.Fifteen_Load);
            this.Click += new System.EventHandler(this.Fifteen_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fifteen_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menu;
        private Label Label1;
        private TableLayoutPanel tableLayoutPanel1;
        private WindowsFormsControlLibrary1.PButton pButton0;
        private WindowsFormsControlLibrary1.PButton pButton15;
        private WindowsFormsControlLibrary1.PButton pButton14;
        private WindowsFormsControlLibrary1.PButton pButton13;
        private WindowsFormsControlLibrary1.PButton pButton12;
        private WindowsFormsControlLibrary1.PButton pButton11;
        private WindowsFormsControlLibrary1.PButton pButton10;
        private WindowsFormsControlLibrary1.PButton pButton9;
        private WindowsFormsControlLibrary1.PButton pButton8;
        private WindowsFormsControlLibrary1.PButton pButton7;
        private WindowsFormsControlLibrary1.PButton pButton6;
        private WindowsFormsControlLibrary1.PButton pButton5;
        private WindowsFormsControlLibrary1.PButton pButton4;
        private WindowsFormsControlLibrary1.PButton pButton3;
        private WindowsFormsControlLibrary1.PButton pButton2;
        private WindowsFormsControlLibrary1.PButton pButton1;
        private WindowsFormsControlLibrary1.PButton startMenu;
        private WindowsFormsControlLibrary1.PButton cancel_move;
        private WindowsFormsControlLibrary1.GameTimer gameTimer1;
    }
}

