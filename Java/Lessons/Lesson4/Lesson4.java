// LinkedList - двусвязный список
// Список - гибкая структура данных, позволяющая легко менять свой размер. 
// Элементы доступны для вставки или удаления в любой позиции.

// Если часто считываем информацию - массив
// Если часто добавляем и удаляем - список


// LinkedList нужен для небольшого списка, когда операции удаления и добавления встречаются чаще операций чтения
//посмотреть скорость
// var S = System.currentTimeMillis(); // в начале выполнения кода
// System.out.println(System.currentTimeMillis() - S); // в конце выполнения кода


// Queue
//Делает операцию с последним добавленным элемнетом в список.
// Queue<Integer> queue = new LinkedList<Integer>();
// int intem = queue.remove();

// java.util.NoSuchElementException;


//PriorityQueue
//Наивысший приоритет имеет "наименьший" элемент.
import java.util.*;
import java.lang.*;
package Lesson_04;

import java.util.Stack;

/**
 * Lesson4
 */
// public class Lesson4 {
//     public static void main(String[] args) {
//         PriorityQueue<Integer> pq = new PriorityQueue<Integer>();
//         pq. add(123);
//         pq.add(3);
//         pq.add(13);
//         pq.add(1);
//         System.out.println(pq);
//     }
// }

//Deque - double ended queue
//Линейная коллекция, которая поддреживает вставку и удаление элементов в начало и конец коллекции

//Stack
//First in, lasat out
// Представлячет собой обработку данных по принципу FILO.
// Расширяет Vector пятью операциями, которые позволяют рассматривать вектор, как стек. 

// push(E item);
// pop()

// Вычислить значение выражения в постфиксной форме записи
/**
 * Lesson4
 */
public class Lesson4 {
    private static boolean isDigit(String s) throws NumberFormatException {
        try {
            Integer.parseInt(s);
            return true;
        } catch (NumberFormatException e) {
            return false;
        }
    }
    public static void main(String[] args) {
        var exp  = "1 2 3 * +".split(" "); // 1 + 2 * 3
        int res = 0;
        Stack<Integer> st = new Stack<>();
        for (int i = 0; i < exp.length; i++){

            if (isDigit(exp[i])){
                st.push(Integer.parseInt((exp[i])));

            } else {
                switch (exp[i]){
                    case "+":
                        res = st.pop() + st.pop();
                        st.push(res);
                        break;
                    case "-":
                        res = -st.pop() + st.pop();
                        st.push(res);
                        break;
                    case "*":
                        res = st.pop() * st.pop();
                        st.push(res);
                        break;
                    case "/":
                        res = st.pop() / st.pop();
                        st.push(res);
                        break;
                    default:
                        break;
                    
                }
            }

        }
        System.out.printf("%d\n", st.pop());
    }

    private static boolean isDigit(String string) {
        return false;
    }
}

