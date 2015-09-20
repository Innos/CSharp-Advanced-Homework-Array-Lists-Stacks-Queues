import java.util.Scanner;

public class _04_LettersChangeNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] entries = scanner.nextLine().split("\\s+");

        double sum = 0;

        for (String entry : entries) {
            char firstLetter = entry.charAt(0);
            char lastLetter = entry.charAt(entry.length() - 1);
            double number = Integer.parseInt(entry.substring(1, entry.length() - 1));

            if (Character.isLowerCase(firstLetter)) {
                number = number * (firstLetter - ('a' - 1));
            } else {
                number = number / (firstLetter - ('A' - 1));
            }

            if (Character.isLowerCase(lastLetter)) {
                number += (lastLetter - ('a' - 1));
            } else {
                number -= (lastLetter - ('A' - 1));
            }

            sum += number;
        }

        System.out.printf("%.2f\n",sum);
    }
}
