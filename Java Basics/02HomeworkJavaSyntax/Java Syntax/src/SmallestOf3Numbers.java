import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.Scanner;

public class SmallestOf3Numbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        ArrayList<Double> numbers = new ArrayList<Double>();
        System.out.println("Input 3 numbers:");
        numbers.add(scanner.nextDouble());
        numbers.add(scanner.nextDouble());
        numbers.add(scanner.nextDouble());

        double result = Collections.min(numbers);

        System.out.printf("%.2f",result);
    }
}
