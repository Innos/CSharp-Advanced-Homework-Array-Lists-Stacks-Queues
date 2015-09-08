import java.util.Scanner;

public class SymmetricNumbersInRange {
    public static void main(String[] args) {
        System.out.println("Enter starting number[0 <= start <= 999]:");
        Scanner scanner = new Scanner(System.in);
        int start = scanner.nextInt();
        System.out.println("Enter ending number[start <= end <= 999]:");
        int end = scanner.nextInt();

        if(start < 0 || start > 999 || end < 0 || end >  999 || start > end) {

            System.out.println("Incorrect Input");

        }else{

            for (int i = start; i <= end ; i++) {
                if(isPalindrome(i)){
                    System.out.printf("%d ",i);
                }
            }
        }



    }

    private static boolean isPalindrome(int num)
    {
        String number = Integer.toString(num);
        String reversedNumber = new StringBuilder(number).reverse().toString();

        if(number.equals(reversedNumber)) {
            return true;
        }

        return false;
    }
}
