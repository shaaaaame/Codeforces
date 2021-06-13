words = []
n = int(input())
for i in range(n):
    words.append(input())



def shorten(word):
    betweenLength = len(word) - 2
    newWord = str(word[0] + str(betweenLength) + word[-1])
    return newWord

for i in range(n):
    if len(words[i]) > 10 :
        words[i] = shorten(words[i])
    print(words[i])