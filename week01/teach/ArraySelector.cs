public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var intResult = new int[select.Length];
        for (int i = 0; i < select.Length; i++)
        {
            if (select[i] == 1)
            {
                intResult[i] = list1[i % list1.Length];  // Use modulo to wrap around index
            }
            else if (select[i] == 2)
            {
                intResult[i] = list2[i % list2.Length];  // Use modulo to wrap around index
            }
        }
    return intResult; // Ensure this is outside of the for loop and is the last statement in the method
    }



}