int n;
n = int.Parse(Console.ReadLine());
Dictionary<int, int> dict = new Dictionary<int, int>();
for(int i = 0; i<=100; i++)
{
    dict.Add(i, 0);
}
for(int i = 0; i<n; i++)
{
    int[] dane = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
    for (int k = 0; k < dane[2]; k++)
    {
        dict[k + dane[0]] = dane[1];
    }
}
int dlu = 0;
for(int i = 0; i<100; i++)
{
    dlu += Math.Abs(dict[i] - dict[i+1]);
    dlu++;
}
Console.WriteLine(dlu);