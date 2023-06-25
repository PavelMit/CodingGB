//Получение данных из терминала строка

// import java.util.Scanner;
// public class firstlesson3 {
//     public static void main(String[] args) {
//         Scanner iScanner = new Scanner(System.in);
//         System.out.printf("name: ");
//         String name = iScanner.nextLine();
//         System.out.printf("Привет, %s!\n", name);
//         iScanner.close();
//     }
// }

//Получение данных из терминала инты с проверкой на тип

// import java.util.Scanner;
// public class firstlesson3 {
//     public static void main(String[] args) {
//         Scanner iScanner = new Scanner(System.in);
//         System.out.println("int a: ");
//         boolean flag = iScanner.hasNextInt();
//         System.out.println(flag);
//         int i = iScanner.nextInt();
//         System.out.println(i);
//         iScanner.close();
//     }
// }

//Сложение строк  - беда, так не делать 
// public class firstlesson3 {
//     public static void main(String[] args) {
//         // int a = 1, b = 2;
//         // int c = a + b;
//         // String res = a + " + " + b + " = " + c;
//         // System.out.println(res);
//         String s = "qwe";
//         int a = 123;
//         String q = s+a;
//         System.out.println(q);
//     }
// }

public class firstlesson3 {
    public static void main(String[] args) {
        int a = 1, b = 2;
        int c = a + b;
        String res = String.format("%d + %d = %d \n", a, b, c);
        System.out.printf("%d + %d = %d \n", a, b, c);
        System.out.println(res);
    }
}

// %d: int
// %x: 16теричных чисел
// %f: для вывода чисел с плавающей точкой
// %e: для вывода чисел с экспоненциальной форме (типа e)
// %c: для вывода одиночного символа
// %s: для вывода строковых значений