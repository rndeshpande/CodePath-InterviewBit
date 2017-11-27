public class Solution {
	public int isPalindrome(String a) {
		String clean = removeNonAlphanumeric(a).toUpperCase();
		String reverse = reverseString(clean);

		return clean.equals(reverse) ? 1 : 0;

	}

	public String removeNonAlphanumeric(String a) {
		return a.replaceAll("[^A-Za-z0-9 ]", "").replaceAll("\\s+", "");
	}

	public String reverseString(String a) {
		return new StringBuilder(a).reverse().toString();
	}
}
