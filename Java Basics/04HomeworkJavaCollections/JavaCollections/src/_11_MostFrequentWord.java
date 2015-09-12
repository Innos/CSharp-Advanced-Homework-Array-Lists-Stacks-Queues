import java.util.*;
import java.util.function.BinaryOperator;
import java.util.stream.Collectors;

public class _11_MostFrequentWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] wordsArray = scanner.nextLine().toLowerCase().split("[\\W]+");

        List<String> words = Arrays.asList(wordsArray);

        LinkedHashMap<String,Long> allWords = words.stream()
                .collect(Collectors.groupingBy(w -> w, Collectors.counting()))
                .entrySet()
                .stream()
                .sorted(Collections.reverseOrder(Map.Entry.comparingByValue()))
                .collect(Collectors.toMap(
                        p->p.getKey(),
                        p->p.getValue(),
                        throwingMerger(),
                        LinkedHashMap::new));

        long maxSize = allWords.entrySet().stream().findFirst().get().getValue();

        TreeMap<String,Long> result = allWords.entrySet().stream().filter(x->x.getValue() == maxSize).collect(Collectors.toMap(
                p->p.getKey(),
                p->p.getValue(),
                throwingMerger(),
                TreeMap::new));

        for (Map.Entry<String,Long> entry : result.entrySet()) {
            System.out.printf("%s -> %d times\n", entry.getKey(),entry.getValue());
        }

    }

    private static <T> BinaryOperator<T> throwingMerger() {
        return (u, v) -> {
            throw new IllegalStateException(String.format("Duplicate key %s", u));
        };
    }
}
