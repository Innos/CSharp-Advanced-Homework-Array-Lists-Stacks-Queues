import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _05_CountAllWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();

        String pat = "(?<=\\W|^)\\w+(?=\\W|$)";
        Pattern pattern = Pattern.compile(pat);
        Matcher matcher = pattern.matcher(line);

        int count = 0;
        while(matcher.find()){
            count++;
        }
        System.out.println(count);
    }
}
