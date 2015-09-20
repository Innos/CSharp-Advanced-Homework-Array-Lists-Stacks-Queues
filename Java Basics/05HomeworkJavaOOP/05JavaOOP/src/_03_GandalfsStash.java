import java.util.Scanner;

public class _03_GandalfsStash {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int moodNumber = Integer.parseInt(scanner.nextLine());

        String[] food = scanner.nextLine().toLowerCase().split("[^a-zA-Z]+");

        for (String meal : food) {
            moodNumber += calculateValue(meal);
        }

        String mood = "";
        if(moodNumber < -5){
            mood = "Angry";
        }else if(moodNumber <0 && moodNumber >= -5){
            mood = "Sad";
        }else if(moodNumber >= 0 && moodNumber <= 15){
            mood = "Happy";
        }else if(moodNumber > 15){
            mood = "Special JavaScript mood";
        }

        System.out.println(moodNumber);
        System.out.println(mood);

    }

    private static int calculateValue(String food){
        switch (food){
            case "cram": return 2;
            case "lembas": return 3;
            case "apple" : return 1;
            case "melon" : return 1;
            case "honeycake" : return 5;
            case "mushrooms" : return -10;
            default: return -1;
        }
    }
}
