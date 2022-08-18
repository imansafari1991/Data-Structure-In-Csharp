namespace Arrays;

public class InsertSorted
{
    int Insert(int[] a, int key, int n, int c)
    {
        if (n >= c)
            return n;

        int i;
        for (i = n - 1; (i >= 0 && a[i] > key); i--)
            a[i + 1] = a[i];

        a[i + 1] = key;
        return (n + 1);
    }

  public int Do()
    {
        int[] a =new int[10]{ 1, 3, 4, 6, 8 ,0,0,0,0,0};

        int key = -7;
        int n = 5;

        n = Insert(a, key, n, 10);

        for (int i = 0; i < n; i++)
            Console.WriteLine(a[i]);
        return n;
    }
    
}