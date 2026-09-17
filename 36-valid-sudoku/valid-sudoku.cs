public class Solution {
    public bool IsValidSudoku(char[][] board)
    {
        // sor ellenőrzés
        for (int sor = 0; sor < 9; sor++)
        {
            List<char> sorElem = new List<char>();
            for (int elem = 0; elem < 9; elem++)
            {
                if (board[sor][elem] != '.')
                {
                    if (sorElem.Contains(board[sor][elem]))
                    {
                        Console.WriteLine("Hiba a sorban");
                        return false;
                    }
                    sorElem.Add(board[sor][elem]);
                }
            }
        }
        // oszlop ellenőrzés
        for (int elem = 0; elem < 9; elem++)
        {
            List<char> oszlopElem = new List<char>();
            for (int sor = 0; sor < 9; sor++)
            {
                if (board[sor][elem] != '.')
                {
                    if (oszlopElem.Contains(board[sor][elem]))
                    {
                        Console.WriteLine("Hiba az oszlopban");
                        return false;
                    }
                    oszlopElem.Add(board[sor][elem]);
                }
            }
        }

        //3x3-as kisebb elemek
        List<char> balFelső = new List<char>();
        List<char> középsőFelső = new List<char>();
        List<char> jobbFelső = new List<char>();
        List<char> balKözépső = new List<char>();
        List<char> középső = new List<char>();
        List<char> jobbKözépső = new List<char>();
        List<char> balAlsó = new List<char>();
        List<char> középAlsó = new List<char>();
        List<char> jobbAlsó = new List<char>();

        for (int sor = 0; sor < 9; sor++)
        {
            for (int elem = 0; elem < 9; elem++)
            {
                if (sor <= 2 && elem <= 2) 
                {
                    if (board[sor][elem] != '.')
                    {
                        if (balFelső.Contains(board[sor][elem]))
                        {
                            Console.WriteLine("Hiba a balfelsőben");
                            return false;
                        }
                        balFelső.Add(board[sor][elem]);
                    }
                }
                else if (sor <= 2 && elem >= 3 && elem <= 5)
                {
                    if (board[sor][elem] != '.')
                    {
                        if (középsőFelső.Contains(board[sor][elem]))
                        {
                            Console.WriteLine("Hiba a középfelsőben");
                            return false;
                        }
                        középsőFelső.Add(board[sor][elem]);
                    }
                }
                else if (sor <= 2 && elem >= 6)
                {
                    if (board[sor][elem] != '.')
                    {
                        if (jobbFelső.Contains(board[sor][elem]))
                        {
                            Console.WriteLine("Hiba a jobbfelsőben");
                            return false;
                        }
                        jobbFelső.Add(board[sor][elem]);
                    }
                }
                else if (sor >= 3 && sor <= 5 && elem <= 2)
                {
                    if (board[sor][elem] != '.')
                    {
                        if (balKözépső.Contains(board[sor][elem]))
                        {
                            Console.WriteLine("Hiba a balközépben");
                            return false;
                        }
                        balKözépső.Add(board[sor][elem]);
                    }
                }
                else if (sor >= 3 && sor <= 5 && elem >= 3 && elem <= 5)
                {
                    if (board[sor][elem] != '.')
                    {
                        if (középső.Contains(board[sor][elem]))
                        {
                            Console.WriteLine("Hiba a középsőben");
                            return false;
                        }
                        középső.Add(board[sor][elem]);
                    }
                }
                else if (sor >= 3 && sor <= 5 && elem >= 6)
                {
                    if (board[sor][elem] != '.')
                    {
                        if (jobbKözépső.Contains(board[sor][elem]))
                        {
                            Console.WriteLine("Hiba a jobbközépben");
                            return false;
                        }
                        jobbKözépső.Add(board[sor][elem]);
                    }
                }
                else if (sor >= 6 && elem <= 2)
                {
                    if (board[sor][elem] != '.')
                    {
                        if (balAlsó.Contains(board[sor][elem]))
                        {
                            Console.WriteLine("Hiba a balalsőban");
                            return false;
                        }
                        balAlsó.Add(board[sor][elem]);
                    }
                }
                else if (sor >= 6 && elem >= 3 && elem <= 5)
                {
                    if (board[sor][elem] != '.')
                    {
                        if (középAlsó.Contains(board[sor][elem]))
                        {
                            Console.WriteLine("Hiba a középalsőban");
                            return false;
                        }
                        középAlsó.Add(board[sor][elem]);
                    }
                }
                else if (sor >= 6 && elem >= 6)
                {
                    if (board[sor][elem] != '.')
                    {
                        if (jobbAlsó.Contains(board[sor][elem]))
                        {
                            Console.WriteLine("Hiba a jobbalsóban");
                            return false;
                        }
                        jobbAlsó.Add(board[sor][elem]);
                    }
                }

            }
        }
        return true;
    }
}
