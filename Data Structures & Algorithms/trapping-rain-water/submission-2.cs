public class Solution {
    public int Trap(int[] h) {
        int n = h.Length - 1;

        int[] l = new int[n + 1];
        int[] r = new int[n + 1];

        l[0] = h[0];

        for (int i = 1; i <= n; i++) {
            l[i] = Math.Max(l[i - 1], h[i]);
        }

        r[n] = h[n];

        for (int i = n - 1; i >= 0; i--) {
            r[i] = Math.Max(r[i + 1], h[i]);
        }

        int sum = 0;

        for (int i = 0; i <= n; i++) {
            sum += Math.Min(l[i], r[i]) - h[i];
        }

        return sum;
    }
}