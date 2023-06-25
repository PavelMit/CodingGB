
 /*
Задание №1. Вычислить n-ое треугольного число (сумма чисел от 1 до n), n! (произведение чисел от 1 до n)
1 + 2 + 3 1*2*3
*/
/*
import java.util.Scanner;

public class HomeWork1 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Введите число: ");
        int num = sc.nextInt();
        int sum = 0;
        int mult = 1;
        for (int i = 1; i <= num; i++){
            sum += i;
            mult *= i;
        }
        System.out.printf("Треугольное число = %d\n", sum);
        System.out.printf("Фкториал = %d", mult);
    }
}
 */

 /*
  * Задание №2. Вывести все простые числа от 1 до 1000
  */
/*
  public class HomeWork1 {
    public static void main(String[] args) {
        for (int i = 1; i <= 1000; i++){
            if (((i % 2 != 0) && (i % 3 != 0)) || (i == 2) || (i == 3)){
                System.out.printf("%d ", i);
            }
        }
    }
  }
*/

 /*
  * Задание №3. Реализовать простой калькулятор (+-/*)
sc.next() - считывает 1 элемент
sc.nextInt() - считывает только число
sc.nextLine() - считывает строчку
Введите число: 4 \n
Введите знак:
  */

/*   import java.util.Scanner;
public class HomeWork1 {
  public static void main(String[] args) {
      Scanner sc = new Scanner(System.in);
      System.out.print("Введите первое число: ");
      int num1 = sc.nextInt();
      System.out.print("Введите операцию:'+'сложение, '-' вычитание, '*' умножение, '/' деление): ");
      char sign = sc.next ().charAt (0); 
      System.out.print("Введите второе число: ");
      int num2 = sc.nextInt();
      //Сложение
      if (sign == '+') System.out.printf("%d + %d = %d", num1, num2, (num1+num2)); 
      // Вычитание
      else if (sign == '-') System.out.printf("%d - %d = %d", num1, num2, (num1-num2)); 
      // Произведение
      else if (sign == '*') System.out.printf("%d * %d = %d", num1, num2, (num1*num2)); 
      // Деление
      else if (sign == '/'){ 
        double res = (double)num1 / (double)num2;
        System.out.printf("%d / %d = %f", num1, num2, res); 
      }
      else System.out.println("Вы ввели не кооректный символ, запустите программу заново");
  }
}
*/


/* 
(дополнительное задание) Задано уравнение вида q + w = e, q, w, e >= 0. Некоторые цифры могут быть заменены знаком вопроса, например, 2? + ?5 = 69. Требуется восстановить выражение до верного равенства. Предложить хотя бы одно решение или сообщить, что его нет.
Под знаком вопроса - одинаковые цифры
Введите уравнение: ?? + ?? = 44
Ответ: 22 + 22 = 44
*/

/* 
import java.util.Scanner;
public class HomeWork1 {
  public static void main(String[] args) {
    Scanner sc = new Scanner(System.in); 
    System.out.print("Введите первое число: "); // принимаем первое число
    String q_str = sc.nextLine();
    System.out.print("Введите второе число: "); // принимаем второе число
    String w_str = sc.nextLine();
    System.out.print("Введите предполагаемый результат: "); // принимаем результат
    String e_str = sc.nextLine();
    
    String sum_str = q_str + w_str + e_str; // суммируем все строки в одну
    int[] res =  new int[sum_str.length()]; // инициализируем массив интов той же длины
    int marker = 0;

    for (int counter = 0; counter < 10; counter++) // запускаем общий цикл с проверкой всех возможных чисел от "0" до "9" вместо знака"?"
    {
      for (int i = 0; i < sum_str.length(); i++) // создаем массив интов с заменой всех вопросов на текущее число в главном цикле
      {
        if (sum_str.charAt(i) != '?') res[i] = Character.digit(sum_str.charAt(i), 10);
        else res[i] = counter;
      }

      int q_int = 0; //инициализируем числа, котоыре будут проверяться на соответствие формуле
      int w_int = 0;
      int e_int = 0;
      for (int i = 0; i < res.length; i++) // создаем три числа из массива интов 
      {
        if (i < q_str.length()) q_int = q_int * 10 + res[i];
        else if ((i >= q_str.length()) && (i < q_str.length() + w_str.length())) w_int = w_int * 10 + res[i];
        else e_int = e_int * 10 + res[i];
      }

      if ((q_int + w_int) == e_int)  // проверяем соответствие текущей цифры формуле
      {
        System.out.printf("%d + %d = %d", q_int, w_int, e_int); // выводим результат, если соответствует 
        marker = 1;
      }
    }
    if (marker == 0) System.out.printf("Пример %s + %s = %s не решается", q_str, w_str, e_str); // если ни разу не вывели результат - печатаем, что формула не решается
  }
}
*/