# Задача 30:  Заполните массив элементами арифметической прогрессии. 
# Её первый элемент, разность и количество элементов нужно ввести с клавиатуры. 
# Формула для получения n-го члена прогрессии: an = a1 + (n-1) * d.
# Каждое число вводится с новой строки.

# Ввод: 7 2 5
# Вывод: 7 9 11 13 15


# def ariph_prog(first_number, diff, size_prog):
#     list_prog = []
#     for i in range (first_number, (first_number + size_prog*diff), diff):
#         list_prog.append(i)
#     return (list_prog)

# print(ariph_prog(int(input("Input first element: ")), int(input("Input a difference between elements: ")), int(input("Input a quantity of elements: "))))
# # Задача 32: Определить индексы элементов массива (списка), значения которых принадлежат заданному диапазону
# # (т.е. не меньше заданного минимума и не больше заданного максимума)

# # Ввод: [-5, 9, 0, 3, -1, -2, 1,
# # 4, -2, 10, 2, 0, -9, 8, 10, -9,
# # 0, -5, -5, 7]
# # Вывод: [1, 9, 13, 14, 19]


#  Задача 32: Определить индексы элементов массива (списка), значения которых принадлежат заданному диапазону
# (т.е. не меньше заданного минимума и не больше заданного максимума)
# Ввод: [-5, 9, 0, 3, -1, -2, 1,
# 4, -2, 10, 2, 0, -9, 8, 10, -9,
# 0, -5, -5, 7]
# Вывод: [1, 9, 13, 14, 19]

# def indexOfnumsInDiapazon(newList, minDiap, maxDiap):
#     listOfIndexes = []
#     for i in range (len(newList)):
#        if minDiap <= newList[i] <= maxDiap:
#           listOfIndexes.append(i)
#     return (listOfIndexes)

# def makeAList (number):
#     newList = []
#     for i in range(number):
#        newList.append(int(input("Input a num: ")))
#     return (newList)

# newList = makeAList(int(input("Input a size of list: ")))
# print(indexOfnumsInDiapazon(newList, int(input("Input a minimum num: ")), int(input("Input a maximum num: "))))
