namespace Arrays;

public class LinearSearch
{
    public int Find(int[] a, int n, int key)
    {
        for (int i = 0; i <= n - 1; i++)
            if (key == a[i])
                return i;

        return -1;
    }


    public void Do()
    {
        int[] a = { 17, 8, 13, 20, 6, 14 };
        var n = a.Length;


        int key = 8;
        
       var p = Find(a, n, key);

        if (p == -1)
            Console.WriteLine("Not Found ");
        else
            Console.WriteLine(p);
    }
}