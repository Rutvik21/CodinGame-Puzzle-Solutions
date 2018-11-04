import sys
import math
w, h = [int(i) for i in input().split()]
lines = []
for i in range(h):
    lines.append(input())
    print(lines[i],file=sys.stderr)
source = 0
l = len(set(lines[0])) - 1
for i in range(l):
    j = 1
    k = source
    path = []
    while j<h-1:  
        if k>0 and k<w-1:
            if lines[j][k+1]=='-' and j not in path:
                k+=3
                path.append(j)
            elif lines[j][k-1]=='-' and j not in path:
                k-=3
                path.append(j)
            else:
                j+=1
        elif k==0:
            if lines[j][k+1]=='-' and j not in path:
                k+=3
                path.append(j)
            else:
                j+=1
        elif k==w-1:
            if lines[j][k-1]=='-' and j not in path:
                k-=3
                path.append(j)
            else:
                j+=1
    print(lines[0][source]+lines[h-1][k])
    source+=3
    