import java.util.*;
import java.util.function.BinaryOperator;
import java.util.stream.Collectors;

public class _11_MostFrequentWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] wordsArray = scanner.nextLine().toLowerCase().split("[\\W]+");

        List<String> words = Arrays.asList(wordsArray);

        Map<String,Long> allWords = words.stream()
                .collect(Collectors.groupingBy(w -> w, Collectors.counting()));

        long maxSize = Collections.max(allWords.values());

        TreeMap<String,Long> result = allWords
                .entrySet()
                .stream()
                .filter(x->x.getValue() == maxSize)
                .collect(Collectors.toMap(
                    p->p.getKey(),
                    p->p.getValue(),
                    (a,b)->a,
                    TreeMap::new));

        for (String key : result.keySet()) {
            System.out.printf("%s -> %d times\n", key, maxSize);
        }

    }

}
