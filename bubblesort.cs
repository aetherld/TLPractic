int[] number = { 3, 5, 1, -10, 18, 4, 2, 8 };
int temp;

for (int i = 0; i < number.Length; i++)
{
    for (int j = 0; j < number.Length - 1 - i; j++)
    {
        if (number[j] > number[ j +1 ])
        {
            temp = number[j];
            number[j] = number[j + 1];
            number[j + 1] = temp;
        }
    }
}
for (int i = 0; i < number.Length; i++)
{
    Console.WriteLine(number[i]);
}