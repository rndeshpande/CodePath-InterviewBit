public int searchInsert(ArrayList<Integer> a, int b) {

	int start = 0;
	int end = a.size() - 1;
	int mid ;

	while (start <= end) {
		mid = (start + end) / 2;
		if (a.get(mid) == b) {
			return mid;
		} else if (a.get(mid) < b) {
			start = mid + 1;
		} else {
			end = end - 1;
		}
	}
	return start;
}