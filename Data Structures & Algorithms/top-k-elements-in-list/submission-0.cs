public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> count = new();
        foreach(int num in nums){
            if(count.ContainsKey(num)) count[num]++;
            else count[num] = 1;
        }
        
        List<int>[] buckets = new List<int>[nums.Length + 1];
        for (int i = 0; i < buckets.Length; i++)
        {
            buckets[i] = new List<int>();
        }
        foreach(var kvp in count){
            buckets[kvp.Value].Add(kvp.Key);
        }

        List<int> result = new ();
        for(int i = nums.Length; i>0; i--){
     
                                        if(result.Count ==k) break;

        if(buckets[i].Count!=0){
            foreach(int item in buckets[i]){
                                   if(result.Count ==k) break;
            result.Add(item);

            }
        }
        }
        return result.ToArray();
    }
}
