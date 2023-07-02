import java.util.ArrayList;
import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class main {
    public static ArrayList<Notebook> RamFilter (String request, ArrayList<Notebook>listNotes){
        Scanner sc = new Scanner(System.in);
        ArrayList<Notebook> listResult = new ArrayList<Notebook>();
        int value = Integer.parseInt(request.substring(1));
    
        for (Notebook notebook : listNotes){
            if (request.startsWith(">")){
                if (notebook.ram > value){
                    listResult.add(notebook);
                }
            }
            if (request.startsWith("<")){
                if (notebook.ram < value){
                    listResult.add(notebook);
                }
            }
            if (request.startsWith("=")){
                if (notebook.ram == value){
                    listResult.add(notebook);
                }
            }
        }
        return listResult;        
    }

    public static ArrayList<Notebook> HardMemoryFilter (String request, ArrayList<Notebook>listNotes){
        Scanner sc = new Scanner(System.in);
        ArrayList<Notebook> listResult = new ArrayList<Notebook>();
        int value = Integer.parseInt(request.substring(1));
    
        for (Notebook notebook : listNotes){
            if (request.startsWith(">")){
                if (notebook.hardMemory > value){
                    listResult.add(notebook);
                }
            }
            if (request.startsWith("<")){
                if (notebook.hardMemory < value){
                    listResult.add(notebook);
                }
            }
            if (request.startsWith("=")){
                if (notebook.hardMemory == value){
                    listResult.add(notebook);
                }
            }
        }
        return listResult;        
    }

    public static ArrayList<Notebook> SystemFilter (String request, ArrayList<Notebook> listNotes){
        ArrayList<Notebook> listResult = new ArrayList<Notebook>();
        for (Notebook notebook : listNotes){
            if (request.equals("mac")){
                if (notebook.operSys == notebook.operSys.MacOS)
                    listResult.add(notebook);
            }
            else if (request.equals("win")){
                if (notebook.operSys == notebook.operSys.Windows)
                    listResult.add(notebook);
            }
            else if (request.equals("lyn")){
                if (notebook.operSys == notebook.operSys.Lynux)
                    listResult.add(notebook);
            }
        }
        return listResult;        
    }
        
    public static ArrayList<Notebook> ColorFilter (String request, ArrayList<Notebook> listNotes){
        Scanner sc = new Scanner(System.in);
        ArrayList<Notebook> listResult = new ArrayList<Notebook>();

        for (Notebook notebook : listNotes){     
            String color = notebook.color.toString();
            if (color.equals(request)){
                listResult.add(notebook);
            }
        }
        return listResult;        
    }


    public static Map<String, ArrayList<Notebook>> Filter (Integer parametr, ArrayList<Notebook> listNotes){
        Map<String, ArrayList<Notebook>> result = new HashMap<String, ArrayList<Notebook>>();
        ArrayList<Notebook> newNotebooks = new ArrayList<Notebook>();
        String request = new String();
        Scanner sc = new Scanner(System.in);
        int value;
        
        if (parametr == 1){
            System.out.print("\nВведите '= value', если хотите получить конкретную выборку\nВведите '>value' или '<value', если хотите получить варинты больше или меньше соответствующему значению\nВаш запрос:");
            request = sc.nextLine();
            result.put("RAM " + request, RamFilter(request, listNotes));
        }

        else if (parametr == 2){
            System.out.print("\nВведите '= value', если хотите получить конкретную выборку\nВведите '>value' или '<value', если хотите получить варинты больше или меньше соответствующему значению\nВаш запрос:");
            request = sc.nextLine();
            result.put("HardMemory " + request, HardMemoryFilter(request, listNotes));
        }

        else if (parametr == 3){
            System.out.print("\nНоутбуки с какой системой вы бы хотели увидеть?\nВведите 'mac', если хотите увидеть ноутбуки на MacOs\nВведите 'win', если хотите увидеть ноутбуки на 'Windows'\nВведите 'lyn', если хотите увидеть ноутбуки на 'Lynux'\nВвод: ");
            request = sc.nextLine();
            result.put(request, SystemFilter(request, listNotes));
        }

        else if (parametr == 4){
            System.out.print("\nНоутбуки какого цвета вы бы хотели увидеть?\nnВведите 'black' - Черный\nВведите 'white' - Белый\nВведите 'grey' - Серый\nВведите 'blue' - Синий\nВаш выбор: ");
            request = sc.nextLine();
            result.put(request, ColorFilter(request, listNotes));
        }

        return result;
    }


    public static void main(String[] args) {
            
        Notebook notebook1 = new Notebook(1223, 2020, Company.Acer, 4, 512, OperSys.Lynux, Color.black); //Заводим 10 ноутбуков
        Notebook notebook2 = new Notebook(2343, 2019, Company.Apple, 8, 256, OperSys.MacOS, Color.white);
        Notebook notebook3 = new Notebook(2223, 2010, Company.Apple, 4, 256, OperSys.MacOS, Color.grey);
        Notebook notebook4 = new Notebook(8844, 2017, Company.Asus, 16, 512, OperSys.Windows, Color.black);
        Notebook notebook5 = new Notebook(4324, 2020, Company.HP, 8, 512, OperSys.Windows, Color.blue);
        Notebook notebook6 = new Notebook(8453, 2015, Company.Lenovo, 16, 512, OperSys.Lynux, Color.white);
        Notebook notebook7 = new Notebook(1223, 2019, Company.Acer, 8, 1024, OperSys.Windows, Color.grey);
        Notebook notebook8 = new Notebook(6524, 2014, Company.Apple, 4, 256, OperSys.MacOS, Color.grey);
        Notebook notebook9 = new Notebook(4345, 2020, Company.Apple, 16, 512, OperSys.MacOS, Color.grey);
        Notebook notebook10 = new Notebook(8934, 2018, Company.Asus, 8, 256, OperSys.Windows, Color.black);

        ArrayList<Notebook> noteList = new ArrayList<Notebook>(); //инициализация 
        noteList.add(notebook1); noteList.add(notebook2); noteList.add(notebook3); noteList.add(notebook4); noteList.add(notebook5);
        noteList.add(notebook6); noteList.add(notebook7); noteList.add(notebook8); noteList.add(notebook9); noteList.add(notebook10);
        
        Scanner sc = new Scanner(System.in);
        int parametr = 100; // инициализация параметра дл выбора меню
        Map<String, ArrayList<Notebook>> historyMap = new LinkedHashMap<String, ArrayList<Notebook>>();
    
        while (parametr != 0){ //запуск вечного цикла до выхода
            System.out.print("\nДобро пожаловать в основное меню. Выберите подходящий пункт\n1 - Вывести весь каталог ноутбуков\n2 - Отфильтровать ноутбуки по параметру\n3 - Вывести историю поиска\n0 - Выйти\nВвод: ");
            parametr = sc.nextInt();
            if (parametr >= 0 && parametr < 4){
                if (parametr == 1){
                    System.out.println("\nАктуальный каталог ноутбуков:");
                    for (Notebook item : noteList){
                        System.out.println(item.toStringNotebook());
                    }
                }
                else if  (parametr == 2){
                    System.out.print("\nВыберите параметр фильтрации\n1 - Оперативаня память\n2 - Объем жесткого диска\n3 - Операционная система\n4 - Цвет\nВведите номер фильтра:");   
                    parametr = sc.nextInt();
                    for (Map.Entry<String, ArrayList<Notebook>> mapElement : Filter(parametr, noteList).entrySet()){
                        String key = mapElement.getKey();
                        ArrayList<Notebook> value = mapElement.getValue();
                        System.out.println(key + " : ");
                        historyMap.put(key, value);
                        for (Notebook notebook : value){
                            System.out.println(notebook.toStringNotebook());    
                        }
                    }
                }

                else if (parametr == 3){
                    System.out.print("\nИСТОРИЯ ВАШЕГО ПОИСКА: ");
                    for (Map.Entry<String, ArrayList<Notebook>> mapElement : historyMap.entrySet()){
                        String key = mapElement.getKey();
                        ArrayList<Notebook> value = mapElement.getValue();
                        System.out.println("\n"+key + " : ");
                        for (Notebook notebook : value){
                            System.out.println(notebook.toStringNotebook());    
                        }
                    }
                }
            }
            else System.out.println("Вы ввели не корректный символ, попробуйте еще раз");
        }
    }
}

    

