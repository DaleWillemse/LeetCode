public class ReverseInteger {
    public static void main(String[] args) {
        int input = 1534236469;
        System.out.println(reverse(input));
    }

    static int reverse(int x) {

        int r = 0;
        long answer = 0;

        while (x != 0) {
            r = x % 10;
            x = x / 10;
            answer = answer * 10 + r;
        }

        if (answer > Math.pow(2, 31) - 1 || answer < -(Math.pow(2, 31))) {
            return 0;
        }

        return (int) answer;
    }
}
