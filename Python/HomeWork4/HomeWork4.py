# Task 22. Даны два неупорядоченных набора целых чисел (может быть, с повторениями).
# Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.
# Пользователь вводит 2 числа. n — кол-во элементов первого множества. m — кол-во элементов второго множества.
# Затем пользователь вводит сами элементы множеств.

# 11 6
# 2 4 6 8 10 12 10 8 6 4 2
# 3 6 9 12 15 18
# 6 12

# my_set1 = set()
# my_set2 = set()
# common_set = set() 
# size1 = int(input("Input a size of the first list: ")) # Получаем размер первого списка чисел
# size2 = int(input("Input a size of the second list: ")) # Получаем размер второго списка чисел
# for i in range(size1): # ввод чисел из первого списка
#     my_set1.add(int(input("Input a num for first list: ")))
# for i in range(size2): # ввод чисел из второго списка
#     my_set2.add(int(input("Input a num for second list: ")))


# common_set = my_set1.intersection(my_set2) # объединяем 2 множества в одно по принципу пересечения
# final_list = []  # создаем пустой список, куда будем записывать числа из множества по порядку
# for i in common_set:  # запуливаем элементы множества в список
#     final_list.append(i)
# print(f"Prefinal the set of numbers is: {final_list}") # проверяем получившийся список

# temp_num = 0  # временная переменная
# for i in range(len(final_list)):  # сортируем список по возрастанию
#     i2 = i
#     while (i2 != len(final_list) - 1) and (final_list[i2] > final_list[i2+1]):
#         temp_num = final_list[i2]
#         final_list[i2] = final_list[i2 + 1]
#         final_list[i2 + 1] = temp_num
#         i2 += 1

# print(f"Final set of numbers is: {final_list}") # выводим итог

# Task 24: В фермерском хозяйстве в Карелии выращивают чернику. Она растет на
# круглой грядке, причем кусты высажены только по окружности. Таким образом, у
# каждого куста есть ровно два соседних. Всего на грядке растет N кустов.
# Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них
# выросло различное число ягод – на i-ом кусте выросло ai
#  ягод.
# В этом фермерском хозяйстве внедрена система автоматического сбора черники.
# Эта система состоит из управляющего модуля и нескольких собирающих модулей.
# Собирающий модуль за один заход, находясь непосредственно перед некоторым
# кустом, собирает ягоды с этого куста и с двух соседних с ним.
# Напишите программу для нахождения максимального числа ягод, которое может
# собрать за один заход собирающий модуль, находясь перед некоторым кустом
# заданной во входном файле грядки.

# list_of_bushes = []
# for i in range(int(input("Input an amount of bushes (minimum 3): "))): # создаем список с количество ягод на кустах
#     list_of_bushes.append(int(input(f"Input a amount of berries of the {i+1} bush: "))) 

# temp_max = list_of_bushes[-1] + list_of_bushes[0] + list_of_bushes[1] # присваем максимальную сумму ягод, если начать у первого куста
# max_berry_sum = temp_max
# for i in range(len(list_of_bushes)):
#     if i == (len(list_of_bushes) - 1): #задаем действие для последнего куста, чтобы не выйти нза границы нашего списка
#         temp_max = list_of_bushes[-1] + list_of_bushes[-2] + list_of_bushes[0] 
#     else:  #задаем действие для всех остальны кустов
#         temp_max = list_of_bushes[i] + list_of_bushes[i-1] + list_of_bushes[i+1]
#     if temp_max > max_berry_sum: # сравниваем текущий результат с максимальным 
#         max_berry_sum = temp_max
# print(f"Max amount of berries from tree near bushes is {max_berry_sum}") # выводим результат