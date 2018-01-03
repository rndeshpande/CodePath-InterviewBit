class Solution {
	List<List<int>> ans;
	public List<List<int>> combine(int A, int B) {
		ans = new List<List<int>>();
		List<int> curr = new List<int>();
		for (int i = 1; i <= A; i++) {
			combine2(A, i, B, curr);
		}
		return ans;
	}

	private void combine2(int A, int st, int B, List<int> curr) {
		if (B - curr.Count > A - st + 1) {
			return;
		}
		curr.Add(st);
		if (curr.Count == B) {
			ans.Add(new List<int>(curr));
			curr.RemoveAt(curr.Count - 1);
			return;
		}
		for (int i = st + 1; i <= A; i++) {
			combine2(A, i, B, curr);
		}
		curr.RemoveAt(curr.Count - 1);
		return;
	}
}
