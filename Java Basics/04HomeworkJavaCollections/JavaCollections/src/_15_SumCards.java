import java.util.*;

public class _15_SumCards {
    public static void main(String[] args) {
        String[] cards = {"X","X","2","3","4","5","6","7","8","9","10","X","J","Q","K","A"};
        Scanner scanner = new Scanner(System.in);
        String[] hand = scanner.nextLine().split(" ");
        Integer[] cardValues = new Integer[hand.length];
        for (int i = 0; i <hand.length ; i++) {
            cardValues[i] = (Arrays.asList(cards).indexOf(hand[i].substring(0,hand[i].length()-1)));
        }

        int temp = 0;
        int sum = 0;
        int multiplier = 1;
        temp += cardValues[0];
        for (int i = 1; i <cardValues.length ; i++) {
            if(cardValues[i] == cardValues[i-1]){
                multiplier = 2;
            }else{
                sum += temp * multiplier;
                temp = 0;
                multiplier = 1;
            }
            temp += cardValues[i];
        }
        sum += temp * multiplier;

        System.out.println(sum);
    }
}