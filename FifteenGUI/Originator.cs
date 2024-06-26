﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FifteenGUI
{
    class Originator
    {
        int[,] field;
        int x0, y0;
        int size = 4;
        static Random rand = new Random();
        CareTaker stack = new CareTaker();
        Memento pos;

        public Originator()
        {
            field = new int[size, size];
        }
        public void GameStart()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    field[i, j] = CoordinatesToPosition(i, j) + 1;
                }
            }
            x0 = size - 1;
            y0 = size - 1;
            field[x0, y0] = 0;

        }

        private int CoordinatesToPosition(int x, int y)
        {
            if (x < 0) x = 0;
            if (x > size - 1) x = size - 1;
            if (y < 0) y = 0;
            if (y > size - 1) y = size - 1;
            return y * size + x;
        }

        private void PositionToCoordinates(int position, out int x, out int y)
        {
            if (position < 0) position = 0;
            if (position > size * size - 1) position = size * size - 1;
            x = position % size;
            y = position / size;
        }
        public int GetNumber(int position)
        {
            int x, y;
            PositionToCoordinates(position, out x, out y);

            if (x < 0 || x >= size) return 0;
            if (y < 0 || y >= size) return 0;
            return field[x, y];
        }

        public void Shift(int position, int flag = 0)
        {
            int x, y;
            PositionToCoordinates(position, out x, out y);
            if (Math.Abs(x0 - x) + Math.Abs(y0 - y) == 1)
            {
                if (flag == 0)
                {
                    pos = new Memento(CoordinatesToPosition(x0, y0));
                    stack.Push(pos);
                }
                field[x0, y0] = field[x, y];
                field[x, y] = 0;
                x0 = x;
                y0 = y;
            }
        }

        public int GetPos()
        {
            return stack.Pop();
        }

        public void ShiftRandom()
        {
            int a = rand.Next(0, 4);
            int x = x0;
            int y = y0;
            switch (a)
            {
                case 0: x--; break;
                case 1: x++; break;
                case 2: y--; break;
                case 3: y++; break;
            }
            Shift(CoordinatesToPosition(x, y));
        }
        public bool Check()
        {
            if (!(x0 == size - 1 &&
                y0 == size - 1))
                return false;
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    if (!(x == size - 1 && y == size - 1))
                        if (field[x, y] != CoordinatesToPosition(x, y) + 1)
                            return false;
            return true;
        }
    }
}