import Product.Product;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.PrintWriter;
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class ListOfProducts {
    public static void main(String[] args) {

        final String source = "ListOfProducts/Input.txt";
        final String output = "ListOfProducts/Output.txt";

        ArrayList<Product> products = new ArrayList<Product>();

        try(Scanner scanner = new Scanner(new File(source))) {

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

        try(PrintWriter writer = new PrintWriter(output)){
            ArrayList<String> result = new ArrayList<>();
            for (Product prod : products) {
                result.add(prod.toString());
            }
            writer.write(String.join(System.getProperty("line.separator"), result));

        }catch(FileNotFoundException ex){
        }
    }
}
