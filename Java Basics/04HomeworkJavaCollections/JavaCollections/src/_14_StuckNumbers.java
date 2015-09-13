import java.util.ArrayList;
import java.util.Scanner;

public class _14_StuckNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int ammount = scanner.nextInt();
        int[] numbers = new int[ammount];
        for (int i = 0; i < ammount; i++) {
            numbers[i] = scanner.nextInt();
        }

        boolean hasAnswer = false;

        for (int a = 0; a < numbers.length; a++) {
            for (int b = 0; b < numbers.length; b++) {

                if (a != b) {
                    for (int c = 0; c < numbers.length; c++) {
                        for (int d = 0; d < numbers.length; d++) {
                            if (a != c &&
                                    a != d &&
                                    b != c &&
                                    b != d &&
                                    c != d) {

                                if (("" + numbers[a] + numbers[b]).equals("" + numbers[c] + numbers[d])) {

                                    System.out.printf("%d|%d==%d|%d\n",
                                            numbers[a],
                                            numbers[b],
                                            numbers[c],
                                            numbers[d]);
                                    hasAnswer = true;
                                }
                            }
                        }
                    }
                }

            }
        }
        if (!hasAnswer) {
            System.out.println("No");
        }
    }
}
