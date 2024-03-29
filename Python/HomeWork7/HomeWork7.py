# Задача 34:  Винни-Пух попросил Вас посмотреть, есть ли в его стихах ритм. 
# Поскольку разобраться в его кричалках не настолько просто, насколько легко он их придумывает, 
# Вам стоит написать программу. Винни-Пух считает, что ритм есть, если число слогов (т.е. число гласных букв) в каждой фразе стихотворения одинаковое. 
# Фраза может состоять из одного слова, если во фразе несколько слов, то они разделяются дефисами. 
# Фразы отделяются друг от друга пробелами. Стихотворение  Винни-Пух вбивает в программу с клавиатуры. 
# В ответе напишите “Парам пам-пам”, если с ритмом все в порядке и “Пам парам”, если с ритмом все не в порядке

# *Пример:*

# **Ввод:** пара-ра-рам рам-пам-папам па-ра-па-да    
#     **Вывод:** Парам пам-пам  

# def isItRhythmOrNot(string_for_check):
#     set_with_numbers_of_vowels_in_string = set()
#     temp_counter = 0
#     for i in range(len(string_for_check)):
#         if string_for_check[i] in "ауеоэёяию":
#            temp_counter += 1  
#         if string_for_check[i] == " ":
#             set_with_numbers_of_vowels_in_string.add(temp_counter)
#             temp_counter = 0
#             i += 1
#     return "Парам пам-пам" if len(set_with_numbers_of_vowels_in_string) == 1 else "Пам парам"

# new_string = "пара-ра-рам рам-пам-папам па-ра-па-да"
# print(isItRhythmOrNot(new_string))

        

# Задача 36: Напишите функцию print_operation_table(operation, num_rows=6, num_columns=6), которая принимает в качестве аргумента функцию, вычисляющую элемент по номеру строки и столбца. 
# Аргументы num_rows и num_columns указывают число строк и столбцов таблицы, которые должны быть распечатаны. 
# Нумерация строк и столбцов идет с единицы (подумайте, почему не с нуля). 
# Примечание: бинарной операцией называется любая операция, у которой ровно два аргумента, как, например, у операции умножения.

# *Пример:*

# **Ввод:** `print_operation_table(lambda x, y: x * y) ` 
# **Вывод:**
# 1 2 3 4 5 6

# 2 4 6 8 10 12
# 3 6 9 12 15 18
# 4 8 12 16 20 24
# 5 10 15 20 25 30
# 6 12 18 24 30 36

# def print_operation_table(operation, num_rows, num_columns):
#     new_list = [[0] * num_columns for i in range(num_rows)]
#     for i in range(1, num_rows + 1):
#         for j in range(1, num_columns + 1):
#             new_list[i-1][j-1] = int(operation(i, j))
#     for i in range(len(new_list)): #Отсюда и ниже пыхтения по поводу красивого вывода массива без запятых и с переносом строки
#         for j in new_list[i]:
#             print(j, end=' ')
#         print('')

# print(print_operation_table(lambda x, y: x * y, 6, 6))
    


        
