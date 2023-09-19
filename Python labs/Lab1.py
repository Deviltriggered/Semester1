import random


def Intro():
    print("Лабораторная работа №2")
    print("Вариант №14. Выполнил студент группы 6101-090301D Кудряшов А.В.")
    print("Задание:")
    print("1. В списке целочисленных элементов найти минимальный ненулевой элемент")
    print("2. С использованием цикла while найти в списке индекс последнего положительного чётного элемента")
    print("3. Отсортировать список (без использования стандартных функций сортировки)\nпо убыванию старших цифр элементов списка (сортировка выбором)")
    print("Введите способ заполнения списка:")
    print("1 - ввод элементов списка в одну строку через пробел:")
    print("любое число - автоматическое формирование списка из n элементов:")


def ArrayInput():
    choice = int(input())
    x = []
    if choice == 1:
        print("Введите в строку элементы списка:")
        x = list(map(int, input().split()))
    else:
        print("Введите количество элементов списка:")
        length = int(input())
        print("Введите диапазон элементов:")
        width1, width2 = map(int, input().split())
        for i in range(length):
            x.append(random.randint(width1, width2))
    return x


def MinElem(x):
    answer = 99999
    for i in range(len(array)):
        if (array[i] != 0) and (array[i] < answer):
            answer = x[i]
    return print("1. Минимальный ненулевой элемент:", answer)


def LastPositive(x):
    answer = -1
    i = len(array) - 1
    while i > -1 and ((x[i] < 0) or (x[i] % 2 == 1)):
        i -= 1
    answer = i
    return print("2. Положительные чётные элементы отсутствуют.") if (answer == -1) else print(
        "2. Индекс последнего положительного чётного элемента:", answer)


def Sorting(x):
    for i in range(len(x) - 1):
        minIndex = i
        for j in range(i + 1, len(x)):
            if x[j] < x[minIndex]:
                minIndex = j
        x[i], x[minIndex] = x[minIndex], x[i]
    return x


Intro()
array = ArrayInput()
MinElem(array)
LastPositive(array)
print("3. Исходный список:")
print(array)
print("Список после сортировки выбором:")
print(Sorting(array))
