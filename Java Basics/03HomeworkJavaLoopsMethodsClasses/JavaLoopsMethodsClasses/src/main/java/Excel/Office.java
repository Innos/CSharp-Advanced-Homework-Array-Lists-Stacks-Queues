package Excel;

import java.math.BigDecimal;
import java.time.LocalDate;

public class Office implements Comparable<Office> {

    private final BigDecimal vatPercentage = new BigDecimal(0.2);

    private String name;
    private LocalDate date;
    private String description;
    private BigDecimal income;
    private BigDecimal vat;


    public Office(String name, LocalDate date, String description, BigDecimal income) {
        this.setName(name);
        this.setDate(date);
        this.setDescription(description);
        this.setIncome(income);
    }


    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public LocalDate getDate() {
        return date;
    }

    public void setDate(LocalDate date) {
        this.date = date;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public BigDecimal getIncome() {
        return income;
    }

    public void setIncome(BigDecimal income) {
        this.income = income;
    }

    public BigDecimal getVat(){
        return this.income.multiply(this.vatPercentage);
    }

    public BigDecimal getTotalIncome(){
        return this.income.add(this.getVat());
    }

    @Override
    public String toString() {
        return String.format("%s Total -> %.2f",this.getName(),this.getTotalIncome());
    }

    @Override
    public int compareTo(Office o) {
        return this.getName().compareTo(o.getName());
    }
}
