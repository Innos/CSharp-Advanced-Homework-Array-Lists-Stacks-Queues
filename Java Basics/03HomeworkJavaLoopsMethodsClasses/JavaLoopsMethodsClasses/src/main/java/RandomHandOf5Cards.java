import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;
import java.util.Scanner;

public class RandomHandOf5Cards {

    private static Random random = new Random();
    private static final int cardsInAHand = 5;

    public static void main(String[] args) {


        String[] cards = new String[] {"2","3","4","5","6","7","8","9","10","J","Q","K","A"};
        char[] suits = new char[] {'\u2663','\u2666','\u2665','\u2660'};

        Scanner scanner = new Scanner(System.in);
        System.out.println("Input number of hands to create:");
        int hands = scanner.nextInt();

        for (int hand = 0; hand < hands; hand++) {

            ArrayList<String> currentHand = new ArrayList<String>();

            while(currentHand.size()< cardsInAHand) {
                String cardNumber = cards[random.nextInt(cards.length)];
                char suit = suits[random.nextInt(suits.length)];
                String currentCard = String.format("%s%s", cardNumber, suit);
                if (!currentHand.contains(currentCard)) {
                    currentHand.add(currentCard);
                }
            }

            System.out.println(currentHand);
            currentHand.clear();
        }
    }
}
