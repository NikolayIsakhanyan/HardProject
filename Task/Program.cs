
internal class Program
{
    private static void Main(string[] args)
    {
        string[] names = { "hdvvhh", "Dsadxxx", "Hjkldsxfa", "Dsafasa", "xxddxx", "hjuya", "qwdddqxxexcz", "Dvchfgsa", "Htryrwtreg", "Dsddaxbvcbxvc" };
        var x = Test(names);
        Console.WriteLine(x);
    }

    static char Test(string[] names)
    {
        var chars = Chars();
        int[] ints= new int[chars.Length];
        for (int i = 0; i < names.Length; i++)
        {
            var s=names[i].ToUpper();
            for (int j = 0; j < s.Length; j++)
            {
                for (int n = 0; n < chars.Length; n++)
                {
                    if (chars[n] == s[j])
                    {
                        ints[n] += 1;
                        break;
                    }
                }
            }
        }

        int max = 0;
        int index = 0;

        for (int i = 0; i < ints.Length; i++)
        {
            if (ints[i] > max)
            {
                max = ints[i];
                index = i;
            }
        }
        return chars[index];
    }

    static char[] Chars()
    {
        char[] chars = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        return chars;
    }
}