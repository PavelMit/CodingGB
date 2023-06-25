# Task 10.
# На столе лежат n монеток. Некоторые из них лежат вверх решкой, а некоторые – гербом. 
# Определите минимальное число монеток, которые нужно перевернуть, чтобы все монетки были повернуты вверх одной и той же стороной. 
# Выведите минимальное количество монет, которые нужно перевернуть

# n = int(input("Input a number of coins: "))
# counter = 0
# for i in range(n):
#     if int(input("Heads is 1, tails is 0: ")) == 1:
#         counter += 1

# if counter > n/2:
#     print(f"Minimal quantity of reverses is {n-counter}")
# else: 
#     print(f"Minimal quantity of reverses is {counter}")



# Task 12: Петя и Катя – брат и сестра. Петя – студент, а Катя – школьница.
# Петя помогает Кате по математике. Он задумывает два натуральных числа X и Y (X,Y≤1000), а Катя должна их отгадать. 
# Для этого Петя делает две подсказки. Он называет сумму этих чисел S и их произведение P. 
# Помогите Кате отгадать задуманные Петей числа.

S = int(input("Input a sum of numbers: "))
P = int(input("Input a multiple of numbers: "))


for i in range(S):
    if S - i == P/i:
        print(f"First num is {i}, second num is {S - i}")
        break
    if i > S/2:
        print("You put wrong sum and multiple")
        break



# Task 14: Требуется вывести все целые степени двойки (т.е. числа вида 2k), не превосходящие числа N.

# N = int(input("Input a number: "))
# counter = 1

# while (counter < N):
#     print(counter)
#     counter *= 2



    