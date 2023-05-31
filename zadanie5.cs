int Odleglosc(int x1, int y1, int x2, int y2)
{
    return (int)Math.Round(Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2)));
}

int n;
n = int.Parse(Console.ReadLine());
int kierunek = 90;
int x = 0;
int y = 0;
int odleglosc = 0;
for(int i =0;i <n; i++)
{
    string[] polecenie = Console.ReadLine().Split(' ');
    string p = polecenie[0];
    int w = int.Parse(polecenie[1]);
    switch (p)
    {
        case "np":
            switch (kierunek / 90)
            {
                case 0:
                    y += w;
                    odleglosc += w;
                    break;
                case 1:
                    x += w;
                    odleglosc += w;
                    break;
                case 2:
                    y -= w;
                    odleglosc += w;
                    break;
                case 3:
                    x -= w;
                    odleglosc += w;
                    break;
            }
            break;
        case "sp":
            kierunek +=w;
            if (kierunek > 270)
                kierunek = kierunek % 270;
            break;
        case "sl":
            kierunek -= w;
            if (kierunek < 0)
            {
                kierunek = 360 - Math.Abs(kierunek);
            }
            break;
    }

}
Console.WriteLine($"{odleglosc} {Odleglosc(0, 0, x, y)}");