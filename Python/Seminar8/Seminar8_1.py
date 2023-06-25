def menu ():
    print ("\nВведите цифру нужного действия")
    print ("[0] Вывести справочник")
    print ("[1] Найти контакт")
    print ("[2] Добавить справочник")
    print ("[3] Отредактировать контакт")
    print ("[4] Удалить контакт")
    print ("[5] Выйти из программы")

#0
def show_contacts (FILE_PATH):
    with open(FILE_PATH, 'r') as f:
        index_of_contacts = 0
        for line in f:
            print (f"{index_of_contacts+1}. {line.strip()}")
            index_of_contacts += 1

#1
def find_contact (marker, FILE_PATH):
    with open(FILE_PATH, 'r') as f:
        index_of_contacts = 0
        for line in f:
            if marker.lower() in line.lower():
                print (f"{index_of_contacts+1}. {line.strip()}")
                index_of_contacts += 1
        if index_of_contacts == 0:
            print ("Контакт не найден\n")

#2
def add_contact (FILE_PATH):
    surname = input("Введите Фамилию: ")
    name =  input("Введите Имя: ")
    father_name = input("Введите Отчество: ")
    number = input("Введите номер телефона: ")
    with open(FILE_PATH, 'a') as f:
            f.write(f'\n{surname}, {name}, {father_name}, {number}')
    print ("Контакт успешно добавлен\n")

#3
def change_contact (FILE_PATH):
    index_of_contacts = 0
    list_of_contacts = list()
    check_index = 0
    find_a_word = (input("\nВведите имя, фамилию или часть номера телефона контакта: \n"))
    with open(FILE_PATH, 'r') as f:
        for line in f:
            if find_a_word.lower() in line.lower():
                print (f"{index_of_contacts+1}. {line.strip()}")
                check_index += 1
            list_of_contacts.append(line) #создаю массив с контактами
            index_of_contacts += 1 
    
    if check_index == 0: #проверяю, было ли вхождение или контакт не найден
        print ("Контакт не найден, давайте заново")
            
    else:
        index_of_changing_contacts = int(input("Введите номер из найденных контактов, который вы бы хотели изменить: ")) - 1 
        if index_of_changing_contacts in range(len(list_of_contacts)):
            with open(FILE_PATH, 'w') as f:
                for i in range(0, index_of_contacts):
                    if i != index_of_changing_contacts:
                        f.write(f"{list_of_contacts[i]}")
                    else:
                        surname = input("Введите Фамилию: ")
                        name =  input("Введите Имя: ")
                        father_name = input("Введите Отчество: ")
                        number = input("Введите номер телефона: ")
                        f.write(f'{surname}, {name}, {father_name}, {number}\n')
                        print ("Контакт изменен\n")
        else:
            print ("Вы ввели некорректный номер контакта. Давайте заново")

#4
def del_contact (FILE_PATH):
    FILE_PATH = r'Contacts.text'
    index_of_contacts = 0
    list_of_contacts = list()
    check_index = 0

    find_a_word = (input("\nВведите имя, фамилию или часть номера телефона контакта, который вы хотите удалить: \n"))
    with open(FILE_PATH, 'r') as f:
        for line in f:
            if find_a_word.lower() in line.lower():
                print (f"{index_of_contacts+1}. {line.strip()}")
                check_index += 1
            list_of_contacts.append(line)
            index_of_contacts += 1
    if check_index == 0:
        print ("\nКонтакт не найден, введите другой")

    else:
        index_of_changing_contacts = int(input("Введите номер из найденных контактов, который вы бы хотели бы удалить: ")) - 1 
        if index_of_changing_contacts in range(len(list_of_contacts)):
            with open(FILE_PATH, 'w') as f:
                for i in range(0, index_of_contacts):
                    if i != index_of_changing_contacts:
                        f.write(f"{list_of_contacts[i]}")
                    else:
                        continue
        else:
            print ("Вы ввели некорректный номер контакта. Давайте заново")

        print ("Контакт успешно удален")

menu ()
x = int(input("Выберите пункт меню: "))
FILE_PATH = r'Contacts.text' #Задаем путь файла
while (x != 5): 
    # 1
    if x == 0:
        show_contacts (FILE_PATH)
        menu ()
        x = int(input("Выберите пункт меню: "))
    # 1
    elif x == 1:
        find_contact (input("Введите фамилию или имя: "), FILE_PATH)
        menu ()
        x = int(input("Выберите пункт меню: "))

    # 2
    elif x == 2:
        add_contact (FILE_PATH)
        menu ()
        x = int(input("Выберите пункт меню: "))

    # 3
    elif x == 3:
        change_contact(FILE_PATH)
        menu()
        x = int(input("Выберите пункт меню: "))

    elif x == 4:
        del_contact(FILE_PATH)
        menu()
        x = int(input("Выберите пункт меню: "))

    else:
        print("Вы ввели не корректный символ. Попробуйте еще раз")
        menu()
        x = int(input("Выберите пункт меню: "))
        continue
    