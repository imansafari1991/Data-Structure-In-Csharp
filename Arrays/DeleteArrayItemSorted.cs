namespace Arrays;

public class DeleteArrayItemSorted
{
    int DeleteElement(ref int[] a, int n, int key)
    {
        int p;
        BinarySearchRecursive binarySearchRecursive=new BinarySearchRecursive();
        p=binarySearchRecursive.bSearch(a, 0, n - 1, key);
        if (p == -1)
        {
            Console.WriteLine("Not Found");
            return n;
        }

        for (int i = p; i < n-1; i++)
        {
            a[i] = a[i+1];
        }

        return n - 1;
    }

    public int Do()
    {
        int[] a = { 5, 10, 20, 30, 50, 60 };
        int n = a.Length;
        int key = 30;
        
     var nPrime= DeleteElement(ref a, n, key);
        a = a[0..nPrime];
     foreach (var i in a)
     {
      Console.WriteLine(i);   
     }
     
     return nPrime;
    }
}