n=int(input()) 
pos=float('inf')
neg=-1*pos
if n>0:
 for i in input().split():
  t = int(i)
  if t>0 and t<pos:
   pos = t
  elif t<0 and t>neg:
   neg = t
 print(pos)if pos==abs(neg)else print(pos)if pos<abs(neg)else print(neg)
else:
    print(0)