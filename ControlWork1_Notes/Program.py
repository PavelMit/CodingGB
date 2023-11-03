import datetime  
from datetime import datetime

def menu ():
    print ("\nВведите команду для нужного действия")
    print ("[show] Вывести все заметки на экран")
    print ("[sort] Отсортировать заметки по дате редактирования от самой новой к самой старой")
    print ("[add] Добавить заметку")
    print ("[find] Найти заметку по id")
    print ("[edit] Редактировать заметку")
    print ("[del] Удалить заметку по указанному id")
    print ("[end] Закрыть программу\n")

# показыает все заметки
def show_notes (FILE_PATH):
    with open(FILE_PATH, 'r') as f:
        for line in f:
            print (line.strip()) # построчно выводим все заметки 


# возращает ключ для сортировки по последнему параметру в строке - дате
def key_sort (line): 
    return line[-1]
# вывод отсортированного списка по дате от самой новой заметке к самой старой
def sort_notes (FILE_PATH):
    with open(FILE_PATH, 'r') as f:
        content = f.readlines() # записываем все данные в список строк для удобства
        for i in range (0, len(content)):
            content[i] = content[i].split(";") # приобразовываем список строк в список списков строк
        content = sorted(content, key=key_sort, reverse=True) # сортируем по ключ = время/дата
        for line in content:
            print (f"{line[0].strip()}; {line[1].strip()}; {line[3].strip()}") # выводим заметки в привычном, но уже отсортированном вмде


# узнаем последний id заметки для будущей записи
def get_actual_id (FILE_PATH): 
    with open(FILE_PATH, 'r') as f: 
        lines = f.readlines()
        if (len(lines) == 0):
            return 1
        else:
            id = int (lines[-1].strip().split(';')[0]) # берем последнюю строку, сплитуем по ';' и берем первый элемент
            return id + 1
# добавление заметки
def add_note (FILE_PATH):
    title = input("Введите заголовок заметки: ")
    msg = input("Введите тело заметки: ")
    
    id = get_actual_id(FILE_PATH)
    date = datetime.now()

    with open(FILE_PATH, 'a') as f:
        f.write(f"{id}; {title}; {msg}; {str(date)}.\n")     


# ищет индекс строки по введенному id-маркеру. Нужна для следующих функций find, edit и del
def find_index_of_note (content, marker):
    index = None
    for i in range (0, len(content)):
        if marker in content[i]:
            index = i
            return index # возращает indx строки, в которой был замечен нужный id
        
# ищем заметку по id
def find_note (FILE_PATH):
    with open(FILE_PATH, 'r') as f:
        marker = input("Введите 'id' искомой заметки: " ) + ";"
        with open(FILE_PATH, 'r') as f:
            content = f.readlines() # записываем всю информацию из файла в список строк для удобства
            try:
                print (content[find_index_of_note(content, marker)]) # печатаем заметку по искомому индексу
            except:
                print("Искомый индекс не найден") #обрабьатываем исключение, если индекс не найден


# редактируем заметку
def edit_note (FILE_PATH):
    show_notes(FILE_PATH)

    with open(FILE_PATH, 'r') as f:
        marker = input("Введите 'id' заметки, которую вы хотите отредактировать: " ) + ";"
        content = f.readlines() # записываем всю информацию из файла в список строк
        index_str = find_index_of_note(content, marker) # находим искомый индекс строки для редактирования

        id = content[index_str].split(";")[0] # находим текущее id для перезаписи
        title = input("Введите новый заголовок заметки: ") # новый заголовок
        msg = input("Введите тело заметки: ") # новое тело заметки
        date = datetime.now() # фиксируем дату 

        content[index_str] = f"{id}; {title}; {msg}; {str(date)}.\n" # меняем получившуюся строку в итоговом контенте файла
                     
        with open (FILE_PATH, 'w') as f:
            for line in content:
                f.write(line) # записываем получившийся контент построчно в файл

# удаление заметки
def del_note (FILE_PATH):
    show_notes(FILE_PATH)
    with open(FILE_PATH, 'r') as f:
        marker = input("Введите 'id' заметки, которую вы хотите отредактировать: " ) + ";"
        content = f.readlines() # записываем всю информацию из файла в список строк
        index_str = find_index_of_note(content, marker) # находим индекс строки для удаления
        content.pop(index_str)

        with open (FILE_PATH, 'w') as f:
            for line in content:
                f.write(line) # записываем получившийся контент построчно в файл


# основной блок
command = ""
FILE_PATH = 'Notes.json' # название будущего файла
menu()
with open(FILE_PATH, 'r') as f: #создаем файл, если его нет
    f.read

while (command != "end"):
    
    command = input("Введите команду или end, что закрыть программу: ")
    if (command == "add"):
        add_note(FILE_PATH)
    elif (command== "edit"):
        edit_note(FILE_PATH)
    elif (command == "find"):
        find_note(FILE_PATH)
    elif (command == "del"):
        del_note(FILE_PATH)
    elif (command == "show"):
        show_notes(FILE_PATH)
    elif (command == "sort"):
        sort_notes(FILE_PATH)