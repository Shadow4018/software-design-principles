from array import *

def input_arr(value):
    arr = array('i', [])
    for i in range(value):
        num = int(input(f"Input the element {i+1}: "))
        arr.append(num)
    return arr

def findSum(arr):
    sum = 0;
    for val in arr:
        sum += val
    return sum

def average(arr, sum, value):
    print("Numbers that are higher than average: ")
    for val in arr:
        if sum / value < val:
            print(val)

def main():
    value = int(input("Input the size of the mass: "))
    if value <= 0:
        print("Error: Size can't be 0 or less;")
        return
    
    arr = input_arr(value)
    sum = findSum(arr)
    average(arr, sum, value)

main()

# print(f"value = [value]")