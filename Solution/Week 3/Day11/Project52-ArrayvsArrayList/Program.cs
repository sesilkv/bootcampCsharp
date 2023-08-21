using System.Collections;

class Program
{
    static void Main()
    {
        int[] nums = new int[3];
        nums[0] = 10;
        nums[1] = 20;
        nums[2] = 30;
        // nums[3] = 40; // IndexOutOfRangeException - cannot add element beyond array size
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }

        ArrayList arrayList = new ArrayList();
        arrayList.Add(10);
        arrayList.Add("hello");
        arrayList.Add(true);
        int num = (int)arrayList[0];
        string str = (string)arrayList[1];
        bool b = (bool)arrayList[2];
        Console.WriteLine(num);
        Console.WriteLine(str);
        Console.WriteLine(b);
    }
}