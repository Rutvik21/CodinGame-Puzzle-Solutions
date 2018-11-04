nb_floors, width, nb_rounds, exit_floor, exit_pos, nb_total_clones, nb_additional_elevators, nb_elevators = [int(i) for i in input().split()]
elevator_details = []
for i in range(nb_elevators):
    elevator_floor, elevator_pos = [int(j) for j in input().split()]
    elevator_details.append([elevator_floor,elevator_pos])    
elevator_details = sorted(elevator_details)
init_pos = 0
while True:
    clone_floor, clone_pos, direction = input().split()
    clone_floor = int(clone_floor)
    clone_pos = int(clone_pos)
    if init_pos == 0:
        init_pos = clone_pos
    if clone_pos in [0,width-1]:
        print("BLOCK")
    elif clone_floor == exit_floor and nb_elevators>0:
        if exit_pos > elevator_details[clone_floor-1][1] and clone_pos < elevator_details[clone_floor-1][1]:
            print("BLOCK")
        elif exit_pos < elevator_details[clone_floor-1][1] and clone_pos > elevator_details[clone_floor-1][1]:
            print("BLOCK")
        else:
            print("WAIT")
    elif clone_floor == 0 and nb_elevators>0:
        if init_pos > elevator_details[clone_floor][1] and clone_pos > init_pos:
            print("BLOCK")
        elif init_pos < elevator_details[clone_floor][1] and clone_pos < init_pos:
            print("BLOCK")
        else:
            print("WAIT")
    elif nb_elevators>0 and 0<clone_floor<=nb_floors-1:
        if elevator_details[clone_floor][1] > elevator_details[clone_floor-1][1] and clone_pos < elevator_details[clone_floor-1][1]:
            print("BLOCK")
        elif elevator_details[clone_floor][1] < elevator_details[clone_floor-1][1] and clone_pos > elevator_details[clone_floor-1][1]:
            print("BLOCK")
            
        else:
            print("WAIT")
    else:
        print("WAIT")