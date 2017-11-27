public class Solution {
	public int lengthOfLastWord(final String a) {
		if (a.length() == 0) {
			return 0;
		}
		String clean = a.trim();
		int length = clean.length();

		int start = 0;
		int end = 0;
		char prevChar = a.charAt(0);

		while (end < length) {
			char c = clean.charAt(end);
			if (c != ' ' && prevChar == ' ') {
				start = end;
			}
			prevChar = c;
			end++;
		}

		return end - start;
	}
}
