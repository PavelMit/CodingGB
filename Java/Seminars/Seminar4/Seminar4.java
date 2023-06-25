

// import java. util.ArrayList;
// import java.util.LinkedList;
// import java.util.Queue;
// import java.util.Random;
// import java.util.Scanner;
// import java.util.Stack;

// /**
//  * Seminar4
//  */
// public class Seminar4 {

//     // public static void main(String[] args) {
//         // 1) Замерьте время, за которое в ArrayList добавятся 100 000 элементов
//         // 2) Замерьте время, за которое в LinkedList добавятся 100 000 элементов

//         // ArrayList<Integer> al = new ArrayList<>();
//         // long timeStart = System.currentTimeMillis();
//         // for (int i = 0; i < 100000; i++){
//         //     al.add(0, 0);
//         // }
//         // long timeStop = System.currentTimeMillis();
//         // long res = timeStop - timeStart;
//         // System.out.println(res);

//         // LinkedList<Integer> ll = new LinkedList<>();
//         // long timeStart2 = System.currentTimeMillis();
//         // for (int i = 0; i < 100000; i++){
//         //     ll.add(0, 0);
//         // }
//         // long timeStop2 = System.currentTimeMillis();
//         // long res2 = timeStop2 - timeStart2;
//         // System.out.println(res2);


//         //1) Задание. Реализовать консольное приложение, которое принимает от пользователя строчку вида:
//         //1. Нужно сохранить Text в связаный список.
//         //2. Если введено print~num, выводит строку из позиции num в связном списке и удаляет её из списка.

//         // LinkedList<String> list = new LinkedList<>();
//         // Scanner sc = new Scanner(System.in);
//         // System.out.print("Введите строчку и введите строчку \"exit\" чтобы закрыть программу: ");
//         // String line = sc.nextLine();
//         // while (!line.equals("exit")){

//         //     if (line.startsWith("print~", 0)){
                
//         //         System.out.println(list.remove(Integer.parseInt(line.substring(6))));
//         //     }
//         //     else list.add(line);
            
//         //     System.out.println(list);
//         //     System.out.print("Введите строчку и введите строчку \"exit\" чтобы закрыть программу: ");
//         //     line = sc.nextLine();
//         // }
//         // sc.close();
        
//         //2. Задание Реализовать консольное приложение, которое:
        
//         // 1. ПРинимает от пользователя и "запоминает" строки
//         // 2. Если введено print, выводит строки так, чтобы последняя введенная была первой в списке, а первая - последней.
        
//         // Stack<String>  st = new Stack<>();         
//         // Scanner sc = new Scanner(System.in);  
//         // System.out.print("Введите строчку и введите строчку \"exit\" чтобы закрыть программу: ");
//         // String line = sc.nextLine();
//         // while (!line.equals("exit")){
//         //     if (line.equals("print"))
//         //         while (!st.empty())
//         //             System.out.print(st.pop() + " ");
//         //     else st.push(line);
    
//         //     System.out.println(st);
//         //     System.out.print("Введите строчку и введите строчку \"exit\" чтобы закрыть программу: ");
//         //     line = sc.nextLine();
//         // }
//         // sc.close();

//         // Написать метод, который принимает массив элементов, 
//         //помещает их в стэк и выводит на консоль содержимое стека
    
//     public static void main(String[] args) {
//         int[] nums = new int[10];
//         Random rnd = new Random();
        
//         for (int i = 0; i < nums.length; i++){
//             nums[i] = rnd.nextInt(10);
//             System.out.print(nums[i] + " ");
//         }
//         System.out.println();
//         System.out.println(fillStack(nums));
//         System.out.println(fillQueue(nums));
//     }
    
//     public static Stack<Integer> fillStack(int[] i) {
//         Stack<Integer> st = new Stack<>();
//         for (int num : i){
//             st.push(num);
//         }
//         return st;
//     }

//     public static Queue<Integer> fillQueue(int[] i) {
//         Queue<Integer> qu = new LinkedList<>();
//         for (int num : i){
//             qu.add(num);
//         }
//         return qu;
//     }
    
// }