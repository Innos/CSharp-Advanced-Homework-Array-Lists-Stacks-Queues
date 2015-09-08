import java.util.Scanner;

public class Durts {
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int centerX = scanner.nextInt();
        int centerY = scanner.nextInt();
        int radius = scanner.nextInt();
        int numberOfDarts = scanner.nextInt();

        for (int i = 0; i < numberOfDarts; i++)
        {
            int x = scanner.nextInt();
            int y = scanner.nextInt();

            int distanceX = Math.abs(x - centerX);
            int distanceY = Math.abs(y - centerY);

            boolean isYIn = distanceX <= radius && distanceY <= radius/2;
            boolean isXIn = distanceX <= radius/2 && distanceY <= radius;

            if(isXIn || isYIn)
            {
                System.out.println("yes");
            }
            else
            {
                System.out.println("no");
            }
        }
    }
}
