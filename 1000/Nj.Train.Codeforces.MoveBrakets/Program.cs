int ncases = int.Parse(Console.ReadLine());

List<dynamic> cases = new();
for (int i = 1; i <= ncases; i++)
{
    int num = int.Parse(Console.ReadLine());
    string data = Console.ReadLine();
    cases.Add(new { Num = num, Data = data });
}

foreach (dynamic @case in cases) Console.WriteLine(Res.Resolve(@case.Data));

internal class Res
{
    public static int Resolve(string data)
    {
        while (data.Contains("()"))
        {
            data = data.Replace("()", "");
            ;
        }

        return data.Length / 2;
    }
}