package _02_1lvShop;

public enum AgeRestriction {
    None(0),
    Teenager(13),
    Adult(18);

    private int value;

    AgeRestriction(int value){
        this.value = value;
    }

    public int getValue(){
        return this.value;
    }
}
