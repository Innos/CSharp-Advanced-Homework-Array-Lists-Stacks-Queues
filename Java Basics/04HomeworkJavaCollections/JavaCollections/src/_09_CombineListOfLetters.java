import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class _09_CombineListOfLetters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        char[] charArray1 = scanner.nextLine().replace(" ","").toCharArray();
        List<Character> charList1 = new ArrayList<Character>();
        for (char c : charArray1) {
            charList1.add(c);
        }

        char[] charArray2 = scanner.nextLine().replace(" ","").toCharArray();
        ArrayList<Character> charList2 = new ArrayList<Character>();
        for (char c : charArray2) {
            charList2.add(c);
        }
        charList2.removeAll(charList1);

        charList1.addAll(charList2);
        charList1.forEach(w -> System.out.printf("%s ", w));
        System.out.println();
    }
}
