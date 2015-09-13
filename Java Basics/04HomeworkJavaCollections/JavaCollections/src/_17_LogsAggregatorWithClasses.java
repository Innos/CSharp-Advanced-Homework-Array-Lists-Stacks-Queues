import java.util.*;

public class _17_LogsAggregatorWithClasses {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int numberOfLogs = Integer.parseInt(scanner.nextLine());
        ArrayList<User> logs = new ArrayList<>();
        for (int i = 0; i < numberOfLogs; i++) {
            String[] parameters = scanner.nextLine().split(" ");
            String ip = parameters[0];
            String name = parameters[1];
            int duration = Integer.parseInt(parameters[2]);
            if (!logs.stream().anyMatch(u -> u.getName().equals(name))) {
                User newUser = new User(name, duration, ip);
                logs.add(newUser);
            } else {
                User user = logs.stream().filter(u -> u.getName().equals(name)).findFirst().get();
                user.setDuration(user.getDuration()+duration);
                user.getIpAddresses().add(ip);
            }

        }
        logs.sort((u1,u2)->u1.getName().compareTo(u2.getName()));

        for (User user : logs) {
            System.out.printf("%s: %d %s\n",
                    user.getName(),
                    user.getDuration(),
                    user.getIpAddresses());
        }
    }
}

class User {
    private String name;

    private Integer duration;

    private TreeSet<String> ipAddresses;

    public User(String name, Integer duration, String ip) {
        this.name = name;
        this.duration = duration;
        this.ipAddresses = new TreeSet<>();
        this.ipAddresses.add(ip);
    }

    public String getName() {
        return name;
    }

    public Integer getDuration() {
        return duration;
    }

    public void setDuration(Integer duration) {
        this.duration = duration;
    }

    public TreeSet<String> getIpAddresses() {
        return ipAddresses;
    }
}
