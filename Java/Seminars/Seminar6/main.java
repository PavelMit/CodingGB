import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;

public class main {
    public static void main(String[] args) {
        Cat cat = new Cat();
        cat.name = "Барсик";
        cat.sex = Sex.M;
        Calendar calendar = new GregorianCalendar(2017, 10, 31, 0, 0);
        cat.birthDate = calendar.getTime();
        cat.sterialized = false;
        cat.poroda = Poroda.DIKIY;
        
        cat.setTreatment((new GregorianCalendar(2023, 5 , 23)).getTime(), null, Treatment.CHUMKA);

        System.out.println(cat.toString());
        cat.Meow(5);
    }
}
