using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            /*int[][,] intJaggedArray = new int[3][,];

            intJaggedArray[0] = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            intJaggedArray[1] = new int[2, 2] { { 3, 4 }, { 5, 6 } };
            intJaggedArray[2] = new int[2, 2];

            Console.WriteLine(intJaggedArray[0][1, 1]); // 4

            Console.WriteLine(intJaggedArray[1][1, 0]); // 5

            Console.WriteLine(intJaggedArray[1][1, 1]); // 6*/

            string[,][,] strJaggedArrayButtons = new string[6,7][,];

            strJaggedArrayButtons[0,0] = new string[2, 3]{ { "01", "02", "03" }, {"10", "20", "30" } };



            for (int i = 0; i < length; i++)
            {

            }
            strJaggedArrayButtons[1,0] = new string[3, 4] { { "10", "11", "12", "13" }, { "10", "00", "20", "30" }, { "10", "20", "30", "40" } };
            strJaggedArrayButtons[2,0] = new string[4, 4] { { "20", "21", "22", "23" }, { "20", "10", "00", "30" }, { "20", "10", "30", "40" }, { "20", "30", "40", "50" } };
            strJaggedArrayButtons[3,0] = new string[4, 4] { { "30", "31", "32", "33" }, { "30", "20", "10", "40" }, { "30", "20", "40", "50" }, { "30", "20", "10", "00" } };
            strJaggedArrayButtons[4,0] = new string[3, 4] { { "40", "41", "42", "43" }, { "40", "30", "20", "50" }, { "40", "30", "20", "10" } };
            strJaggedArrayButtons[5,0] = new string[2, 4] { { "50", "51", "52", "53" }, { "50", "40", "30", "20" } };
            strJaggedArrayButtons[0,1] = new string[3,4] { { "01", "02", "03", "04" }, { "01", "00", "02", "02" }, { "01", "11", "21", "31" } };
            strJaggedArrayButtons[1,1] = new string[3,4] { { "10", "11", "12", "13" }, { "10", "00", "20", "30" }, { "10", "20", "30", "40" } };
            strJaggedArrayButtons[2,1] = new string[4,4] { { "20", "21", "22", "23" }, { "20", "10", "00", "30" }, { "20", "10", "30", "40" }, { "20", "30", "40", "50" } };
            strJaggedArrayButtons[3,1] = new string[4,4] { { "30", "31", "32", "33" }, { "30", "20", "10", "40" }, { "30", "20", "40", "50" }, { "30", "20", "10", "00" } };
            strJaggedArrayButtons[4,1] = new string[3,4] { { "40", "41", "42", "43" }, { "40", "30", "20", "50" }, { "40", "30", "20", "10" } };
            strJaggedArrayButtons[5,1] = new string[2,2] { { "1, 3, 0, 0" }, { "50, 40, 30, 20" } };


            Console.WriteLine(strJaggedArrayButtons[0,0][1, 1]); // 4

            Console.WriteLine(strJaggedArrayButtons[1,0][1, 3]); // 5

            Console.WriteLine(strJaggedArrayButtons[3,0][3, 2]); // 6
        }
    }
}
