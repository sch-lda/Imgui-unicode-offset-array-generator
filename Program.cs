using System;

public class Unicodegenerator
{
    public static int[] ChsToUnicode(string chstwraw)
    {
        int[] unicodeArray = new int[chstwraw.Length];

        for (int i = 0; i < chstwraw.Length; i++)
        {
            unicodeArray[i] = (int)chstwraw[i];
        }

        return unicodeArray;
    }

    public static void Main()
    {
        string currentYim = "res\\currentYim.txt";

        string chstwraw = File.ReadAllText(currentYim);
        int[] unicodeArray = ChsToUnicode(chstwraw);

        Array.Sort(unicodeArray);
        bool hasDuplicates = CheckDuplicates(unicodeArray);
        if (hasDuplicates)
        {
            Console.WriteLine("警告，存在重复元素");
        }

        for (int i = 0; i < unicodeArray.Length; i++)
        {
            if (i ==0)
            {
                Console.Write(unicodeArray[i] - 19968);
                Console.Write(", ");
            }
            else
            {
                Console.Write(unicodeArray[i] - unicodeArray[i-1]);
                Console.Write(", ");
            }

        }
    }

    public static bool CheckDuplicates(int[] array)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int element in array)
        {
            if (set.Contains(element))
            {
                char dplcChar = Convert.ToChar(element);
                string dplcText = dplcChar.ToString();
                Console.WriteLine("重复元素: " + element + " " + dplcText);
                return true;
            }

            set.Add(element);
        }

        return false;
    }
}
