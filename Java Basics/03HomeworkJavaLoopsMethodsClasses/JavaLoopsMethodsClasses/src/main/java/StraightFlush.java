import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class StraightFlush {
    public static void main(String[] args) {

        String[] cards = {"2","3","4","5","6","7","8","9","10","J","Q","K","A"};

        Scanner scanner = new Scanner(System.in);
        String pattern = "(\\d{1,2}|\\w)(\\w)";

        String line = scanner.nextLine();
        Pattern pat = Pattern.compile(pattern);
        Matcher matcher = pat.matcher(line);

        LinkedHashMap<String,TreeSet<Integer>> hand = new LinkedHashMap<>();
        while(matcher.find()){
            int card = Arrays.asList(cards).indexOf(matcher.group(1));
            String suit = matcher.group(2);

            if(!hand.containsKey(suit)){
                hand.put(suit,new TreeSet<>());
            }

            hand.get(suit).add(card);
        }

        boolean hasSolution = false;

        for (String suit : hand.keySet()) {
            for (Integer card : hand.get(suit)) {
                if(hand.get(suit).containsAll(Arrays.asList(card+1,card+2,card+3,card+4))){
                    String card1 = String.format("%s%s",cards[card],suit);
                    String card2 = String.format("%s%s",cards[card+1],suit);
                    String card3 = String.format("%s%s",cards[card+2],suit);
                    String card4 = String.format("%s%s",cards[card+3],suit);
                    String card5 = String.format("%s%s",cards[card+4],suit);

                    System.out.printf("[%s, %s, %s, %s, %s]\n",
                            card1,
                            card2,
                            card3,
                            card4,
                            card5);

                    hasSolution = true;
                }
            }
        }

        if(!hasSolution){
            System.out.println("No Straight Flushes");
        }
    }
}
