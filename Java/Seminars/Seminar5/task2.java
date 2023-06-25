import java.util.HashMap;
import java.util.Map;

// Даны 2 строки, написать метод, который вернет true, если эти строки являются изоморфными и false, если нет. 
// Строки изоморфны, если одну букву в первом слове можно заменить на некоторую букву во втором слове, при этом
// 1. повторяющиеся буквы одного слова меняются на одну и ту же букву с сохранением порядка следования. 
// (Например, add - egg изоморфны)
// 2. буква может не меняться, а остаться такой же. (Например, note - code)  n:c, o:o, t:d, e:e
// Пример 1:
// Input: s = "foo", t = "bar"   f: b, o:a,  -- false
// Output: false
// Пример 2:
// Input: s = "paper", t = "title"  p:t, a:i, e:l, r:e
// Output: true

public class task2 {
    public static void main(String[] args) {
        String str1 = "paper";
        String str2 = "title";
        Map<Character, Character> hm = new HashMap<>();
        boolean iso = true;

        for (int i = 0; i < str1.length(); i++){
            // for (var item : hm.entrySet()){
                if (!hm.containsKey(str1.charAt(i))){
                    hm.put(str1.charAt(i), str2.charAt(i));
                }
                if ((hm.containsKey(str1.charAt(i)))){
                    if (hm.get(str1.charAt(i)) != (str2.charAt(i))){
                        iso = false;
                        break;
                    }
                    else continue;
                }
            // }
        }
        System.out.println(iso);
    }
}
