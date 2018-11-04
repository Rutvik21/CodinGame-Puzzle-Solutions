lx,ly,tx,ty=[int(i)for i in input().split()]
while True:
 remaining_turns = int(input())
 X=Y=""
 if tx>lx:
  X="W"
  tx-=1
 elif tx<lx:
  X="E"
  tx+=1
 if ty>ly:
  Y="N"
  ty-=1
 elif ty<ly:
  Y="S"
  ty+=1
 print(Y+X)