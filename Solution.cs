public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        int i = s.Length - 1;
        for (int j = g.Length - 1; j >= 0; j--) {
            if (i >= 0 && s[i] >= g[j]) i--;
        }

        return s.Length - 1 - i;
    }
}