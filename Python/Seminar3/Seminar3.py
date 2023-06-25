
# Дана последовательность из N целых чисел и число K. 
# Необходимо сдвинуть всю последовательность (сдвиг - циклический) на K элементов вправо,  K – положительное число.

# Input:   [1, 2, 3, 4, 5] k = 2

# Output:  [4, 5, 1, 2, 3]


# new_list = [1, 2, 3, 4 , 5, 6, 7]
# k = int(input("Введите сдвиг: "))
# final_list = []

# final_list = new_list[-k:] + new_list[:-k]

# for i in range(-k, len(new_list) - k):
#     final_list.append(new_list[i])

# print(final_list)

# Напишите программу для печати всех уникальных значений в словаре. 

# Input:  [{"V": "S001"}, {"V": "S002"}, {"VI": "S001"}, {"VI": "S005"}, {"VII": " S005 "}, {" V ":" S009 "}, {" VIII ":" S007 "}] 

# Output: {'S005', 'S002', 'S007', 'S001', 'S009'}

list = [{"V": "S001"}, {"V": "S002"}, {"VI": "S001"}, {"VI": "S005"}, {"VII": "S005"}, {"V": "S009"}, {"VIII": "S007"}]
unique = set()
for mini_dict in list:
    unique = unique.union(set(mini_dict.values()))

print(unique)   