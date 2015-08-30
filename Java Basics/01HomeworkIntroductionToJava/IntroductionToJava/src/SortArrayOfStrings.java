import java.util.Scanner;

public class SortArrayOfStrings {
    public static void main(String[] args) {
        System.out.println("Enter number of strings:");
        Scanner scanner = new Scanner(System.in);
        int numberOfStrings = scanner.nextInt();
        String[] strings = new String[numberOfStrings];
        for (int i = 0;i < numberOfStrings; i++){
            strings[i] = scanner.next();
        }
        sortList(strings);

        for (int i = 0; i < strings.length; i++){
            System.out.println(strings[i]);
        }
    }

    private static void sortList(String[] array){
        for (int i = 0; i < array.length - 1; i++)
        {
            int index = i;
            for (int j = i + 1; j < array.length; j++)
                if (array[j].compareTo(array[index])< 0) {
                    index = j;
                }
            String smallerNumber = array[index];
            array[index] = array[i];
            array[i] = smallerNumber;
        }
    }
}
