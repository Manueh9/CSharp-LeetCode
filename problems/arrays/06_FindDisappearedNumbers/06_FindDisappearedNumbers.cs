namespace src.problems.arrays
{
    public class FindDisappearedNumbers
    {
        public static void Run()
        {
            FindDisappearedNumber([4,3,2,7,8,2,3,1]);
        }
        
        public static IList<int> FindDisappearedNumber(int[] nums)
        {
            List<int> missing = new List<int>();
            int[] numsOrdered = nums.OrderBy(x => x).ToArray();
            
            for (int i = 0; i < numsOrdered.Length; i++)
            {
                if (!numsOrdered.Contains(i + 1))
                {
                    missing.Add(i + 1);
                }
            }
            
            Console.WriteLine(string.Join(",", missing));
            return missing;
        }    
    }
}