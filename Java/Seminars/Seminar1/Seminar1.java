import java.util.Scanner;

/**
 * Seminar1
 */
public class Seminar1 {

     public static void main(String[] args) {
         Scanner sc = new Scanner(System.in);
         System.out.println("Введите имя: ");
         String name = sc.nextLine();
         System.out.println("Привет, " + name);
        
     }
 }

// //Задание 1. дан массив двоичных чисел [1, 1, 0, 1, 0]

// // public class Seminar1 {

// //     public static void main(String[] args) {
// //         int[] mass = {1, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1};
// //         int maxLength = 0;
// //         int currentLength = 0;
// //         for(int i = 0; i < mass.length; i++){
// //             if (mass[i] == 1) currentLength++;
// //             else {
// //                 if (currentLength > maxLength) maxLength = currentLength;
// //                 currentLength = 0;
// //             }
// //         }
// //         if (currentLength > maxLength) maxLength = currentLength;
// //         System.out.println(maxLength);
// //     }
// // }

// //Задание 2. Дан массив nums = [3, 2, 2, 3, 1, 5, 3, 3, 9] и число val = 3.
// // Если в массиве есть числа, равные заданному, нужно перенести эти элементы в конец массива.
// // Таким образом, первые несколько (или все) элементы массива должны быть отличны от заданного, а остальные - равны ему. 
// //С использованием только одного массива

// import javax.print.attribute.standard.NumberUpSupported;

// /**
//  * Seminar1
//  */
// public class Seminar1 {

//     public static void main(String[] args) {
//         int[] nums = {3, 4, 2, 3, 3,  1, 5, 3, 3, 5, 2, 1, 3, 3, 6};
//         int val = 3;
//         int count = 0;
//         for (int i = 0; i < nums.length-i; i++){
//             if (nums[i] == val){
//                 for (int j = i; j < nums.length- 1 - count; j++){
//                     nums[j] = nums[j+1];
//                     nums[j+1] = val;
//                 }
//                 i--;
//                 count++;
//             }
            
//         }
        
//         for (int index = 0; index < nums.length; index++) {
//             System.out.print(nums[index]);
//             if (index != nums.length - 1) System.out.print(", ");
//         }
//     }
// }