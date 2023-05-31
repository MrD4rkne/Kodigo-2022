int n;
n = int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    string line = Console.ReadLine();
    int[] lista = line.Split(' ').Select(x => int.Parse(x)).ToArray();
    bool czyk = false;
    int se = lista[0] + lista[1] + lista[2];
    int sk = lista[3] + lista[4] + lista[5];
    bool czyI = se > sk;
    if (lista[0] > lista[3])
    {
        czyk = true;
    }
    else
    {
        if (lista[0] == lista[3])
        {
            if (lista[1] > lista[4])
                czyk = true;
            else
            {
                if (lista[1] == lista[4])
                {
                    if (lista[2] > lista[5])
                        czyk = true;
                }
            }
        }
    }
    if (czyk && czyI)
        Console.WriteLine("obie");
    else
    {
        if(czyk && !czyI)
            Console.WriteLine("kolor");
        else
        {
            if (!czyk && czyI)
                Console.WriteLine("liczba");
            else
                Console.WriteLine("żadna");
        }
    }
}