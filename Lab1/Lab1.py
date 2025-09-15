import random

def postr(R, x, y):
    if y >= 0 and (abs(x) + y) <= R:
            return "Shot!"

    elif abs(y) < abs(x) and abs(x) + abs(y) <= R:
            return "Shot!"
    
    else:
        return "Miss!"

def randomShot(R):
    x = random.randint(-R, R)
    y = random.randint(-R, R)
    return x, y, postr(R, x, y)

# Main execution
radius = int(input("Input the size of the radius: "))

print(f"{'№ пострілу':<10} | {'Координати пострілу':<25} | {'Результат'}")
print("-" * 60)

for i in range(1, 11):
    x, y, result = randomShot(radius)
    print(f"{i:<10} | ({x}, {y})".ljust(38), "|", result)