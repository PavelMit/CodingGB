/**
HomeWork5.

Реализуйте структуру телефонной книги с помощью HashMap.
Программа также должна учитывать, что во входной структуре будут повторяющиеся имена с разными телефонами, 
их необходимо считать, как одного человека с разными телефонами. 
Вывод должен быть отсортирован по убыванию числа телефонов.
Пример ввода:
Иванов 234234
Иванов 32523
Иванов 5687
Иванов: 234234, 32523, 5687

Варианты Map:
Map<String, ArrayList>
Map<String, String>

Пример меню:
1. Добавить контакт
2. Вывести всех
3. Выход
*/

import java.util.ArrayList;
import java.util.Comparator;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;


public class HomeWork5 {


    public static Map updateBook(Map<String, ArrayList> map, String key, String value) {
        if (map.containsKey(key)) {
            map.get(key).add(value);
            map.get(key).sort(Comparator.naturalOrder());
            System.out.println(map.get(key));
        } else {
            ArrayList newList = new ArrayList<>();
            newList.add(value);
            map.put(key, newList);
            System.out.println(map.get(key));
        }
        return map;
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.print("1. Добавить контакт\n2. Вывести все контакты\n3. Выход\nВыберите пункт меню: ");
        String line = in.nextLine();
        Map <String, ArrayList> mp = new HashMap<>();

        while (!line.equals("3")){
            if (line.equals("2")){
                if (mp.isEmpty()) System.out.println("Записная книга пуста");
                else {
                    for (var item : mp.entrySet()){
                        System.out.printf("%s: ",item.getKey());

                        for (int i = 0; i < item.getValue().size(); i++){
                            System.out.printf("%s", item.getValue().get(i));
                            if (i != item.getValue().size() - 1) System.out.print(", ");
                            else System.out.print("\n");
                        }
                    }
                }
            }
            else if (line.equals("1")){
                System.out.print("Введите фамилию и номер через пробел: ");
                line = in.nextLine();
                String[] words = line.split(" ");
                updateBook(mp, words[0], words[1]);
            }
            else System.out.println("Вы ввели не корректный символ, попробуйте еще раз: ");
            System.out.print("\n1. Добавить контакт\n2. Вывести все контакты\n3. Выход\nВыберите пункт меню: ");
            line = in.nextLine();
        }
        System.out.println("Работа программы завершена, для продолжения - запустите программу заново");
    }
}


