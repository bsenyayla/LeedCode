using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode
{
    class WordSearchSOS_CodeSignal
    {
        public WordSearchSOS_CodeSignal() {
            Console.WriteLine("<<==  Word Search SOS CodeSignal    =================================================================>>");
            string word = "sos";
            char[,] board = new char[5, 4] {
                                                { 's', 'o','s','s' },
                                                { 's', 'o','o','s' },
                                                { 's', 's','s','s' },
                                                { 's', 's','s','s' },
                                                { 's', 's','s','s' }
                                            };


            int  rec=WordCount(board, word);

            Console.WriteLine("Input: [" + String.Join(" , ", word) + "] ");
            Console.WriteLine("Output: [" + String.Join(" , ", rec) + "]");
        }


        public int WordCount(char[,] board, string word) {

            int x = 3;
            x.ToString()

            int retVal = 0;
            int colCount = board.GetLength(0) -1;
            int rowCount = (board.Length / colCount)-1;
            String strWord = "";


            // yatayda bu kelime varmı?
            for (int row = 0; row <= rowCount; row++) {
                //yatay bakılıyor
                strWord = "";
                for (int col = 0; col < colCount; col++) {
                    strWord += board[row, col];
                }

                //yatay bakılıyor
                retVal += CountWord(strWord, word);

                String diagonalWord = "";
                int tmpColCount = 0;
                int tmpRowCount = 0;
                //çapraz bakılıyor
                for (int jj = 0; jj < colCount; jj++) {
                    diagonalWord = "";
                    tmpColCount = jj;
                    tmpRowCount = row;
                    if (1 <= tmpColCount && row > 0) {
                        break;
                    }

                    for (int i = 0; i < rowCount; i++) {
                        if (row > 0) {
                            if (tmpRowCount < tmpColCount) {
                                break;
                            }
                        }

                        diagonalWord += board[tmpRowCount, tmpColCount];

                        tmpColCount++;
                        tmpRowCount++;
                        if (tmpColCount >= colCount) {
                            break;
                        }

                        if (tmpRowCount > rowCount) {
                            break;
                        }
                    }

                    retVal += CountWord(diagonalWord, word);
                }



            }


            //////dikey
            strWord = "";
            for (int col = 0; col < colCount; col++) {
                strWord = "";
                for (int row = 0; row <= rowCount; row++) {
                    strWord += board[row, col];
                }

                //yatay bakılıyor
                 retVal += CountWord(strWord, word);
            }





            return retVal;
        }


        public int CountWord(string board, string word) {
            if (board.Length < word.Length) return 0;

            int retVal = 0;

            if (board.Contains(word)) {
                int rep = ((board.Length) - word.Length) + 1;
                for (int i = 0; i < rep; i++) {
                    if (board.Substring(i, word.Length) == word) {
                        retVal++;
                    }
                }
            }

            return retVal;
        }
    }
}
