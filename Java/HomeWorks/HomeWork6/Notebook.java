import java.lang.management.OperatingSystemMXBean;
import java.lang.reflect.Parameter;
import java.util.ArrayList;
import java.util.Date;
import java.util.Map;
import java.util.Scanner;

/*
Подумать над структурой класса Ноутбук для магазина техники - выделить поля и методы. Реализовать в java.
Создать множество ноутбуков.
Написать метод, который будет запрашивать у пользователя критерий фильтрации и выведет ноутбуки, отвечающие фильтру.
NoteBook notebook1 = new NoteBook
NoteBook notebook2 = new NoteBook
NoteBook notebook3 = new NoteBook
NoteBook notebook4 = new NoteBook
NoteBook notebook5 = new NoteBook

Например: “Введите цифру, соответствующую необходимому критерию:
1 - ОЗУ
2 - Объем ЖД
3 - Операционная система
4 - Цвет

Далее нужно запросить минимальные значения для указанных критериев - сохранить параметры фильтрации можно также в Map.

Отфильтровать ноутбуки их первоначального множества и вывести проходящие по условиям.

Класс сделать в отдельном файле

приветствие
Выбор параметра
выбор конкретнее
вывод подходящих
}
 */

public class Notebook {
    private int id;
    private Company company;
    public int year;
    public int ram;
    public int hardMemory;
    public OperSys operSys;
    public Color color;

    
    public Notebook (int id, int year, Company company, int ram, int hardMemory, OperSys operSys, Color color){
        this.id = id;
        this.year = year;
        this.company = company;
        this.ram = ram;
        this.hardMemory = hardMemory;
        this.operSys = operSys;
        this.color = color;
    } 


    public String toStringNotebook() {
        return String.format("ID:%s, Year:%d, Company:%s, RAM:%d, HardMemory:%d, OperatingSystem:%s, Color:%s",this.id, this.year, this.company, this.ram, this.hardMemory, this.operSys, this.color);
    }

    // public void Filter (String parametr){ 
    //     if (parametr == "1"){
    //         this.parametr = this.ram;
    //     }

    
}

