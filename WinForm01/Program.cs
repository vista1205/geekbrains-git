using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm01
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var GameStatus = State.GameNo;
            do
            {
                switch (GameStatus)
                {
                    case State.GameNo:
                        var StartMenu = new StartMenu();
                        var result = StartMenu.ShowDialog();
                        switch (result)
                        {
                            case DialogResult.Cancel:
                                GameStatus = State.GameClose;
                                break;
                            case DialogResult.OK:
                                GameStatus = State.GameMulti;
                                break;
                            case DialogResult.Yes:
                                GameStatus = State.GamePuzzle;
                                break;
                        }
                        break;
                    case State.GameMulti:
                        var Multi = new Multi();
                        Application.Run(Multi);
                        if (Multi.OtherDialogResult == DialogResult.Cancel)
                        {
                            GameStatus = State.GameClose;
                        }
                        else
                        {
                            GameStatus = State.GameNo;
                        }
                        break;
                    case State.GamePuzzle:
                        var Puzzle = new Puzzle();
                        Application.Run(Puzzle);
                        if (Puzzle.OtherDialogResult == DialogResult.Cancel)
                        {
                            GameStatus = State.GameClose;
                        }
                        else
                        {
                            GameStatus = State.GameNo;
                        }
                        break;
                }
            } while (GameStatus != State.GameClose);
        }
    }
}
