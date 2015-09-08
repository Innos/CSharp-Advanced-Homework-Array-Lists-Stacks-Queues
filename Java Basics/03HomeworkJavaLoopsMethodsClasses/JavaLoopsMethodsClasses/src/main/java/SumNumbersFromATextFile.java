import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.Scanner;

public class SumNumbersFromATextFile {
    public static void main(String[] args) {

        final String source = "Input.txt";
        try(Scanner scanner = new Scanner(new File(source))) {
            int sum = 0;
            while(scanner.hasNextInt()){
                sum += scanner.nextInt();
            }
            System.out.println(sum);

        }catch (FileNotFoundException ex){
            System.out.println("Error");
        }
    }
}
