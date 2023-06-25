/* ДЗ 2

/**
1. Дана строка sql-запроса "select * from students where ". Сформируйте часть WHERE этого запроса, используя StringBuilder. Данные для фильтрации приведены ниже в виде json-строки.
Если значение null, то параметр не должен попадать в запрос.
Параметры для фильтрации: {"name":"Ivanov", "country":"Russia", "city":"Moscow", "age":"null"}
Пример вывода: "select * from students WHERE name = Ivanov AND country = Russia.....".
 */

/*
public class HomeWork2 {

    public static void main(String[] args) {
        String gotString = "{\"name\":\"Ivanov\", \"country\":\"Russia\", \"city\":\"Moscow\", \"age\":\"null\"}";
        StringBuilder sb = new StringBuilder();
        sb.append("select * from students WHERE ");
        for (int i = 1; i < gotString.length(); i++){
            if (gotString.charAt(i) == '"' || gotString.charAt(i) == '}') continue; 
            else if (gotString.charAt(i) == ':') sb.append(" = ");
            else if (gotString.charAt(i) == ',') sb.append(" AND");
            else sb.append(gotString.charAt(i));
        }
        System.out.println(sb);
    }

}
*/

/**
2. Реализуйте алгоритм сортировки пузырьком числового массива, результат после каждой итерации запишите в лог-файл.
 */

/*
import java.io.FileWriter;
import java.util.Arrays;

public class HomeWork2 {

    public static void main(String[] args) {
        int[] mass = {12, 16, 5, 9, 55, 4, 1};
        int elems = mass.length;
        //Boolean swapped = false;
    
        for(int i = 0; i < elems; i++){
            for(int j = 0; j < elems - 1 - i; j++){
                if(mass[j] > mass[j + 1])
                {
                    //swapped = true;
                    int temp = mass[j];
                    mass[j] = mass[j + 1];
                    mass[j + 1] = temp;
                }
                try{
                    FileWriter file = new FileWriter("itterations.txt",  true);
                    file.write(Arrays.toString(mass));
                    file.write("\n");
                    file.close();
                }
                catch (Exception e){
                    System.out.println("Что-то пошло не так");
                }
            }
        }
    }
}
*/

/* 
3. Дана json-строка (можно сохранить в файл и читать из файла)
[{"фамилия":"Иванов","оценка":"5","предмет":"Математика"},{"фамилия":"Петрова","оценка":"4","предмет":"Информатика"},{"фамилия":"Краснов","оценка":"5","предмет":"Физика"}]
Написать метод(ы), который распарсит json и, используя StringBuilder, создаст строки вида: Студент [фамилия] получил [оценка] по предмету [предмет].
Пример вывода:
Студент Иванов получил 5 по предмету Математика.
Студент Петрова получил 4 по предмету Информатика.
Студент Краснов получил 5 по предмету Физика.
*/

/*
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.util.List;
import java.io.IOException;
import java.nio.file.Paths;

public class HomeWork2 {

    private static StringBuilder append;

    public static void main(String[] args) {
        StringBuilder sb = new StringBuilder(); // задаем итоговую строку
        try {
            List<String> data = Files.readAllLines(Paths.get("students.txt"), StandardCharsets.UTF_8);
            for (String line : data)
            {
                StringBuilder name = new StringBuilder();
                StringBuilder lesson = new StringBuilder();
                StringBuilder temp = new StringBuilder();
                StringBuilder mark = new StringBuilder();
                for (int i = 0; i < line.length(); i++){
                    if (temp.toString().equals("фамилия")){
                        i += 3;
                        while (line.charAt(i) != '"'){
                            name.append(line.charAt(i));
                            i++;
                            temp = new StringBuilder();
                        }
                    }
                    else if (temp.toString().equals("предмет")){
                        i += 3;
                        while (line.charAt(i) != '"'){
                            lesson.append(line.charAt(i));
                            i++;
                            temp = new StringBuilder();
                        }
                    }
                    else if (temp.toString().equals("оценка")){
                        i += 3;
                        mark.append(line.charAt(i));
                        temp = new StringBuilder();
                    }
                    else if (line.charAt(i) == '"' || line.charAt(i) == '{' || line.charAt(i) == ',' || line.charAt(i) == '}') continue;
                    else temp.append(line.charAt(i));
                }
                sb.append("Студент ").append(name).append(" получил ").append(mark).append(" по предмету ").append(lesson).append(".\n");
                //System.out.println("Hi");
            }
        } catch (IOException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
        sb.deleteCharAt(sb.length() - 1);
        System.out.println(sb);
    }
}
*/


// 4) К калькулятору из предыдущего ДЗ добавить логирование
/* 
import java.io.FileWriter;
import java.util.Arrays;
import java.util.Scanner;
public class HomeWork2 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Введите первое число: ");
        int num1 = sc.nextInt();
        System.out.print("Введите операцию:'+'сложение, '-' вычитание, '*' умножение, '/' деление): ");
        char sign = sc.next ().charAt (0); 
        System.out.print("Введите второе число: ");
        int num2 = sc.nextInt();
        double res = 0;
        //Сложение
        if (sign == '+'){
            System.out.printf("%d + %d = %d", num1, num2, (num1+num2)); 
            res = num1 + num2;
        }
        // Вычитание
        else if (sign == '-') {
            System.out.printf("%d - %d = %d", num1, num2, (num1-num2)); 
            res = num1 - num2;
        }
        // Произведение
        else if (sign == '*'){
            System.out.printf("%d * %d = %d", num1, num2, (num1*num2)); 
            res = num1 * num2;
        }
        // Деление
        else if (sign == '/'){ 
            res = (double)num1 / (double)num2;
            System.out.printf("%d / %d = %f", num1, num2, res); 
        }
        else System.out.println("Вы ввели не кооректный символ, запустите программу заново");
        String str = num1 + " " + sign + " " + num2 + " = " + res;
        try{
            FileWriter file = new FileWriter("calculator.txt",  true);
            file.write(str);
            file.write("\n");
            file.close();
        }
        catch (Exception e){
            System.out.println("Что-то пошло не так");
        }
    }
}
*/

