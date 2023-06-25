// Домашнее задание №3.
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;

/**
 * Пусть дан произвольный список целых чисел
 */
public class HomeWork3 {
    public static void main(String[] args) {
// 1) Нужно удалить из него чётные числа
            ArrayList<Integer> myList = new ArrayList<>(Arrays.asList(16, 41, 44, 144, 17, 2, 16));
        // for (int i = 0; i < myList.size(); i++){
        //     if (myList.get(i) % 2 == 0){
        //         myList.remove(i);
        //         i--;
        //     }
        // }
        // System.out.println(myList);   
        
// 2) Найти минимальное значение
    //         Integer i = Collections.min(myList); // 1 вариант со встроенным методом.
    //         System.out.printf("Минимальное значение в списке - %d", i);
    // 

            // Integer min = myList.get(0); // 2 вариант без метода.
            // for (int num : myList){
            //     if (num < min) min = num;
            // }
            // System.out.printf("Минимальное значение в списке - %d", min);

// 3) Найти максимальное значение
            // Integer i = Collections.max(myList);
            // System.out.printf("Максимально значение в списке - %d", i);

            // Integer max = myList.get(0); // 2 вариант без метода.
            // for (int num : myList){
            //     if (num > max) max = num;
            // }
            // System.out.printf("Максимальное значение в списке - %d", max);
// 4) Найти среднее ариф. значение
//             double sum = 0;
//             for (int i = 0; i < myList.size(); i++)
//                 sum += myList.get(i);
//             System.out.printf("Среднее арифметическое списка = %f", sum/myList.size());
    }
}

