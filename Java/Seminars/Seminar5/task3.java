import java.util.HashMap;
import java.util.Map;
import java.util.Stack;
import java.lang.Iterable;

// Написать программу, определяющую правильность расстановки скобок в выражении.
// Пример 1: a+(d*3) - истина
// Пример 2: [a+(1*3) - ложь
// Пример 3: [6+(3*3)] - истина
// Пример 4: {a}[+]{(d*3)} - истина
// Пример 5: <{a}+{(d*3)}> - истина
// Пример 6: {a+]}{(d*3)} - ложь

// public class task3 {
//     public static void main(String[] args) {
//         String str = "{a+]}{(d*3)}";
//         Map<Character, Character> mp = new HashMap<>();
//         Stack<Character> sk = new Stack<>();
//         mp.put('(', ')'); mp.put('[', ']'); mp.put('{', '}'); mp.put('<', '>');
//         boolean check = true;

//         for (int i = 0; i < str.length(); i++){
//             if (str.charAt(i) == '(' || str.charAt(i) == '{' && str.charAt(i) == '[' && str.charAt(i) == '<'){
//                 sk.add(str.charAt(i), null);
//             }
//             else if (str.charAt(i) == ')' || str.charAt(i) == '}' && str.charAt(i) == ']' && str.charAt(i) == '>'){
//                 if (sk.firstElement() != mp.get(str.charAt(i))) check = false;
//                 else continue;
//             }
//         }
//         System.out.println(check);
//     }
// }
