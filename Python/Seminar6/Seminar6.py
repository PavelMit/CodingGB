# # Task 39. 
# # Даны два массива чисел. 
# # Требуется вывести те элементы первого массива (в том порядке, в каком они идут в первом массиве), которых нет во втором массиве. 
# # Пользователь вводит  число N - количество элементов в первом массиве, затем N чисел - элементы массива. 
# # Затем число M - количество элементов во втором массиве. Затем элементы второго массива
# # Ввод: 					Вывод:
# # 7					3 3 2 12
# # 3 1 3 4 2 4 12
# # 6
# # 4 15 43 1 15 1			(каждое число вводится с новой строки)



# def make_a_list(n):
#     new_list = []
#     for i in range (n):
#         new_list.append(int(input("Input a num: ")))
#     return(new_list)

# def two_lists(list_1, list_2):
#     list_3 = []
#     for i in list_1:
#         if i not in list_2:
#             list_3.append(i)
#     return(list_3)

# list_1 = make_a_list(int(input("Input a quantity of elements in first list: ")))
# list_2 =  make_a_list(int(input("Input a quantity of elements in second list: ")))
# print(f"The exit list is: {two_lists(list_1, list_2)}")

# # Task 41. Дан массив, состоящий из целых чисел. Напишитепрограмму, которая в данном массиве определит
# количество элементов, у которых два соседних и, при этом, оба соседних элемента меньше данного. Сначала
# вводится число N — количество элементов в массиве Далее записаны N чисел — элементы массива. Массив
# состоит из целых чисел.

# def make_a_list(n):
#     new_list = []
#     for i in range (n):
#         new_list.append(int(input("Input a num: ")))
#     return(new_list)

# def bigger_between(list):
#     counter = 0
#     for i in range(1, len(list)-1):
#         if list[i] > list[i-1] and list[i]> list[i+1]:
#             counter += 1
#     return (counter)

# new_list = make_a_list(int(input("Input a quantity of elements in list: ")))
# print(f"There are {bigger_between(new_list)} nums which are bigger that neighbors")


# Дан список чисел. Посчитайте, сколько в нем пар элементов, равных друг другу. 
# Считается, что любые два элемента, равные друг другу образуют одну пару, которую необходимо посчитать. 
# Вводится список чисел. Все числа списка находятся на разных строках.
# Ввод:			Вывод:
# 1 2 3 2 3			2

# def how_many_pairs(new_list):
#     counter = 0
#     for i in range(len(new_list) - 1):
#         for j in range(i + 1, len(new_list)):
#             if new_list[i] == new_list[j]:
#                 counter += 1
#     return(counter)

# def make_a_list(n):
#     new_list = []
#     for i in range (n):
#         new_list.append(int(input("Input a num: ")))
#     return(new_list)

# new_list = make_a_list(int(input("Input a quantity of elements in list: ")))
# print(f"There are {how_many_pairs(new_list)} pairs in list")

# Два различных натуральных числа n и m называются
# дружественными, если сумма делителей числа n
# (включая 1, но исключая само n) равна числу m и
# наоборот. Например, 220 и 284 – дружественные числа.
# По данному числу k выведите все пары дружественных
# чисел, каждое из которых не превосходит k. Программа
# получает на вход одно натуральное число k, не
# превосходящее 105
# . Программа должна вывести все
# пары дружественных чисел, каждое из которых не
# превосходит k. Пары необходимо выводить по одной в
# строке, разделяя пробелами. Каждая пара должна быть
# выведена только один раз (перестановка чисел новую
# пару не дает).

# def delit_sum(number):
#     summ = 0
#     for i in range (1, (number//2 + 1)):
#             if number % i == 0:
#                 summ += i
#     return(summ)

# def print_friendly_pair(num_1):
#     for i in range (2, num_1):
#         num_2 = delit_sum(i)
#         if i == delit_sum(num_2) and i < num_2:
#              print(f"{i} {num_2}")

# print_friendly_pair((int(input("Input a num: "))))

