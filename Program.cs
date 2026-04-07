// See https://aka.ms/new-console-template for more information
int a = 10;
int b = 6;

static int Penjumlahan(int a, int b)
{
    return a + b;
}
static int Pengurangan(int a, int b)
{
    return a - b;
}
static int Perkalian(int a, int b)
{
    return a * b;
}
static int Pembagian(int a, int b)
{
    return a / b;
}

Console.WriteLine(a+ "+" +b+ "=" +Penjumlahan(a,b));
Console.WriteLine(a+ "-" +b+ "=" +Pengurangan(a,b));
Console.WriteLine(a+ "*" +b+ "=" +Perkalian(a,b));
Console.WriteLine(a+ "/" +b+ "=" +Pembagian(a,b));
