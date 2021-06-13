lines = []
n = int(input())
total = 0
for i in range(n):
    lines.append(input())

def implement(line):
    p = int(line[0])
    v = int(line[2])
    t = int(line[4])

    if p + v + t >= 2:
        return True
    else:
        return False


for line in lines:
    if (implement(line)):
        total += 1

print(total)
