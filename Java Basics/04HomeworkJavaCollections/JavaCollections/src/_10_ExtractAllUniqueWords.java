import java.util.*;
import java.util.stream.Collectors;

public class _10_ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] words = scanner.nextLine().toLowerCase().split("[\\W]+");

        Set<String> result = new TreeSet<String>(Arrays.asList(words));

        System.out.println(String.join(" ", result.stream().sorted().map(x -> x.toString()).collect(Collectors.toList())));
    }
}
