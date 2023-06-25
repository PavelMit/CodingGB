/**
 * firstlesson
 */
public class firstlesson {
    public static void main(String[] args) {
        String s = "fre";
        Float e = 2.7f;
        Double f = 123.45;
        char ch = '{';
        Boolean flag1 = 123 <= 234;
        var i = 123;
        var a = 123;
        System.out.println(a);

        var d = 123.456;
        System.out.println(d);

        System.out.println(getType(a));
        System.out.println(getType(d));
        System.out.println(s);
        System.out.println(e);
        System.out.println(f);
        System.out.println(ch);
        System.out.println(flag1);
        System.out.println(i);
        
        boolean j = a != d;
        System.out.println(j);

        a = 5;
        a = 2;
         
    }

        
    static String getType(Object o){
        return o.getClass().getSimpleName();
    }
}   


/**
 * Innerfirstlesson
 */