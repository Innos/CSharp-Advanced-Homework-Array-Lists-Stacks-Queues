import Product.Product;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;


// Note Example 1 in word document has an incorrect sum printed, should be 70.6 instead of 70.5 check it with a calculator if you must.
public class OrderOfProducts {
    public static void main(String[] args) {
        final String productsSource = "OrderOfProducts/Products.txt";
        final String orderSource = "OrderOfProducts/Order.txt";
        final String output = "OrderOfProducts/Output.txt";

        ArrayList<Product> products = new ArrayList<Product>();

        try(Scanner scanner = new Scanner(new File(productsSource))) {

            while(scanner.hasNextLine()){
                String line = scanner.nextLine();
                String[] parameters = line.split(" ");
                String name = parameters[0];
                BigDecimal price = new BigDecimal(parameters[1]);

                products.add(new Product(name,price));
            }

            Collections.sort(products);

        }catch (FileNotFoundException ex){
            System.out.println(ex.getMessage());
        }

        BigDecimal sum = BigDecimal.ZERO;
        try(Scanner scanner = new Scanner(new File(orderSource))) {

            while(scanner.hasNextLine()){
                String line = scanner.nextLine();
                String[] parameters = line.split(" ");
                BigDecimal quantity = new BigDecimal(parameters[0]);
                String name = parameters[1];

                Product currentProduct = products.stream()
                        .filter((p) -> p.getName().equals(name))
                        .findFirst()
                        .orElse(null);
                if(currentProduct != null){
                    BigDecimal orderPrice = quantity.multiply(currentProduct.getPrice());
                    sum = sum.add(orderPrice);
                }
            }

        }catch (FileNotFoundException ex){
        }

        try(PrintWriter writer = new PrintWriter(output)){
            String result = String.format("%.2f",sum);
            writer.write(result);

        }catch(FileNotFoundException ex){
        }
    }
}
