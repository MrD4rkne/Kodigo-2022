using System.Linq;

int n;
n = int.Parse(Console.ReadLine());
List<string> ciagi = new List<string>();
for(int i = 0; i < n; i++)
{
    ciagi.Add(Console.ReadLine());
}
int nmaks = ciagi[0].Length;
List<string> podciagi = new List<string>();
for (int i = 1; i <= nmaks; i++)
{
    for (int j = 0; j < nmaks - i+1; j++)
    {
        if (j + i > nmaks)
            continue;
        string podciag = ciagi[0].Substring(j, i);
        bool ist = true;
        for(int k = 1; k<n; k++)
        {
            int index = ciagi[k].IndexOf(podciag);
            if (index < 0)
            {
                ist = false;
                break;
            }
        }
        if (ist)
            podciagi.Add(podciag);
    }
}
//var posortowane = podciagi.OrderBy(x => x.Value);
if (podciagi.Count == 0)
    return;
int maks = podciagi.Max(x => x.Length);
var najdluzsze = podciagi.Where(x => x.Length == maks);
Console.WriteLine(najdluzsze.First());
//var najdluzsze
