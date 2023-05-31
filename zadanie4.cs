int S, W;
int[] a = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
S = a[0];
W = a[1];

List<Punkt> Straznicy = new List<Punkt>();
int Odleglosc(Punkt a, Punkt b)
{
    int rx = Math.Abs(a.x - b.x);
    int ry = Math.Abs(a.y - b.y);
    return Math.Max(rx, ry);
}


List<Punkt> Wrogowie = new List<Punkt>();
for (int i = 0; i<S; i++)
{
    int[] wpis = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
    Punkt p = new Punkt();
    p.x = wpis[0];
    p.y = wpis[1];
    Straznicy.Add(p);

}
for (int i = 0; i < W; i++)
{
    int[] wpis = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
    Punkt p = new Punkt();
    p.x = wpis[0];
    p.y = wpis[1];
    Wrogowie.Add(p);

}

for(int i = 0; i < W; i++)
{
    Punkt p = Wrogowie[i];
    int minOdl = 1000000;
    for(int j = 0; j < S; j++)
    {
        int odl = Odleglosc(p, Straznicy[j]);
        if (odl < minOdl)
            minOdl = odl;
    }
    Console.WriteLine(minOdl);
}



struct Punkt
{
    public int x;
    public int y;
}