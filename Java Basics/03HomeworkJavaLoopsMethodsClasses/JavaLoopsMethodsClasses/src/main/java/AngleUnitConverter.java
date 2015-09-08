import java.util.Scanner;

public class AngleUnitConverter {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int numberOfInputs = scanner.nextInt();
        for (int i = 0; i < numberOfInputs; i++) {

            double number = scanner.nextDouble();
            String measure = scanner.next();

            if(measure.equals("rad")){
                System.out.printf("%.6f deg\n",convertToDegrees(number));
            }
            if(measure.equals("deg")){
                System.out.printf("%.6f rad\n", convertToRadians(number));
            }
        }
    }

    private static double convertToDegrees(double number){
        return (number / (Math.PI / 180));
    }

    private static double convertToRadians(double number){
        return (number * (Math.PI / 180));
    }
}
