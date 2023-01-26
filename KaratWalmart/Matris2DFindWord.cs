using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaratWalmart
{
    internal class Matris2DFindWord
    {
        public Matris2DFindWord()
        {
            Console.WriteLine("Q1-Find the single occurring element in an array, in which all other elements are occurring twice.");

            
            int timeCost = 0;
            string word = "sos";
            char[,] board = new char[5, 4] {
                                                { '0', '1','2','3' },
                                                { 's', 's','s','s' },
                                                { 'o', 's','s','s' },
                                                { 's', 's','s','s' },
                                                { 's', 's','s','s' }
                                                
                                            };

            string basicRes = FirstWay(board, word );

            Console.WriteLine("FirstWay");
            Console.WriteLine("Input: [" + String.Join(" , ", board) + "]");
            Console.WriteLine("Output: [" + String.Join(" , ", basicRes) + "]");
            
        }

        public string FirstWay(char[,] board, string word) {
            
            Console.WriteLine("test");
            int colCount=board.GetLength(0)-1;
            int rowCount = board.Length / colCount-1;

            string strWord = "";
            //yatay okuma
            for (int rw=0;rw < rowCount; rw++) {
                strWord = "";
                for (int cl = 0; cl < colCount; cl++) {
                    strWord+=board[rw, cl].ToString();    
                }

                if (strWord.Contains(word)) {
                    int rep = ((strWord.Length) - word.Length) + 1;
                    
                    for (int ci=0;ci<=rep;ci++) {

                        int wr = 0;
                        int startColIn =ci;


                        String tmpResult = "";
                        while (wr < word.Length)
                        {
                            if (board[rw, startColIn].ToString() != word.Substring(wr, 1)) {
                                break;
                            }

                            tmpResult += "("+ rw + ","+ startColIn +"),";

                            startColIn++;
                            wr++;
                        }

                        if (wr == word.Length) {
                            return "[" + tmpResult.Substring(0,tmpResult.Length-1) + "]";
                        }
                        string sfd = "";
                    }     
               

             
                }

                string str = "f";
            }


            //Dikey
            for (int cl = 0; cl < colCount; cl++) {
                strWord = "";
                
                for (int rw = 0; rw < rowCount; rw++) {
                    strWord += board[rw, cl];
                }

                if (strWord.Contains(word)) { 
                
                }

            }



            return "";
        }
    }
}
