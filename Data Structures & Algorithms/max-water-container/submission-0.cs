public class Solution {
    public int MaxArea(int[] heights) {
        // int[] l=new int[heights.Length];
        // int[] r=new int[heights.Length];
        // l[0]=heights[0];
        // for(int i=1;i<heights.Length;i++){
        //     l[i]=Math.max(l[i-1],heights[i]);
        // }
        //  r[heights.Length-1]=heights[heights.Length-1];
        // for(int i=heights.Length-2;i>=0;i--){
        //     r[i]=Math.max(r[i+1],heights[i]);
        // }
        // for(int )
int i=0,j=heights.Length-1;
int max=0;
while(i<=j){
    int b=Math.Min(heights[i],heights[j]);
    max=Math.Max(b*(j-i),max);
    if(heights[i]<heights[j]){
        i++;
    }
    else{
        j-=1;
    }
}
return max;

        
    }
}
