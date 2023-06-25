// Заполнить список названиями планет Солнечной системы в произволльном порядке
// с повторениями. Вывести назваие планеты и количество повторений в списке.

// import java.util.ArrayList;
// import java.util.Arrays;

/**
 * Seminar3
 */
// public class Seminar3 {

//     public static void main(String[] args) {
//         ArrayList<String> planets = new ArrayList<String>(Arrays.asList("земля", "марс", "марс", "земля", "марс", "юпитер", "уран", "земля"));
//         ArrayList<String> allPlanets = new ArrayList<String>(Arrays.asList("меркурий", "венера", "земля", "марс", "юпитер", "сатурн", "уран", "нептун"));
//         int counter = 0;
//         for (String str : allPlanets){
//             counter = 0;
//             for (String str2 : planets){
//                 if (str2.equals(str)){
//                     counter++;
//                 }
//             }
//             if (counter > 0) System.out.printf("%s: %d\n", str, counter);
//         }
//     }
// }

//Создать список типа ArrayList . Поместисть в него как строки, так и целые числа.
// Пройти по списку, найти и удалить целые числа

// import java.util.ArrayList;
// import java.util.Arrays;
// import java.util.Iterator;

// /**
//  * Seminar3
//  */
// public class Seminar3 {

//     public static void main(String[] args) {
//         ArrayList newArray = new ArrayList<>(Arrays.asList(1, "Hello", 144, "How are you", 16));
//         // for (int i = 0; i < newArray.size(); i++){
//         //     if (newArray.get(i) instanceof Integer){
//         //         newArray.remove(i);
//         //         i--;
//         //     }
//         // }
       
//         Iterator iter = newArray.iterator();
//         while (iter.hasNext()){
//             if (iter.next() instanceof Integer){
//                 iter.remove();
//             }
//         }
//         System.out.println(newArray);
//     }
// }

//Заполниить список десятью случайными числами

// import java.util.ArrayList;
// import java.util.Comparator;
// import java.util.Random;

// /**
//  * Seminar3
//  */
// public class Seminar3 {

//     public static void main(String[] args) {
//         ArrayList<Integer> ints = new ArrayList<>();
//         Random rnd = new Random();

//         for (int i = 0; i < 10; i++){
//             ints.add(rnd.nextInt(1000));
//         }
//         ints.sort(Comparator.naturalOrder());
//         System.out.println(ints);
//     }
// }