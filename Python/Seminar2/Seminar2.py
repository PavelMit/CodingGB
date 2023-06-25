# Task 1.
# n = int(input("Input a number: "))
# counter = 1
# result = 1
# while counter <= n:
#     result *= counter
#     counter += 1

# print(result)

# Task 2.
# n = int(input("Input a number: "))
# counter = 2
# first = 0
# second = 1

# while (second < n):
#     temp = second
#     second = first + second
#     first = temp
#     counter += 1
# if second == n:
#         print(f"Num is {counter} in Fibo")
# else:
#     print(-1)

# days = int(input("Input a quantity of days: "))
# count = 0
# maxDays = 0

# for i in range(days):
#     if int(input("Input a temperature of a day: ")) > 0:
#         count += 1
#         if count > maxDays:
#             maxDays = count
#     else: 
#         count = 0
# print(f"Max quantity warm days without interruption is {maxDays}")

# n = int(input("How many watermelons there are? "))
# min = int(input("Input a weight of 1 watermelon: "))
# max = min

# for i in range(n-1):
#     weight = int(input(f"Input a weight of {i+2} watermelon: "))
#     if weight > max:
#         max = weight
#     if weight < min:
#         min = weight
# print(f"{min} {max}")