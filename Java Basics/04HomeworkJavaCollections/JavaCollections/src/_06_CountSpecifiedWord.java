import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _06_CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();
        String word = scanner.next();

        String pat = String.format("(?<=\\W|^)%s(?=\\W|$)",word);
        Pattern pattern = Pattern.compile(pat,Pattern.CASE_INSENSITIVE);
        Matcher matcher = pattern.matcher(line);

        int count = 0;
        while(matcher.find()){
            count++;
        }
        System.out.println(count);
    }
}