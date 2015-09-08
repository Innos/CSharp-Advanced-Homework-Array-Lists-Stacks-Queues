import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class CognateWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();

        String pat = "[a-zA-Z]+";
        Pattern pattern = Pattern.compile(pat);
        Matcher matcher = pattern.matcher(text);

        ArrayList<String> words = new ArrayList<String>();
        while(matcher.find()){
            words.add(matcher.group());
        }

        ArrayList<String> results = new ArrayList<String>();
        boolean hasSolution = false;

        for (int i = 0; i < words.size() ; i++) {
            for (int j = 0; j <words.size() ; j++) {
                if(i!=j){
                    String joined = words.get(i)+ words.get(j);
                    if(words.contains(joined)){
                        String result = String.format("%s|%s=%s\n",words.get(i),words.get(j),joined);
                        if(!results.contains(result)){
                            System.out.printf(result);
                            results.add(result);
                        }
                        hasSolution = true;
                    }
                }
            }
        }
        if(!hasSolution){
            System.out.println("No");
        }
    }
}
