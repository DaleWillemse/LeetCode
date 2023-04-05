
public class Palindrome {
    public static void main(String[] args) {
        boolean x = isPalindrome(523253);
        System.out.println(x);
    }

    static public boolean isPalindrome(int x) {

        String numberString = Integer.toString(x);
        char[] numberArray = numberString.toCharArray();

        for (int i = 0; i < numberArray.length; i++) {
            if (numberArray[i] != numberArray[(numberArray.length - 1) - i]) {
                return false;
            }
        }
        return true;
    }
}