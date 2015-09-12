import java.util.*;
import java.util.stream.Collectors;

public class _02_SequencesOfEqualStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] words = scanner.nextLine().split(" ");
        ArrayList<String> wordsList = new ArrayList<String>(Arrays.asList(words));
        LinkedHashMap<String,List<String>> results = wordsList
                .stream()
                .collect(Collectors.groupingBy(w -> w, LinkedHashMap::new, Collectors.toCollection(ArrayList::new)));

        for (List<String> repeatingWords : results.values()) {
            System.out.println(repeatingWords);
        }
    }
}
