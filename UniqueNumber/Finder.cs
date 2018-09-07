
namespace UniqueNumber
{
    class Finder
    {
        public int singleNumber(int[] nums)
        {
            int once = 0; int twice = 0; int threes; int x = 0;
            int i = 0;
            foreach (int num in nums)
            {               
                    x = nums[i];
                    twice |= once & x; //add it to twice if it exists in once
                    once ^= x; //it exists in once, remove it, otherwise, add it
                    threes = once & twice;  //if x is in once and twice, add it to Threes.
                                            // and thus 
                    once &= ~threes; //remove x from once
                    twice &= ~threes; //remove x from twice
                i++;              
            }        
            return once;
        }
    }
}
