from random import randint
from array import*

ROW = 10
COLUMN = 15

def generateArray():
    arr = []
    for i in range(ROW):
        row = []
        for j in range(COLUMN):
            # if i == 5:
            #     row.append(1)
            # else:
                row.append(randint(0, 1))
        arr.append(row)
    return arr

def displayArray(arr):
    for i in range(ROW):
        for j in range(COLUMN):
            print(arr[i][j], end=" ")
        print()

def check(arr, value):
    for i in range(COLUMN):
        if arr[value][i] == 0:
            print("There is.")
            return
    print("No, there not.")
    return


def main():
    arr = generateArray()
    value = int(input("Input the row number: "))
    check(arr, value)
    displayArray(arr)

main()
