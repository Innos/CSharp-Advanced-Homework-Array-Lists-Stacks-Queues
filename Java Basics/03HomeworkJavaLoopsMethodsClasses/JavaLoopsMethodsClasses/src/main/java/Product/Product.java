package Product;

import java.math.BigDecimal;

public class Product implements Comparable<Product> {

    private String name;

    private BigDecimal price;

    public Product(String name, BigDecimal price){
        this.setName(name);
        this.setPrice(price);
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public BigDecimal getPrice() {
        return price;
    }

    public void setPrice(BigDecimal price) {
        this.price = price;
    }



    @Override
    public String toString() {
        return String.format("%.2f %s",this.getPrice(),this.getName());
    }

    @Override
    public int compareTo(Product o) {
        return this.getPrice().compareTo(o.getPrice());
    }
}
