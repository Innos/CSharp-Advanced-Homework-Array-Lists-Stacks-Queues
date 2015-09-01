import com.sun.javafx.scene.layout.region.Margins;

import java.util.Scanner;

public class FormattingNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int a = -1;
        while(a <0 || a > 500){
            System.out.println("Enter an integer[0..500]:");
            a = scanner.nextInt();
        }

        System.out.println("Enter a floating point number:");
        double b = scanner.nextDouble();
        System.out.println("Enter a floating point number:");
        double c = scanner.nextDouble();

        System.out.printf("|%-10X|%s|%10.2f|%-10.3f|",
                a,
                String.format("%10s", Integer.toBinaryString(a)).replace(" ","0"),
                b,
                c);
    }
}
