

num = int(input("Введите число: "))
max_num = num
while num != 0:
    num = int(input("Введите число: "))
    if num > max_num:
        max_num = num
print (f"Максимальное число в последовательности - {max_num}")