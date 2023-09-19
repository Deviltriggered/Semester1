import os


def intro():
    print("Лабораторная работа №3")
    print("Вариант №14. Выполнил студент группы 6101-090301D Кудряшов А.В.")
    print("Задание:")
    print("В исходном текстовом файле записаны строки, содержащие произвольные алфавитно-цифровые символы.")
    print(
        "Требуется написать программу, которая для каждой строки исходного файла будет определять и выводить в результирующий файл буквы,")
    print("встречающиеся в этой строке в порядке уменьшения частоты их встречаемости. Строчные и прописные буквы при")
    print(
        "этом считаются не различимыми. Каждая буква, которая встречается в тексте, должна быть выведена ровно один раз.")
    print("Если какие-то буквы встречаются одинаковое количество раз, то они выводятся в алфавитном порядке.")


def letterCheck(name, name1):
    with open(name, 'r') as source, open(name1, 'w') as result:
        lines = source.readlines()
        for line in lines:
            used, counter = [], []
            line = line.strip().lower()
            for letter in line:
                if letter not in used:
                    counter.append(line.count(letter))
                    used.append(letter)
            combo = zip(counter, used)
            sorter = sorted(combo, key=lambda arr: arr[0], reverse=True)
            c = "".join([i[1] for i in sorter])
            result.write(c)
            if line != lines[-1].strip():
                result.write("\n")


def program():
    sourceName = input("Введите название исходного файла: ")
    resultName = input("Введите название результатирующего файла: ")
    if os.path.exists(resultName):
        return print("Результатирующий файл с таким названием уже существует.")
    elif os.path.exists(sourceName):
        letterCheck(sourceName, resultName)
    else:
        return print("Исходный файл не найден.")


intro()
program()
