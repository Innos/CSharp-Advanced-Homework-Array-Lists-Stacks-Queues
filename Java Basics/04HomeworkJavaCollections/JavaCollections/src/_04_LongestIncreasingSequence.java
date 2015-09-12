import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class _04_LongestIncreasingSequence {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        List<Integer> numbers = Arrays.asList(scanner.nextLine().split(" "))
                .stream()
                .map(x -> Integer.parseInt(x))
                .collect(Collectors.toList());

        // If sequence has 0 or 1 element
        if(numbers.size() <= 1){
            System.out.println(numbers);
            System.out.printf("Longest: %s",numbers);
        }

        ArrayList<Integer> currentSequence = new ArrayList<>();
        currentSequence.add(numbers.get(0));
        ArrayList<Integer> longestSequence = new ArrayList<>(currentSequence);
        for (int i = 1; i <numbers.size() ; i++) {
            if(numbers.get(i) > numbers.get(i-1)){
                currentSequence.add(numbers.get(i));
            }else{
                System.out.println(currentSequence);
                currentSequence.clear();
                currentSequence.add(numbers.get(i));
            }
            if(currentSequence.size() > longestSequence.size()){
                longestSequence = new ArrayList<>(currentSequence);
            }
        }
        System.out.println(currentSequence);
        System.out.printf("Longest: %s", longestSequence);
    }
}
