import java.util.*;
import java.util.stream.Collectors;

public class _03_LongestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] words = scanner.nextLine().split(" ");
        ArrayList<String> wordsList = new ArrayList<String>(Arrays.asList(words));



        Comparator<List<String>> orderByDescendingBySize = new Comparator<List<String>>() {
            @Override
            public int compare(List<String> o1, List<String> o2) {
                Integer o2Size = o2.size();
                Integer o1Size = o1.size();
                return o2Size.compareTo(o1Size);
            }
        };

        List<String> result = wordsList
                .stream()
                .collect(Collectors.groupingBy(w -> w))
                .values()
                .stream()
                .sorted(orderByDescendingBySize)
                .findFirst()
                .orElse(null);


        System.out.println(result);
    }
}
