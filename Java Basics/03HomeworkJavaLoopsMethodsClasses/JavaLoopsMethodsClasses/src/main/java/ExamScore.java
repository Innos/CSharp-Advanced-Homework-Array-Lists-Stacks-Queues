import javax.swing.*;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ExamScore {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String namePattern = "[a-zA-Z]+ [a-zA-Z]+";
        String scorePattern = "(?<= )\\d+(?= )";
        String gradePattern = "(?<= )\\d\\.\\d{2}(?= )";

        Pattern namePat = Pattern.compile(namePattern);
        Pattern scorePat = Pattern.compile(scorePattern);
        Pattern gradePat = Pattern.compile(gradePattern);

        Map<Integer,TreeMap<String,Double>> scores = new TreeMap<Integer,TreeMap<String, Double>>();

        while(scanner.hasNextLine()){
            String line = scanner.nextLine();

            if(line.equals("")){
                break;
            }

            Matcher nameMatcher = namePat.matcher(line);
            Matcher scoreMatcher = scorePat.matcher(line);
            Matcher gradeMatcher = gradePat.matcher(line);

            while(nameMatcher.find() && scoreMatcher.find() && gradeMatcher.find()){
                String name = nameMatcher.group();
                int score = Integer.parseInt(scoreMatcher.group());
                double grade = Double.parseDouble(gradeMatcher.group());

                if(!scores.containsKey(score)){
                    scores.put(score,new TreeMap<>());
                }
                scores.get(score).put(name,grade);
            }
        }

        scores.forEach((score,student)-> System.out.printf("%d -> %s; avg=%.2f\n",
                score,
                student.keySet(),
                student
                        .values()
                        .stream()
                        .mapToDouble(g->g)
                        .average()
                        .getAsDouble()));

    }
}
