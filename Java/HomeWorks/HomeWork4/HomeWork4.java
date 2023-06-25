// Задание

// Даны два Deque, представляющие два целых числа. Цифры хранятся в обратном порядке и каждый из их узлов содержит одну цифру.
// 1) Умножьте два числа и верните произведение в виде связанного списка.
// 2) Сложите два числа и верните сумму в виде связанного списка. Одно или два числа могут быть отрицательными.

// Даны два Deque, цифры в обратном порядке.
// [3,2,1] - пример Deque
// [5,4,3]- пример второго Deque
// 1) 123 * 345 = 42 435
// Ответ всегда - связный список, в обычном порядке
// [4,2,4,3,5] - пример ответа

import java.util.Collection;
import java.util.Deque;
import java.util.LinkedList;

/**
 * HomeWork5
 */
public class HomeWork5 {

    public static void main(String[] args) {
        Deque<Object> dq = new LinkedList<>();
        Deque<Object> dq2 = new LinkedList<>();
        LinkedList<Object> resSum = new LinkedList<>();
        LinkedList<Object> resPow = new LinkedList<>();
        dq.push("-"); dq.push(1);  dq.push(2); dq.push(3); // Заполняем первй Deque
        dq2.push(3); dq2.push(4); dq2.push(5); // Заполняем второй Deque
    
        System.out.println(dq); // печатаем изначальный Deque список 1
        System.out.println(dq2); // печатаем изначальный Deque список 2

        boolean isNegative = false; //Проверка на отрицательность
        boolean isNegative2 = false;
        if (dq.getLast() == "-"){ 
            isNegative = true;
            dq.removeLast();
        }
        if (dq2.getLast() == "-"){ 
            isNegative2 = true;
            dq2.removeLast();
        }

        int num1 = 0; //Переводим Deque 1 в Integer
        while (dq.size() != 0) // 
        {
            num1 = num1 * 10 + (int)(dq.getLast());
            dq.removeLast();
        }
        if(isNegative) num1 = -num1;
        
        int num2 = 0; //Переводим Deque 2 в Integer
         while (dq2.size() != 0) //
        {
            num2 = num2 * 10 + (int)(dq2.getLast());
            dq2.removeLast();
        }
        if(isNegative2) num2 = -num2;

        System.out.printf("Первое число: %d\n", num1);// Печатаем исходные числа
        System.out.printf("Второе число: %d\n",num2);

        int pow = num1 * num2; // Считаем сумму чисел
        int sum = num1 + num2; // Считаем произведение чисел

        while (sum != 0){ // Добавлем цифры суммы в итоговый список
            resSum.addFirst(Math.abs(sum % 10));
            sum /= 10;
        }

        while (pow != 0){ // Добавлем цифры произведения в итоговый список
            resPow.addFirst(Math.abs(pow % 10));
            pow /= 10;
        }

        if (num1+num2 < 0) resSum.addFirst("-"); // Добавляем знак "-"" в начало списка, если сумму отрицательная
        if (num1*num2 < 0) resPow.addFirst("-"); // Добавляем знак "-"" в начало списка, если произведение отрицательное

        System.out.print("Сумма чисел: "); //Выводим итог
        System.out.println(resSum);
        System.out.print("Произведение чисел: ");
        System.out.println(resPow);
    }
}