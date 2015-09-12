import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _08_ExtractEmails {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();

        String pat = "(?<=\\s|^)([^\\W_][\\w.-]*[^\\W_]|[^\\W_])@[^\\W_](([a-zA-Z-]*[a-zA-Z]+|[a-zA-Z]*)\\.([a-zA-Z]+[a-zA-Z-]*|[a-zA-Z]*))+[^\\W_]\\b";
        Pattern pattern = Pattern.compile(pat);
        Matcher matcher = pattern.matcher(text);

        while (matcher.find()){
            System.out.println(matcher.group());
        }
    }
}
