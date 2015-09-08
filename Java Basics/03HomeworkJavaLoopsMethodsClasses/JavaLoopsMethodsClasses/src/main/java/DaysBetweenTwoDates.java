import java.time.LocalDate;
import java.time.Period;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
import java.util.Locale;
import java.util.Scanner;

public class DaysBetweenTwoDates {
    public static void main(String[] args) {

        Locale.setDefault(Locale.ROOT);
        Scanner scanner = new Scanner(System.in);
        DateTimeFormatter dtf = DateTimeFormatter.ofPattern("d-M-yyyy");

        LocalDate date1 = LocalDate.parse(scanner.next(), dtf);
        LocalDate date2 = LocalDate.parse(scanner.next(), dtf);

        System.out.println(date1.until(date2,ChronoUnit.DAYS));


    }
}
