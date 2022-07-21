using bing_test;
//Prints the game board
void print(int rows, int colums, Card game)
{
    //Console.WriteLine("===========================");
    for (int i = 0; i < rows; i++)
    {
        Console.WriteLine(" ");
        for (int j = 0; j < colums; j++)
        {
            if (game.ReturnN(i, j).marked == true)
            {
                Console.Write("x" + " ");
            }
            else
            {
                Console.Write(game.ReturnN(i, j).number + " ");
            }
        }
    }
    Console.WriteLine(" ");
    Console.WriteLine("===========================");
}

int score=0;
int max = 60;
int rows = 3;
int columns = 5;
Card game = new Card(rows, columns, max);

print(3, 5, game);
Rand numbers = new Rand(max); //crates a new list of numbers 0 to max
numbers.Suffle(); //shuffles the list
for (int i = 0; i < 30; i++)
{
    int draw = numbers.draw(); //draws a number from the end of the list
    game.Mark(draw); //marks the number on the board
    Console.WriteLine("Draw #" + (i + 1) +" : "+draw);
    print(3, 5, game);   
}
//Point calculation
if (game.CheckBingo())
{
    Console.WriteLine("BINGO");
    score += 1500;
}
else
{
    for (int j = 0; j < rows; j++)
        if (game.CheckRow(j))
            score += 100;
}
Console.WriteLine("Score: " + score);