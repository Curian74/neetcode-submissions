class Solution {
    /**
     * @param {string} s
     * @return {number}
     */
    lengthOfLongestSubstring(s: string): number {
        const set = new Set();
        let l = 0;
        let res = 0;
        for (let r = 0; r < s.length; r++) {
            while (set.has(s[r])) {
                set.delete(s[l]);
                l++;
            }
            let w = r - l + 1;
            res = Math.max(w, res);
            set.add(s[r]);
        }

        return res;
    }
}
