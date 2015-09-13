import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class _17_LogsAggregatorWithMaps {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int numberOfLogs = Integer.parseInt(scanner.nextLine());
        TreeMap<String,TreeMap<String,Integer>> logs = new TreeMap<String,TreeMap<String, Integer>>();
        for (int i = 0; i < numberOfLogs; i++) {
            String[] parameters = scanner.nextLine().split(" ");
            String ip = parameters[0];
            String name = parameters[1];
            int duration = Integer.parseInt(parameters[2]);
            if (!logs.containsKey(name)) {
                logs.put(name,new TreeMap<>());
            }
            if(!logs.get(name).containsKey(ip)){
                logs.get(name).put(ip,0);
            }
            Integer prevDuration = logs.get(name).get(ip);
            logs.get(name).put(ip,prevDuration+duration);
        }

        for (Map.Entry<String,TreeMap<String,Integer>> log : logs.entrySet()) {
            System.out.printf("%s: %d %s\n",
                    log.getKey(),
                    log.getValue().values().stream().mapToInt(Integer::intValue).sum(),
                    log.getValue().keySet());
        }
    }
}
