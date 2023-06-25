/**
 Дано четное число N (>0) и символы с1 и с2. Написать метод, который вернет строку длины N
 которая состоит из чередующихся символов с1 и с2, начиная с с1.
 */
/*
import java.util.Scanner;
public class Seminar2 {
    public static void main(String[] args) {
        StringBuilder res = new StringBuilder();
        Scanner sc = new Scanner(System.in);
        System.out.println("Введите число: ");
        int N = sc.nextInt();
        if (N % 2 == 0 && N > 1)
        {
            System.out.println("Введите первый символ: ");
            char c1 = sc.next ().charAt (0); 
            System.out.println("Введите второй символ: ");
            char c2 = sc.next ().charAt (0); 
            for (int i = 0; i < N; i=i+2){
                res.append(c1).append(c2);

            }   
            System.out.println(res);
        }
        else System.out.println("Вы ввели не корректное число");
    }
}
*/
/*
 * Написать метод, который сжимает строку
 * Ввод aaaabbbcdd
 * Вывод a4b3cd2
 */
/*
import java.util.Scanner;

public class Seminar2 {

    public static void main(String[] args) {
        StringBuilder sb = new StringBuilder();
        Scanner sc = new Scanner(System.in);
        System.out.println("Введите строку символов: ");
        String newString = sc.nextLine();
        int counter = 1;
        for (int i = 1; i < newString.length(); i++){
            if (newString.charAt(i) == newString.charAt(i-1)) counter++;
            else if (newString.charAt(i) != newString.charAt(i-1) && counter == 1) sb.append(newString.charAt(i-1));
            else {
                sb.append(newString.charAt(i-1)).append(counter);
                counter = 1;
            }
        }
        sb.append(newString.charAt(newString.length()-1));
        if (counter != 1) sb.append(counter);
        System.out.println(sb);
    }
}
*/

// Работа с файлами

/* 
import java.io.FileWriter;
import java.util.Scanner;

public class Seminar2 {

    public static void main(String[] args) {
    // Записать в файл 10 раз слово "TEST"
        int n = 10;
        String text = "TEST";
        try{
            FileWriter file = new FileWriter("test.txt",  true);
            for (int i = 0; i < n; i++){
                file.write(text);
                file.write("\n");
            }
            file.close();
            System.out.println("Получилось");
        }
        catch (Exception e){
            System.out.println("Что-то пошло не так");
        }

    }
}
*/


