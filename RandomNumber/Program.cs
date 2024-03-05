
Random rnd  = new Random();

int ayRandomNum;

int randomsum = 0;

for (int i = 0; i < 7; i++)
{
    ayRandomNum = rnd.Next(0, 11); // 0 - 10
    randomsum = randomsum + ayRandomNum;
    Console.WriteLine($"My random number is: {ayRandomNum}");
}

Console.WriteLine($"random sum total: {randomsum}");