public class FullHouse {
    public static void main(String[] args) {

        String[] cards = new String[] {"2","3","4","5","6","7","8","9","10","J","Q","K","A"};
        char[] suits = new char[] {'\u2663','\u2666','\u2665','\u2660'};

        int count = 0;
        for (int firstCardNumber = 0; firstCardNumber < cards.length; firstCardNumber++) {
            for (int secondCardNumber = 0; secondCardNumber < cards.length; secondCardNumber++) {
                if(firstCardNumber != secondCardNumber){
                    for (int suit1 = 0; suit1 < suits.length; suit1++) {
                        for (int suit2 = suit1+1; suit2 <suits.length ; suit2++) {
                            for (int suit3 = suit2+1; suit3 <suits.length ; suit3++) {
                                for (int suit4 = 0; suit4 < suits.length; suit4++) {
                                    for (int suit5 = suit4+1; suit5 <suits.length ; suit5++) {
                                        System.out.printf("(%s%s %s%s %s%s %s%s %s%s)\n",
                                                cards[firstCardNumber],suits[suit1],
                                                cards[firstCardNumber],suits[suit2],
                                                cards[firstCardNumber],suits[suit3],
                                                cards[secondCardNumber],suits[suit4],
                                                cards[secondCardNumber],suits[suit5]);
                                        count++;
                                    }
                                }
                            }
                        }
                    }
            }
        }

            System.out.printf("%d full houses", count);
        }
    }
}
