public class FullHouseWithJokers {
    public static void main(String[] args) {

            String[] cards = new String[] {"2","3","4","5","6","7","8","9","10","J","Q","K","A"};
            char[] suits = new char[] {'\u2663','\u2666','\u2665','\u2660'};

            int count = 0;
            int combinations = 32;
            int mask1 = 1;
            int mask2 = 2;
            int mask3 = 4;
            int mask4 = 8;
            int mask5 = 16;

            for (int firstCardNumber = 0; firstCardNumber < cards.length; firstCardNumber++) {
                for (int secondCardNumber = 0; secondCardNumber < cards.length; secondCardNumber++) {
                    if(firstCardNumber != secondCardNumber){
                        for (int suit1 = 0; suit1 < suits.length; suit1++) {
                            for (int suit2 = suit1+1; suit2 <suits.length ; suit2++) {
                                for (int suit3 = suit2+1; suit3 <suits.length ; suit3++) {
                                    for (int suit4 = 0; suit4 < suits.length; suit4++) {
                                        for (int suit5 = suit4+1; suit5 <suits.length ; suit5++) {
                                            for (int combination = 0; combination <combinations; combination++) {

                                                String card1 = String.format("%s%s",cards[firstCardNumber],suits[suit1]);
                                                String card2 = String.format("%s%s",cards[firstCardNumber],suits[suit2]);
                                                String card3 = String.format("%s%s",cards[firstCardNumber],suits[suit3]);
                                                String card4 = String.format("%s%s",cards[secondCardNumber],suits[suit4]);
                                                String card5 = String.format("%s%s",cards[secondCardNumber],suits[suit5]);

                                                if((mask1 & combination) != 0){
                                                    card1 = "* ";
                                                }
                                                if((mask2 & combination) != 0){
                                                    card2 = "* ";
                                                }
                                                if((mask3 & combination) != 0){
                                                    card3 = "* ";
                                                }
                                                if((mask4 & combination) != 0){
                                                    card4 = "* ";
                                                }
                                                if((mask5 & combination) != 0){
                                                    card5 = "* ";
                                                }

                                                System.out.printf("(%s %s %s %s %s) ",
                                                        card1,
                                                        card2,
                                                        card3,
                                                        card4,
                                                        card5);
                                                count++;
                                            }
                                            System.out.println();
                                        }
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
