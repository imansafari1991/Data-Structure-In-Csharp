namespace Arrays;

public class DeleteArrayItemUnSorted
{
    int DeleteElement(ref int[] a, int n, int key)
    {
        int p;
        LinearSearch linearSearch = new LinearSearch();
        p = linearSearch.Find(a, n, key);
        if (p == -1)
        {
            Console.WriteLine("Not Found");
            return n;
        }

        for (int i = p; i < n - 1; i++)
        {
            a[i] = a[i + 1];
        }

        return n - 1;
    }

    public int Do()
    {
        int[] a = { 5, 30, 20, 15, 250, 60 };
        int n = a.Length;
        int key = 20;
        var nPrime = DeleteElement(ref a, n, key);
        a = a[0..nPrime];
        foreach (var i in a)
        {
            Console.WriteLine(i);
        }
        return nPrime;
    }
}