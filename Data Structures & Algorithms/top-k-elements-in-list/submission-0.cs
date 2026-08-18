public class Solution {
class Pair{
    public int n,fr;
    public Pair(int a,int b){
        this.n=a;
        this.fr=b;
    }

}
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> map=new Dictionary<int,int>();
        foreach(int n in nums){
            if(!map.ContainsKey(n)){
                map[n]=0;
            }
            map[n]+=1;
        }
       PriorityQueue<Pair, int> pq = new PriorityQueue<Pair, int>();

        foreach (var e in map)
        {
            pq.Enqueue(new Pair(e.Key, e.Value), -e.Value);
        }

        int[] ans = new int[k];

        for (int i = 0; i < k; i++)
        {
            ans[i] = pq.Dequeue().n;
        }

        return ans;

    }
}