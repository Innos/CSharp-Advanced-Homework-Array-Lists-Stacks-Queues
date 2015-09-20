import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _06_UserLogs {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String ipPat = "(?<=IP=)[^\\s]+(?=\\s)";
        String userPat = "(?<=user=)[^\\s]+(?=$)";

        TreeMap<String, LinkedHashMap<String, Integer>> users = new TreeMap<String, LinkedHashMap<String, Integer>>();

        Pattern ipPattern = Pattern.compile(ipPat);
        Pattern userPattern = Pattern.compile(userPat);

        String line = scanner.nextLine().trim();
        while (!line.equals("end")) {

            Matcher ipMatcher = ipPattern.matcher(line);
            Matcher userMatcher = userPattern.matcher(line);

            ipMatcher.find();
            userMatcher.find();

            String ip = ipMatcher.group();
            String user = userMatcher.group();

            if (!users.containsKey(user)) {
                users.put(user, new LinkedHashMap<>());
            }
            if (!users.get(user).containsKey(ip)) {
                users.get(user).put(ip, 0);
            }
            int previousNumberOfIPs = users.get(user).get(ip);
            users.get(user).put(ip, previousNumberOfIPs + 1);

            line = scanner.nextLine();
        }

        for (Map.Entry<String,LinkedHashMap<String,Integer>> entry : users.entrySet()) {
            System.out.printf("%s: \n",entry.getKey());
            String formattedIPs = entry.getValue().entrySet().stream().map(ip->ip.getKey() + " => " + ip.getValue()).reduce((x,y)->x + ", " + y).get();
            System.out.printf("%s.\n",formattedIPs);


        }
    }
}
