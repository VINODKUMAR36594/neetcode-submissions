class Solution {
    public int[] replaceElements(int[] arr) {
        int a[]=new int[arr.length];
        Arrays.fill(a,-1);
        int max=arr[arr.length-1];
        for(int i=arr.length-2;i>=0;i--){
            
                a[i]=max;

                            
                           max=Math.max(max,arr[i]);
        }
        return a;
    }
}