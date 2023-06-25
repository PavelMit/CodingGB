# def fib(num):
#     if num == 1 or num == 0:
#         return 1
#     return fib(num-1) + fib(num-2)

# print(fib(7))


# Хакер Василий получил доступ к классному журналу и хочет заменить все свои минимальные оценки на максимальные. 
# Напишите программу, которая заменяет оценки Василия, но наоборот: все максимальные – на минимальные.
# Input: 5 -> 1 3 3 3 4

# Output: 1 3 3 3 1

# def find_max(new_list):
#     max_num = new_list[0]
#     for i in new_list:
#         if i > max_num:
#             max_num = i
#     return max_num

# def find_min(new_list):
#     min_num = new_list[0]
#     for i in new_list:
#         if i < min_num:
#             min_num = i
#     return min_num

# # def worst_list(new_list):
# #     max = find_max(new_list)
# #     min = find_min(new_list)
# #     for i in range(len(new_list)):
# #         if new_list[i] == max:
# #             new_list[i] = min
 
# def worst_list(new_list):
#     final_list = []
#     max = find_max(new_list)
#     min = find_min(new_list)
#     for i in new_list:
#         if i == max:
#             final_list.append(min)
#         else:
#             final_list.append(i)
#     return final_list

# list_1 = [1, 3, 3, 3, 4]
# print(list_1)
# print(worst_list(list_1))

# def is_it_simple_or_not(number):
#     flag = 0
#     for i in range(2, number):
#         if number % i == 0:
#             return "No"
#         return "Yes"

# print(is_it_simple_or_not(4))


# def list_reverse(old_list):
#     if len(old_list) == 1:
#         return old_list[0:1]
#     return list_reverse(old_list[1:]) + old_list[0:1]

# list_old = [4, 5, 6, 1, 9]
# new_list = list_reverse(list_old)
# print(new_list)
