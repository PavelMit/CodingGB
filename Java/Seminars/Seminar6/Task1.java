/* set
множество с уникальными значениями
правила как у ключей - значения уникальны
Hash - сохраняется по hashu
Linked - с сохранением очереди ввода
Tree - отсортированный вид
*/

/**
1. Напишите метод, который заполнит массив из 100 элементов случайными цифрами от 0 до 50 .
2. Создайте метод, в который передайте заполненный выше массив и с помощью Set вычислите процент уникальных значений в 
данном массиве и верните его в виде числа с плавающей запятой.
Для вычисления процента используйте формулу:
процент уникальных чисел = количество уникальных чисел * 100 / общее количество чисел в массиве.
 */
import java.util.ArrayList;
import java.util.HashSet;
import java.util.Random;
import java.util.Set;
public class Task1 {

    public static int[] FullNums (int quantity, int min, int max) {
        Random random = new Random();
        int[] mass = new int[quantity];
        for (int i = 0; i < quantity; i++)
            mass[i] = random.nextInt(min, max);
        System.out.println(mass.length);
        return mass;
    }

    private static double HowManyUniqueNums(int[] mass) {
        Set<Integer> st = new HashSet<Integer>(); 
        double res;
        for (int i : mass)
            st.add(i);
        System.out.println(st.size());
        res = ((double)st.size() * 100) / (double)mass.length;
        return res;
    }

    public static void main(String[] args) {
        int quantity = 99;
        int min = 0;
        int max = 50;
        int[] newMass = FullNums(quantity, min, max);
        double result = HowManyUniqueNums(newMass);
        System.out.printf("Процент уникальных числе в массиве = %.2f", result, 2);
    }

}
