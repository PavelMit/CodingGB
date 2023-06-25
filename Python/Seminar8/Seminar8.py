import pathlib
# w - перезапись
# r - чтение 
# a - дозапись
# r+ - чтение + запись
# b - открыть в формате байт
# open('путь', 'режим')
# open(r'data\new.txt', 'режим')
# Путь выносят в отдельную переменную&
# FILE_PATH

# Путь бывает полный и отсносительный (откуда открыт терминал)

FILE_PATH = r'new.text'

# Перезапись
# # f = open(FILE_PATH, 'w')
# # f.write('clwe')
# # f.close()

# Перезапись с функцией with
# # with open(FILE_PATH, 'w') as f:
# #     f.write('Hello World')

# Дозапис с функцией with
# with open(FILE_PATH, 'a') as f:
#     f.write('\nHello World')

# Чтение всего файла или кол-ва символов
# with open(FILE_PATH, 'r') as f:
#     print(f.read(кол-во символов))

# Чтение строк за открытую сессию
# with open(FILE_PATH, 'r') as f:
#     print(f.readline())
#     print(f.readline())

# Чтение всех строк сразу без лишних символов
# with open(FILE_PATH, 'r') as f:
#     for line in f:
#         print (line.strip())
