
for i in range(6):
    if i % 2 == 0:
        continue
    for j in range(i):
        print("*", end=" ")
    print()
