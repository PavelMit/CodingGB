# Task 2.
# Найдите сумму цифр трехзначного числа.

# num = int(input("Input a 3-digit num: "))
# sum = num%10 + num//10%10 + num//100
# print(f"Sum of the digits is {sum}")

# Task 4.
# Петя, Катя и Сережа делают из бумаги журавликов. Вместе они сделали S журавликов. 
# Сколько журавликов сделал каждый ребенок, если известно, что Петя и Сережа сделали одинаковое количество журавликов, 
# а Катя сделала в два раза больше журавликов, чем Петя и Сережа вместе?

# num = int(input("Input a quantity of paper cranes: "))
# firstAndThird = num // 6
# second = num - firstAndThird*2
# print(f"{firstAndThird} {second} {firstAndThird}")

# Task 6. 
# Вы пользуетесь общественным транспортом? Вероятно, вы
# расплачивались за проезд и получали билет с номером. Счастливым
# билетом называют такой билет с шестизначным номером, где сумма
# первых трех цифр равна сумме последних трех. Т.е. билет с номером
# 385916 – счастливый, т.к. 3+8+5=9+1+6. Вам требуется написать
# программу, которая проверяет счастливость билета.

# ticket = int(input("Input a number of ticket: "))
# if (ticket%10 + ticket%100//10 + ticket%1000//100 == ticket%10000//1000 + ticket%100000//10000 + ticket//100000):
#     print("YES")
# else: 
#     print("NO")

# Task 8.
# Требуется определить, можно ли от шоколадки размером n
# × m долек отломить k долек, если разрешается сделать один разлом по
# прямой между дольками (то есть разломить шоколадку на два
# прямоугольника).

# a = int(input("Input a size of first side: "))
# b = int(input("Input a size of second side: "))
# portion = int(input("Input a size of needed portion: "))

# if (portion%a == 0 or portion%b == 0) and (portion < a*b):
#     print("YES")
# else: 
#     print("NO")