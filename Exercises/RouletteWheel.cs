using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to my Roulette Table.");
            StartMenu();

            // int[] thirdcolumn = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            // int[] secondcolumn = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            // int[] firstcolumn = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };

            // int[] rednums = new int[] { 1, 3, 5, 7, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            // int[] blacknums = new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };



        }

        private static void StartMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Place a bet on one of the following:  ");
            Console.WriteLine("A. Bet on a number ");
            Console.WriteLine("B. Even or Odds?");
            Console.WriteLine("C. Reds or Blacks?");
            Console.WriteLine("D. High number(18-36), or Low number (1-17)");
            Console.WriteLine("E. Dozens, Row Thirds");
            Console.WriteLine("F. Column? (1-3)");
            Console.WriteLine("G. Street (Row)");
            Console.WriteLine("H. Double Rows");
            Console.WriteLine("I. Split");
            Console.WriteLine("J. Corners");
            Console.WriteLine("Press ENTER after making your selection");
            char selection = Convert.ToChar(Console.ReadLine());

            if (selection == 'A' || selection == 'a')
            {
                selectionA();
            }
            if (selection == 'B' || selection == 'b')
            {
                selectionB();
            }
            if (selection == 'C' || selection == 'c')
            {
                selectionC();
            }
            if (selection == 'D' || selection == 'd')
            {
                selectionD();
            }
            if (selection == 'E' || selection == 'e')
            {
                selectionE();
            }
            if (selection == 'F' || selection == 'f')
            {
                selectionF();
            }
            if (selection == 'G' || selection == 'g')
            {
                selectionG();
            }
            if (selection =='H' || selection == 'h')
            {
                selectionH();
            }
            if (selection == 'I' || selection == 'i')
            {
                selectionI();
            }
            if (selection == 'J' || selection == 'j')
            {
                selectionJ();
            }
            else
                Console.WriteLine("Invalid Entry\n");
            StartMenu();
        }

        private static void selectionJ()
        {
            Console.WriteLine("Chose a corner based on this display of the Roulette Table\n");
            Console.WriteLine("3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36");
            Console.WriteLine("2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35");
            Console.WriteLine("1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34\n");
            Console.WriteLine("A 'CORNER' is any quadrant of numbers that are side by side\n");
            Console.WriteLine("Chose your corner by typing the 4 numbers in the quadrant (ex. 1, 2, 4, 5)");
            string Corners = Convert.ToString(Console.ReadLine());
            Random rnd = new Random();
            int rndcorner = rnd.Next(36);
            int[] thirdcolumn = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            int[] secondcolumn = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] firstcolumn = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };

            if (firstcolumn.Contains(rndcorner) && rndcorner == 1)
            {
                Console.WriteLine("Corners: 1,2,5,4");
                Console.WriteLine($"You chose: ({Corners})\n");
            }
            else if (firstcolumn.Contains(rndcorner) && rndcorner == 34)
            {
                Console.WriteLine("Corners: 34,31,32,35");
                Console.WriteLine($"You chose: ({Corners})\n");
            }
            else if (firstcolumn.Contains(rndcorner) && rndcorner != 1 && rndcorner != 34)
            {
                Console.WriteLine($"Corners: {rndcorner},{rndcorner - 3},{rndcorner - 2},{rndcorner + 1}");
                Console.WriteLine($"Corners: {rndcorner},{rndcorner + 1},{rndcorner + 4}, {rndcorner + 3}");
                Console.WriteLine($"You chose: ({Corners})\n");
            }

            if (secondcolumn.Contains(rndcorner) && rndcorner == 2)
            {
                Console.WriteLine("Corners: 1,2,4,5");
                Console.WriteLine("Corners: 2,3,5,6");
                Console.WriteLine($"You chose: ({Corners})\n");
            }
            else if (secondcolumn.Contains(rndcorner) && rndcorner == 35)
            {
                Console.WriteLine("Corners: 31,32,34,35");
                Console.WriteLine("Corners: 32,33,35,36");
                Console.WriteLine($"You chose: ({Corners})\n");
            }
            else if (secondcolumn.Contains(rndcorner) && rndcorner != 2 && rndcorner != 35)
            {
                Console.WriteLine($"Corners: {rndcorner - 4},{rndcorner - 3},{rndcorner},{rndcorner - 1}");
                Console.WriteLine($"Corners: {rndcorner - 3},{rndcorner - 2},{rndcorner},{rndcorner + 1}");
                Console.WriteLine($"Corners: {rndcorner + 1},{rndcorner + 4},{rndcorner},{rndcorner + 3}");
                Console.WriteLine($"Corners: {rndcorner - 1},{rndcorner},{rndcorner + 3},{rndcorner + 2}");
                Console.WriteLine($"You chose: ({Corners})\n");
            }

            if (thirdcolumn.Contains(rndcorner) && rndcorner == 3)
            {
                Console.WriteLine("Corners: 2,3,5,6");
                Console.WriteLine($"You chose: ({Corners})\n");
            }
            else if (thirdcolumn.Contains(rndcorner) && rndcorner == 36)
            {
                Console.WriteLine("Corners: 32,33,35,36");
                Console.WriteLine($"You chose: ({Corners})\n");
            }
            else if (thirdcolumn.Contains(rndcorner) && rndcorner != 3 && rndcorner != 36)
            {
                Console.WriteLine($"Corners: {rndcorner - 4},{rndcorner - 3},{rndcorner - 1},{rndcorner}");
                Console.WriteLine($"Corners: {rndcorner - 1},{rndcorner},{rndcorner + 2},{rndcorner + 3}");
                Console.WriteLine($"You chose: ({Corners})\n");
            }
            Console.WriteLine("If your CORNERS match, congratulations!");
            Console.WriteLine("If not, sorry\n");
            Console.WriteLine("Do you want to play again? Y/N");
            char ans = Convert.ToChar(Console.ReadLine());
            if (ans == 'Y' || ans == 'y')
            {
                StartMenu();

            }
            else if (ans == 'N' || ans == 'n')
            {
                Console.WriteLine("Thanks for playing.");
                Console.WriteLine("Exit whenever you are ready");
            }
        }

        private static void selectionI()
        {
            Console.WriteLine("Chose a split based on this display of the Roulette Table\n");
            Console.WriteLine("3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36");
            Console.WriteLine("2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35");
            Console.WriteLine("1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34\n");
            Console.WriteLine("*A split is any 2 numbers side by side*");
            Console.WriteLine("Enter your choice by typing a number");
            int split = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int rndsplit = rnd.Next(36);
            int[] thirdcolumn = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            int[] secondcolumn = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] firstcolumn = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };

            if (firstcolumn.Contains(rndsplit))
            {

                if (rndsplit == 1)
                {
                    Console.WriteLine("Split: 1/2, 1/4");
                    Console.WriteLine($"You chose: ({split})\n");
                }
                else if (rndsplit == 34)
                {
                    Console.WriteLine("Split: 34/35, 31/34");
                    Console.WriteLine($"You chose: ({split})\n");
                }
                else
                {
                    Console.WriteLine($"Split: {rndsplit}/{rndsplit + 1}, {rndsplit}/{rndsplit - 3}, {rndsplit}/{rndsplit + 3}");
                    Console.WriteLine($"You chose: ({split})\n");
                }
            }
            else if (secondcolumn.Contains(rndsplit))
            { 
                if (rndsplit == 2)
                {
                    Console.WriteLine("Split: 2/1, 2/3, 2/5");
                    Console.WriteLine($"You chose: ({split})\n");
                }
                else if (rndsplit == 35)
                {
                    Console.WriteLine("Split: 35/34, 35/36, 35/32");
                    Console.WriteLine($"You chose: ({split})\n");
                }
                else
                {
                    Console.WriteLine($"Split: {rndsplit}/{rndsplit - 1}, {rndsplit}/{rndsplit + 1}, {rndsplit}/{rndsplit + 3}, {rndsplit}/{rndsplit - 3}");
                    Console.WriteLine($"You chose: ({split})\n");
                }
            }
              else if (thirdcolumn.Contains(rndsplit))
                if (rndsplit == 3)
                {
                    Console.WriteLine("Split: 2/3, 3/6");
                    Console.WriteLine($"You chose: ({split})\n");
                }
                else if (rndsplit == 36)
                {
                    Console.WriteLine("Split: 35/36, 33/36");
                    Console.WriteLine($"You chose: ({split})\n");
                }
                else
                {
                    Console.WriteLine($"Split: {rndsplit}/{rndsplit - 1}, {rndsplit}/{rndsplit - 3}, {rndsplit}/{rndsplit + 3}");
                    Console.WriteLine($"You chose: ({split})\n");
                }

            Console.WriteLine("If your number is in any of the SPLITS, congratulations!");
            Console.WriteLine("If not, sorry\n");
            Console.WriteLine("Do you want to play again? Y/N");
            char ans = Convert.ToChar(Console.ReadLine());
            if (ans == 'Y' || ans == 'y')
            {
                StartMenu();

            }
            else if (ans == 'N' || ans == 'n')
            {
                Console.WriteLine("Thanks for playing.");
                Console.WriteLine("Exit whenever you are ready");
            }
        }

        private static void selectionH()
        {
            Console.WriteLine("Select DOUBLE ROWS by writing out all 6 numbers (ex. A,B,C,X,Y,Z)\n");
            Console.WriteLine("1.  (1,2,3) (4,5,6)       2. (4,5,6) (7,8,9)       3. (7,8,9) (10,11,12)    4. (10,11,12) (13,14,15)");
            Console.WriteLine("5. (13,14,15) (16,17,18)  6. (16,17,18) (19,20,21) 7. (19,20,21) (22,23,24) ");
            Console.WriteLine("9. (22,23,24) (25,26,27) 10. (25,26,27) (28,29,30) 11.(28,29,30) (31,32,33) 12.(31,32,33) (34,35,36)");
            string doublerows = Convert.ToString(Console.ReadLine());
            Random rnd = new Random();
            int rnddouble = rnd.Next(36);
            int[] thirdcolumn = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            int[] secondcolumn = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] firstcolumn = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };



            if (firstcolumn.Contains(rnddouble) && rnddouble == 1)
            {
                Console.WriteLine("6 Numbers: 1,2,3,4,5,6");
                Console.WriteLine($"You chose: ({doublerows})\n");
            }
            else if (firstcolumn.Contains(rnddouble) && rnddouble == 34)
            {
                Console.WriteLine("6 Numbers: 31,32,33,34,35,36");
                Console.WriteLine($"You chose: ({doublerows})\n");
            }
            else if (firstcolumn.Contains(rnddouble) && rnddouble != 1 && rnddouble != 34)
            {
                Console.WriteLine($"6 Numbers: {rnddouble - 3},{rnddouble - 2},{rnddouble - 1},{rnddouble},{rnddouble + 1},{rnddouble + 2} " +
                    "\r\n" + $"{rnddouble},{rnddouble + 1},{rnddouble + 2},{rnddouble + 3},{rnddouble + 4},{rnddouble + 5}");
                Console.WriteLine($"You chose: ({doublerows})\n");
            }

            if (secondcolumn.Contains(rnddouble) && rnddouble == 2)
            {
                Console.WriteLine("6 Numbers: 1,2,3,4,5,6");
                Console.WriteLine($"You chose: ({doublerows})\n");
            }
            else if (secondcolumn.Contains(rnddouble) && rnddouble == 35)
            {
                Console.WriteLine("6 Numbers: 31,32,33,34,35,36");
                Console.WriteLine($"You chose: ({doublerows})\n");
            }
            else if (secondcolumn.Contains(rnddouble) && rnddouble != 2 && rnddouble != 35)
            {
                Console.WriteLine($"6 Numbers: {rnddouble - 4},{rnddouble - 3},{rnddouble - 2},{rnddouble - 1},{rnddouble},{rnddouble + 1} " +
                    "\r\n" + $"{rnddouble - 1},{rnddouble},{rnddouble + 1},{rnddouble + 2},{rnddouble + 3},{rnddouble + 4}");
                Console.WriteLine($"You chose: ({doublerows})\n");
            }

            if (thirdcolumn.Contains(rnddouble) && rnddouble == 3)
            {
                Console.WriteLine("6 Numbers: 1,2,3,4,5,6");
                Console.WriteLine($"You chose: ({doublerows})\n");
            }
            else if (thirdcolumn.Contains(rnddouble) && rnddouble == 36)
            {
                Console.WriteLine("6 Numbers: 31,32,33,34,35,36");
                Console.WriteLine($"You chose: ({doublerows})\n");
            }
            else if (thirdcolumn.Contains(rnddouble) && rnddouble != 3 && rnddouble != 36)
            {
                Console.WriteLine($"6 Numbers: {rnddouble - 5},{rnddouble - 4},{rnddouble - 3},{rnddouble - 2},{rnddouble - 1},{rnddouble} " +
                    "\r\n" + $"{rnddouble - 2},{rnddouble - 1},{rnddouble},{rnddouble + 1},{rnddouble + 2},{rnddouble + 3}");
                Console.WriteLine($"You chose: ({doublerows})\n");
            }
            Console.WriteLine("If your DOUBLE ROWS match, congratulations!");
            Console.WriteLine("If not, sorry\n");
            Console.WriteLine("Do you want to play again? Y/N");
            char ans = Convert.ToChar(Console.ReadLine());
            if (ans == 'Y' || ans == 'y')
            {
                StartMenu();

            }
            else if (ans == 'N' || ans == 'n')
            {
                Console.WriteLine("Thanks for playing.");
                Console.WriteLine("Exit whenever you are ready");
            }
        }

        private static void selectionG()
        {
            Console.WriteLine("Select which street (1-12) the ball will land by typing out the numbers in each row(ex.X,Y,Z)");
            Console.WriteLine("1.  (1,2,3)    2.  (4,5,6)    3.  (7,8,9)     4.  (10,11,12)  5.  (13,14,15)  6.  (16,17,18) 7. (19,20,21)");
            Console.WriteLine("8.  (22,23,24) 9.  (25,26,27) 10.  (28,29,30) 11.  (31,32,33) 12.  (34,35,36)");
            string rowselection = Convert.ToString(Console.ReadLine());
            Random rnd = new Random();
            int rndrow = rnd.Next(36);
            int[] thirdcolumn = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            int[] secondcolumn = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] firstcolumn = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };

          
             if (firstcolumn.Contains(rndrow))
            {
                Console.WriteLine($" The winning street: {rndrow}, {rndrow + 1}, {rndrow + 2}");
                Console.WriteLine($" You chose: ({rowselection})\n");
            }
            else if (secondcolumn.Contains(rndrow))
            {
                Console.WriteLine($" The winning street: {rndrow -1}, {rndrow}, {rndrow + 1}");
                Console.WriteLine($" You chose: ({rowselection})\n");
            }
            else if (thirdcolumn.Contains(rndrow))
            {
                Console.WriteLine($" The winning street: {rndrow - 1}, {rndrow}, {rndrow + 1}");
                Console.WriteLine($" You chose: ({rowselection})\n");
            }
            Console.WriteLine("If your streets match, congratulations!");
            Console.WriteLine("If not, sorry\n");
            Console.WriteLine("Do you want to play again? Y/N");
            char ans = Convert.ToChar(Console.ReadLine());
            if (ans == 'Y' || ans == 'y')
            {
                StartMenu();

            }
            else if (ans == 'N' || ans == 'n')
            {
                Console.WriteLine("Thanks for playing.");
                Console.WriteLine("Exit whenever you are ready");
            }
        }

        private static void selectionF()
        {
            Console.WriteLine("Decide whether the ball will land in the FIRST, SECOND, or THIRD column using this display of the Roulette Table\n");
            Console.WriteLine("THIRD:  3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36");
            Console.WriteLine("SECOND: 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35");
            Console.WriteLine("FIRST:  1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34\n");
            Console.WriteLine("1 = FIRST COLUMN");
            Console.WriteLine("2 = SECOND COLUMN");
            Console.WriteLine("3 = THIRD COLUMN");
            int column = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int C = rnd.Next(36);
            int[] thirdcolumn = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            int[] secondcolumn = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] firstcolumn = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };

            if (column < 1 || column > 36)
            {
                Console.WriteLine("Invalid Entry");
                selectionF();
            }
            else if (column == 1)
            {
                if (firstcolumn.Contains(C))
                {
                    Console.WriteLine($"Congratulations! {C} was in the FIRST COLUMN!\n");
                }
                else
                {
                    Console.WriteLine($"Sorry, {C} was outside of the FIRST COLUMN./n");
                }
            }
            else if (column == 2)
            {
                if (firstcolumn.Contains(C))
                {
                    Console.WriteLine($"Congratulations! {C} was in the SECOND COLUMN!\n");
                }
                else
                {
                    Console.WriteLine($"Sorry, {C} was outside of the SECOND COLUMN./n");
                }
            }
            else if (column == 3)
            {
                if (firstcolumn.Contains(C))
                {
                    Console.WriteLine($"Congratulations! {C} was in the THIRD COLUMN!\n");
                }
                else
                {
                    Console.WriteLine($"Sorry, {C} was outside of the THIRD COLUMN./n");
                }
            }
            Console.WriteLine("Do you want to play again? Y/N");
            char ans = Convert.ToChar(Console.ReadLine());
            if (ans == 'Y' || ans == 'y')
            {
                StartMenu();

            }
            else if (ans == 'N' || ans == 'n')
            {
                Console.WriteLine("Thanks for playing.");
                Console.WriteLine("Exit whenever you are ready");
            }

        }

        private static void selectionD()
        {
            Console.WriteLine("Select whether a number will be HIGH (18-36) or LOW (1-17)");
            Console.WriteLine("1 = HIGH");
            Console.WriteLine("2 = LOW");
            int highlow = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int HorL = rnd.Next(36);

            if (highlow < 1 || highlow > 2)
            {
                Console.WriteLine("Invalid Entry");
            }
            else if (highlow == 1)
            {
                if (HorL > 17 && HorL < 37)
                {
                    Console.WriteLine($"Congratulations! {HorL} is a HIGH number\n");
                }
                else
                    Console.WriteLine($"Sorry, {HorL} is a LOW number\n");
            }
            else if (highlow == 2)
            {
                if (HorL > 0 && HorL < 18)
                {
                    Console.WriteLine($"Congratulations! {HorL} is a LOW number\n");
                }
                else
                    Console.WriteLine($"Sorry, {HorL} is a HIGH number\n");
            }
            Console.WriteLine("Do you want to play again? Y/N");
            char ans = Convert.ToChar(Console.ReadLine());
            if (ans == 'Y' || ans == 'y')
            {
                StartMenu();

            }
            else if (ans == 'N' || ans == 'n')
            {
                Console.WriteLine("Thanks for playing.");
                Console.WriteLine("Exit whenever you are ready");
            }

        }

        private static void selectionE()
        {
            Console.WriteLine("Select whether the ball will land in the FIRST THIRD(1-12), SECOND THIRD(13-24), OR THIRD THIRD(25-36)");
            Console.WriteLine("1 = FIRST");
            Console.WriteLine("2 = SECOND");
            Console.WriteLine("3 = THIRD");
            int thirds = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int rndthird = rnd.Next(36);

            if (thirds < 1 || thirds > 3)
            {
                Console.WriteLine("Invalid Entry");
                selectionE();
            }

            else if (thirds == 1)
            {
                if (rndthird < 13)
                {
                    Console.WriteLine($"Congratulations! The number {rndthird} was in the FIRST THIRD\n");
                }
                else
                    Console.WriteLine($"Sorry, the number {rndthird} was outside the FIRST THIRD\n");
            }
            else if (thirds == 2)
            {
                if (rndthird > 12 && rndthird < 25)
                {
                    Console.WriteLine($"Congratulations! The number {rndthird} was in the SECOND THIRD\n");
                }
                else
                    Console.WriteLine($"Sorry, the number {rndthird} was outside the SECOND THIRD\n");
            }

            else if (thirds == 3)
            {
                if (rndthird > 24 && rndthird < 37)
                {
                    Console.WriteLine($"Congratulations! The number {rndthird} was in the THIRD THIRD\n");
                }
                else
                    Console.WriteLine($"Sorry, the number {rndthird} was outside the THIRD THIRD\n");
            }

            Console.WriteLine("Do you want to play again? Y/N");
            char ans = Convert.ToChar(Console.ReadLine());
            if (ans == 'Y' || ans == 'y')
            {
                StartMenu();

            }
            else if (ans == 'N' || ans == 'n')
            {
                Console.WriteLine("Thanks for playing.");
                Console.WriteLine("Exit whenever you are ready");
            }
        }

        private static void selectionC()
        {
            Console.WriteLine("Please select whether the ball will land on RED or BLACK");
            Console.WriteLine("1 = Red");
            Console.WriteLine("2 = Black");
            int RedorBlack = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int RorB = rnd.Next(36);
            int[] rednums = new int[] { 1, 3, 5, 7, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] blacknums = new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };

            if (RedorBlack < 1 || RedorBlack > 2)
            {
                Console.WriteLine("Invalid Entry");
                selectionC();
            }

            else if (RedorBlack == 1)
            {

                if (rednums.Contains(RorB))
                {
                    Console.WriteLine($"Congratulations! You win! The number {RorB} was a Red number!\n");

                }

                else if (blacknums.Contains(RorB))
                {
                    Console.WriteLine("Sorry, the number you selected was Black\n");
                }

            }

            else if (RedorBlack == 2)
            {
                if (blacknums.Contains(RorB))
                {
                    Console.WriteLine($"Congratulations! You win! The number {RorB} was a Black number!\n");
                }

                else if (rednums.Contains(RorB))
                {
                    Console.WriteLine("Sorry, the number you selected was Red\n");
                }
            }
            Console.WriteLine("Do you want to play again? Y/N");
            char ans = Convert.ToChar(Console.ReadLine());
            if (ans == 'Y' || ans == 'y')
            {
                StartMenu();

            }
            else if (ans == 'N' || ans == 'n')
            {
                Console.WriteLine("Thanks for playing.");
                Console.WriteLine("Exit whenever you are ready");
            }
        }

        private static void selectionB()
        {
            Console.WriteLine("Please select either ODD or EVEN");
            Console.WriteLine("1 = Odd");
            Console.WriteLine("2 = Even");
            int EvenorOdd = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int EorO = rnd.Next(36);

            if (EvenorOdd < 1 || EvenorOdd > 2)
            {
                Console.WriteLine("Invalid Entry");
                selectionB();
            }

            else if (EvenorOdd == 1)
            {
                if (EorO % 2 == 1)
                {
                    Console.WriteLine($"Congratulations! The number {EorO} was Odd!\n");
                }
                else if (EorO % 2 == 0 || EorO == 0)
                {
                    Console.WriteLine($"Sorry, the number {EorO} was Even.\n");
                }
            }
            else if (EvenorOdd == 2)
            {
                if (EorO % 2 == 0 || EorO == 0)
                {
                    Console.WriteLine($"Congratulations! The number {EorO} was Even!\n");
                }
                else if (EorO % 2 == 1)
                {
                    Console.WriteLine($"Sorry, the number {EorO} was Odd.\n");
                }
            }
            Console.WriteLine("Do you want to play again? Y/N");
            char ans = Convert.ToChar(Console.ReadLine());
            if (ans == 'Y' || ans == 'y')
            {
                StartMenu();

            }
            else if (ans == 'N' || ans == 'n')
            {
                Console.WriteLine("Thanks for playing.");
                Console.WriteLine("Exit whenever you are ready");
            }
        }

        private static void selectionA()
        {
            Console.WriteLine("Please Enter a number 1-36");
            int number = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int num = rnd.Next(36);

            if (number < 1 || number > 36)
            {
                Console.WriteLine("Invalid Entry");
                selectionA();
            }
            else if (number != num)
            {
                Console.WriteLine("Sorry, those numbers don't match");
                Console.WriteLine($"The winning number is {num}\n");
            }

            else if (number == num)
            {
                Console.WriteLine($"The winning number is {num}");
                Console.WriteLine("Congratulations, you win! Your numbers match!\n");
            }

            
            Console.WriteLine("Do you want to play again? Y/N");
            char ans = Convert.ToChar(Console.ReadLine());
            if (ans == 'Y' || ans == 'y')
            {
                StartMenu();

            }
            else if (ans == 'N' || ans == 'n')
            {
                Console.WriteLine("Thanks for playing.");
                Console.WriteLine("Exit whenever you are ready");
            }


        }
    }
}

