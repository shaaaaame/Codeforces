n, k = input().split()
n = int(n)
k = int(k)
total = 0
scores = input().split()

scoreK = scores[k - 1]

for score in scores:
    if int(score) >= int(scoreK) and int(score) > 0:
        total += 1

print(total)