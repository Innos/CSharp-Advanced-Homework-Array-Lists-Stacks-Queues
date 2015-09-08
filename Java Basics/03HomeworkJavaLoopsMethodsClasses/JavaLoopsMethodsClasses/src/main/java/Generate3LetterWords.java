import java.util.Scanner;

public class Generate3LetterWords {
    public static void main(String[] args) {

        System.out.println("Enter set of characters:");
        Scanner scanner = new Scanner(System.in);
        char[] characters = scanner.next().toCharArray();

        for (int a = 0; a < characters.length ; a++) {
            for (int b = 0; b < characters.length; b++) {
                for (int c = 0; c < characters.length; c++) {
                    String word = Character.toString(characters[a]) + Character.toString(characters[b]) + Character.toString(characters[c]);
                    System.out.printf("%s ",word);
                }
            }
        }
    }
}
