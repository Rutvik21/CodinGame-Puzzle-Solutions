w, h = [int(i) for i in input().split()]
n = int(input())
x,y = [int(i) for i in input().split()]
x1 = y1 = 0
x2 = w-1
y2 = h-1
while True:
    bomb_dir = input()
    if 'U' in bomb_dir:
        y2 = y - 1
    elif 'D' in bomb_dir:
        y1 = y + 1
    if 'L' in bomb_dir:
        x2 = x - 1
    elif 'R' in bomb_dir:
        x1 = x + 1
    x = (x2 + x1)//2
    y = (y2 + y1)//2
    print(str(x)+' '+str(y))