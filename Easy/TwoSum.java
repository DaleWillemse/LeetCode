import java.util.*;

class TwoSum {
    public static void main(String[] args) {

        int[] nums = { 3, 2, 4 };
        int target = 6;
        System.out.println(Arrays.toString(twoSum(nums, target)));

    }

    static int[] twoSum(int[] nums, int target) {
        int[] answer = new int[2];
        HashMap<Integer, Integer> values = new HashMap<>();
        for (int i = 0; i < nums.length; i++) {
            if (values.containsKey(target - nums[i])) {
                answer[0] = i;
                answer[1] = values.get(target - nums[i]);
                return answer;
            }
            values.put(nums[i], i);
        }
        return answer;
    }
}