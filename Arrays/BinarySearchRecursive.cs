namespace Arrays;

public class BinarySearchRecursive
{
    public int bSearch(int[] a, int low, int high, int key)
    {
        int mid;
        if (low <= high)
        {
            mid=low+(high-low)/2;
            if (key == a[mid]) return mid;

            if (key < a[mid]) return bSearch(a, low, mid - 1, key);

            if (key > a[mid]) return bSearch(a, mid + 1, high, key);
        }
        return -1;
    }

    public void Do()
    {
        int[] a= { 6, 8, 9, 12, 16, 18, 19 };
        int n = a.Length;
        int key = 16;
        int p = bSearch(a, 0, n - 1, key);
        Console.WriteLine(p);
    }

}