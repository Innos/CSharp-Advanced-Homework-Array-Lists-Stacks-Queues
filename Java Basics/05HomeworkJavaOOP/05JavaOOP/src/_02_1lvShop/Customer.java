package _02_1lvShop;

public class Customer {

    private String name;
    private int age;
    private double balance;

    public Customer(String name, int age, double balance){
        this.setName(name);
        this.setAge(age);
        this.setBalance(balance);
    }

    public double getBalance() {
        return balance;
    }

    public void setBalance(double balance) {
        if(balance < 0){
            throw new IllegalArgumentException("Balance cannot be negative.");
        }
        this.balance = balance;
    }

    public String getName() {
        return name;
    }

    private void setName(String name) {
        if(name == null || name.trim().equals("")){
            throw new IllegalArgumentException("Name cannot be empty.");
        }
        this.name = name;
    }

    public int getAge() {
        return age;
    }

    private void setAge(int age) {
        if(age <= 0){
            throw new IllegalArgumentException("Age must be positive.");
        }
        this.age = age;
    }


}
