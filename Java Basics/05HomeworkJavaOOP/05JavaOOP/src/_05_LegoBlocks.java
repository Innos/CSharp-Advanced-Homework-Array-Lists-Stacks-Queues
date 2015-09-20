import java.util.*;
import java.util.stream.Collectors;

public class _05_LegoBlocks {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int numberOfBlocks = 2;
        int rows = Integer.parseInt(scanner.nextLine());

        ArrayList<List<Integer>> block1 = new ArrayList<>();

        for (int block = 0; block < numberOfBlocks; block++) {
            for (int row = 0; row < rows; row++) {
                if (block == 0) {
                    block1.add(Arrays
                            .stream(scanner.nextLine()
                                    .trim()
                                    .split("\\s+"))
                            .map(Integer::parseInt)
                            .collect(Collectors.toList()));
                } else {
                    List<Integer> listToAdd = Arrays
                            .stream(scanner.nextLine()
                                    .trim()
                                    .split("\\s+"))
                            .map(Integer::parseInt)
                            .collect(Collectors.toList());
                    Collections.reverse(listToAdd);
                    block1.get(row).addAll(listToAdd);
                }
            }
        }

        int rowLength = block1.get(0).size();

        boolean hasSolution = true;

        for (int i = 0; i < rows; i++) {
            if (block1.get(i).size() != rowLength) {
                hasSolution = false;
                break;
            }
        }

        if (hasSolution) {
            block1.forEach(l -> System.out.println(l));
        } else {
            int allCells = block1.stream().map(x -> x.size()).reduce(0, (a, b) -> a + b);
            System.out.printf("The total number of cells is: %d", allCells);
        }

    }
}
