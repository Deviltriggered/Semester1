namespace Lab7_but_cooler
{
    class TicTacToe
    {
        int _step;
        int[,] _gameField;
        internal TicTacToe()
        {
            _step = 1;
            _gameField = new int[3, 3];
        }

        internal int step
        {
            get
            {
                return _step;
            }
            set
            {
                _step = value;
            }
        }

        internal void MakeMove(int cell)
        {
            cell--;
            _gameField[cell / 3, cell % 3] = _step % 2 == 1 ? 1 : 2;
            step++;
        }

        internal string CheckEnd()
        {
            int cur_sign = (step % 2 == 0 ? 1 : 2);

            // Проверка на ничью
            if (step == 10)
            {
                return "Ничья";
            }

            // Проверка строк и столбцов
            for (int x = 0; x <= 2; x++)
            {
                if ((_gameField[x, 0] == cur_sign) && (_gameField[x, 1] == cur_sign) && (_gameField[x, 2] == cur_sign))
                {
                    return "Победа " + (cur_sign == 1 ? "X" : "O");
                }
                if ((_gameField[0, x] == cur_sign) && (_gameField[1, x] == cur_sign) && (_gameField[2, x] == cur_sign))
                {
                    return "Победа " + (cur_sign == 1 ? "X" : "O");
                }
            }
            if ((_gameField[0, 0] == cur_sign) && (_gameField[1, 1] == cur_sign) && (_gameField[2, 2] == cur_sign))
            {
                return "Победа " + (cur_sign == 1 ? "X" : "O");
            }
            if ((_gameField[2, 0] == cur_sign) && (_gameField[1, 1] == cur_sign) && (_gameField[0, 2] == cur_sign))
            {
                return "Победа " + (cur_sign == 1 ? "X" : "O");
            }
            return "Крестики-Нолики";
        }
    }
}
