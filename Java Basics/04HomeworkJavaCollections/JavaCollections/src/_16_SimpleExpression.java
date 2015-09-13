import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _16_SimpleExpression {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine().replace(" ","");

        String pat = "[-+]*(\\d+\\.\\d+|\\d+)";
        Pattern pattern = Pattern.compile(pat);
        Matcher matcher = pattern.matcher(line);
        ArrayList<BigDecimal> numbers = new ArrayList<>();

        while(matcher.find()){
            numbers.add(new BigDecimal(matcher.group()));
        }

        System.out.printf("%.7f", numbers.stream().reduce(BigDecimal.ZERO, BigDecimal::add));
    }
}
