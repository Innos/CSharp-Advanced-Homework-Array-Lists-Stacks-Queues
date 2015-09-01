import java.util.Scanner;

public class CountOfEqualBitPairs {
    public static void main(String[] args) {
        System.out.println("Enter an integer:");
        Scanner scanner = new Scanner(System.in);
        String binary = Integer.toBinaryString(scanner.nextInt());
        char[] numberAsBinary = binary.toCharArray();
        int binaryPairs = 0;
        for (int i = 0;i < numberAsBinary.length - 1;i++){
            char currentChar = numberAsBinary[i];
            char nextChar = numberAsBinary[i+1];
            if(currentChar ==  nextChar){
                binaryPairs++;
            }
        }

        System.out.println(binaryPairs);
    }
}
