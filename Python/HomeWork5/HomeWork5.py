# Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

# *Пример:*

# A = 3; B = 5 -> 243 (3⁵)
#     A = 2; B = 3 -> 8 

# def power(A, B):
#     if B == 1:
#         return A
#     if B == 0:
#         return 1
#     return power(A, B - 1) * A

# A = int(input("Please input a num: "))
# B = int(input("Input a power of num which you whant to get: "))
# print(power(A, B))

# Задача 28: Напишите рекурсивную функцию sum(a, b), возвращающую сумму двух целых неотрицательных чисел. 
# Из всех арифметических операций допускаются только +1 и -1. Также нельзя использовать циклы.

# *Пример:*

# 2 2
#     4 

# def summ(a, b):
#     if ((a == 1) and (b == 0)) or ((b == 1) and (a == 0)):
#         return 1
#     if (a > b) or (a == b):
#         return summ(a - 1, b) + 1 
#     else: 
#         return summ(a, b - 1) + 1
# a = int(input(("Input a first num: ")))
# b = int(input(("Input a second num: ")))
# print(f"Sum of two nums is {summ(a, b)}")