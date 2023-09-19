def intro():
    print("Лабораторная работа №4")
    print("Вариант №14. Выполнил студент группы 6101-090301D Кудряшов А.В.")
    print("Задание:")
    print("Алгоритм вычисления функции F(n), где n – целое неотрицательное число, задан следующими")
    print("соотношениями:")
    print("     F(n) = 0 при n = 0")
    print("     F(n) = F(n // 2) – 1 при n > 0 для чётных n")
    print("     F(n) = 2 + F(n–1) при n > 0 для нечётных n")
    print("Напишите программу, которая вычисляет: ")
    print("1. Количество чисел n, меньших 1000, для которых значение F(n) будет равно 3. ")
    print("2. Количество значащих нулей результата вычисления F(x), где x – число, заданное ")
    print("пользователем")
    print("\n")


def F(n):
    if n % 2 == 0 and n > 0:
        return F(n // 2) - 1
    if n % 2 != 0 and n > 0:
        return 2 + F(n - 1)
    else:
        return 0


def task1():
   counter = 0
   for n in range(0, 1000):
       if F(n) == 3:
           counter += 1
   return print("Количество чисел n, меньших 1000, для которых значение F(n) будет равно 3:", counter)


def zeroes(x, c):
    if x == 0:
        return c + 1
    elif x < 10:
        return c
    else:
        return zeroes(x // 10, c + 1) if x % 10 == 0 else zeroes(x // 10, c)


def task2():
    x = int(input("Введите число: "))
    c = 0
    f = zeroes(F(x), c)
    return print("Количество значащих нулей результата вычисления F(x) (",F(x),"), где x – число, заданное пользователем:", f)


intro()
task1()
task2()
