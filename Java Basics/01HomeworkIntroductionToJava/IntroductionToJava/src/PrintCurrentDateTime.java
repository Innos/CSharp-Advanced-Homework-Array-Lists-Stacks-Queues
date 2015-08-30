import java.time.LocalDateTime;

public class PrintCurrentDateTime {
    public static void main(String[] args) {
        LocalDateTime time = LocalDateTime.now();
        System.out.println(time);
    }
}
