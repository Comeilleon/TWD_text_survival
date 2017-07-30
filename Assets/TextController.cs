using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {
		intro, room_0, dead, cupboard_0, door_0, bed_0, window_0, room_1, cupboard_1, bed_1, door_1, window_1, corridor_0,
		door2_0, barricade_0, window2_0, floor_0, corridor_1, window2_1, door2_1, barricade_1, floor_1, corridor_2,
		barricade_2, floor_2, window2_2, door2_2, ledge, walk, down, pipe, carpark
		};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.intro;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if 		(myState == States.intro) 			{intro ();}
		else if (myState == States.room_0) 			{room_0 ();}
		else if (myState == States.dead) 			{dead ();}
		else if (myState == States.cupboard_0) 		{cupboard_0 ();}
		else if (myState == States.door_0) 			{door_0 ();}
		else if (myState == States.bed_0) 			{bed_0 ();}
		else if (myState == States.window_0)	 	{window_0 ();}
		else if (myState == States.room_1) 			{room_1 ();}
		else if (myState == States.cupboard_1) 		{cupboard_1 ();}
		else if (myState == States.bed_1) 			{bed_1 ();}
		else if (myState == States.door_1) 			{door_1 ();}
		else if (myState == States.window_1) 		{window_1 ();}
		else if (myState == States.corridor_0) 		{corridor_0 ();}
		else if (myState == States.door2_0) 		{door2_0 ();}
		else if (myState == States.barricade_0) 	{barricade_0 ();}
		else if (myState == States.window2_0) 		{window2_0 ();}
		else if (myState == States.floor_0) 		{floor_0 ();}
		else if (myState == States.corridor_1) 		{corridor_1 ();}
		else if (myState == States.window2_1) 		{window2_1 ();}
		else if (myState == States.door2_1) 		{door2_1 ();}
		else if (myState == States.barricade_1) 	{barricade_1 ();}
		else if (myState == States.floor_1) 		{floor_1 ();}
		else if (myState == States.corridor_2) 		{corridor_2 ();}
		else if (myState == States.barricade_2) 	{barricade_2 ();}
		else if (myState == States.floor_2) 		{floor_2 ();}
		else if (myState == States.window2_2) 		{window2_2 ();}
		else if (myState == States.door2_2) 		{door2_2 ();}
		else if (myState == States.ledge) 			{ledge ();}
		else if (myState == States.walk) 			{walk ();}
		else if (myState == States.down) 			{down ();}
		else if (myState == States.pipe) 			{pipe ();}
		else if (myState == States.carpark) 		{carpark ();}
	}
	
	void intro (){
		text.text = "You wake up in a hospital bed attached to a drip. The lights are off and there is an eerie silence surrounding you. " +
				"You slide out of bed and wobble to your feet. How long have you been here for? How did you get here? You can't remember anything leading up to now.\n\n" +
				"Press Space to continue";
		if (Input.GetKeyDown(KeyCode.Space)) 		{myState = States.room_0;}
	}
	
	void room_0 (){
		text.text = "You look around the room, there is the Bed in the middle of the room, a Window on the far side, a Door on the opposite side and a Cupboard beside the Door.\n\n" +
					"Press B to look at the Bed.\n" +
					"Press W to look at the Window.\n" +
					"Press D to look at the Door.\n" +
					"Press C to look at the Cupboard";
		if (Input.GetKeyDown(KeyCode.B)) 			{myState = States.bed_0;} 
		if (Input.GetKeyDown(KeyCode.W)) 			{myState = States.window_0;} 
		if (Input.GetKeyDown(KeyCode.D)) 			{myState = States.door_0;} 
		if (Input.GetKeyDown(KeyCode.C)) 			{myState = States.cupboard_0;} 
	}
	
	void room_1 (){
		text.text = "You look around the room some more, just a Bed, a Window, a Door and a Cupboard.\n\n" +
					"Press B to look at the Bed.\n" +
					"Press W to look at the Window.\n" +
					"Press D to look at the Door.\n" +
					"Press C to look at the Cupboard";
		if (Input.GetKeyDown(KeyCode.B)) 			{myState = States.bed_1;} 
		if (Input.GetKeyDown(KeyCode.W)) 			{myState = States.window_1;} 
		if (Input.GetKeyDown(KeyCode.D)) 			{myState = States.door_1;} 
		if (Input.GetKeyDown(KeyCode.C)) 			{myState = States.cupboard_1;} 
	}
	
	void cupboard_0 (){
		text.text = "You open the cupboard and find a few of your clothes. You take off your hospital gown and get dressed.\n\n" +
					"Press R to Return to roaming the room";
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.room_0;}
	}
	
	void cupboard_1 (){
		text.text = "Nothing left in here except for your old hospital gown.\n\n" +
					"Press R to Return to roaming the room";
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.room_1;}
	}
	
	void bed_0 (){
		text.text = "There is a permanent indentation from where you were laying for...who knows how long. The drip beside the bed is empty and the machine " +
					"controlling it has stopped working. The pole holding the fluid bag looks loose, you wonder if you could pull it out and use it for something?\n\n" +
					"Press T to Take the pole from the drip.\n" +
					"Press R to Return to roaming the room";
		if (Input.GetKeyDown(KeyCode.T)) 			{myState = States.room_1;}
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.room_0;}
	}
	
	void bed_1 (){
		text.text = "Now's not the time to rest, you need to find a way out of here.\n\n" +
					"Press R to Return to roaming the room";
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.room_1;}
	}
	
	void window_0 (){
		text.text = "The window has been left open slightly. You are on the second floor but you could probably force the window open enough to jump down...\n\n" +
					"Press J to Jump from the window.\n" +
					"Press R to Return to roaming the room";
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.room_0;}
		if (Input.GetKeyDown(KeyCode.J)) 			{myState = States.dead;} 
	}
	
	void window_1 (){
		text.text = "This pole will make it easier to open the window enough to climb out and jump down but its a long way down from up here...\n\n" +
					"Press J to Jump from the window.\n" +
					"Press R to Return to roaming the room";
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.room_1;}
		if (Input.GetKeyDown(KeyCode.J)) 			{myState = States.dead;} 
	}
	
	void door_0 (){
		text.text = "The door looks like it leads to a corridor but there is something on the other side jamming it shut. You wonder if there is something in here " +
					"you could use to pry it open.\n\n" +
					"Press R to Return to roaming the room";
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.room_0;}
	}
	
	void door_1 (){
		text.text = "The door is held shut from something on the other side. You could probably use the pole to lever the door open though.\n\n" +
					"Press O to Open the door\n" +
					"Press R to Return to roaming the room";
		if (Input.GetKeyDown(KeyCode.O)) 			{myState = States.corridor_0;}
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.room_1;}
	}
	
	void dead (){
		text.text = "You are dead. \n\n" +
					"Press Space to start again";
		if (Input.GetKeyDown(KeyCode.Space)) 		{myState = States.intro;}
	}
	
	void corridor_0 (){
		text.text = "The corridor is dimly lit and is full of some ungodly smell. It smells like...rotting flesh! There is furniture stacked at one end of the corridor as a barricade, " +
					"a door at the other end, a window to your left and various medical supplies scattered around the floor.\n\n" +
					"Press B to look at the Barricade.\n" +
					"Press W to look at the Window.\n" +
					"Press D to look at the Door.\n" +
					"Press F to look at the Floor";
		if (Input.GetKeyDown(KeyCode.B)) 			{myState = States.barricade_0;} 
		if (Input.GetKeyDown(KeyCode.W)) 			{myState = States.window2_0;} 
		if (Input.GetKeyDown(KeyCode.D)) 			{myState = States.door2_0;} 
		if (Input.GetKeyDown(KeyCode.F)) 			{myState = States.floor_0;} 
	}
	
	void door2_0 (){
		text.text = "The door has the words DO NOT OPEN - DEAD INSIDE spray painted across it. You cant see anything through the small glass panel but its locked. You learned " + 
					" how to pick locks back in the police academy but you dont have any lockpicking tools on you...\n\n" +
					"Press R to Return to roaming the corridor";
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_0;}
	}
	
	void window2_0 (){
		text.text = "The window leads to a ledge outside but its locked. If only you had something to put your lock picking skills to work...\n\n" +
					"Press R to Return to roaming the corridor";
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_0;}
	}
	
	void barricade_0 (){
		text.text = "Someone really didnt want anything getting through this way. The furniture is too heavy to move and there is no way through\n\n" +
					"Press R to Return to roaming the corridor";
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_0;}
	}
	
	void floor_0 (){
		text.text = "You kick around in the debris on the floor and notice a siringe with a needle on it.\n\n" +
					"Press T to Take the siringe and needle\n" +
					"Press R to Return to roaming the corridor";
		if (Input.GetKeyDown(KeyCode.T)) 			{myState = States.corridor_1;}
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_0;}
	}
	
	void corridor_1 (){
		text.text = "The smell is becoming overwhelming in here, you need to find a way out.\n\n" +
				"Press B to look at the Barricade.\n" +
				"Press W to look at the Window.\n" +
				"Press D to look at the Door.\n" +
				"Press F to look at the Floor";
		if (Input.GetKeyDown(KeyCode.B)) 			{myState = States.barricade_1;} 
		if (Input.GetKeyDown(KeyCode.W)) 			{myState = States.window2_1;} 
		if (Input.GetKeyDown(KeyCode.D)) 			{myState = States.door2_1;} 
		if (Input.GetKeyDown(KeyCode.F)) 			{myState = States.floor_1;} 
	}
	
	void door2_1 (){
		text.text = "You slide a broom out of the door and try to force it open but its locked. Why would someone have painted the words DEAD INSIDE on the door? What does that mean? " +
					"The siringe isnt much use to you here but it sort of looks like part of your old lock picking kit.\n\n" +
					"Press R to Return to roaming the corridor";
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_1;}
	}
	
	void window2_1 (){
		text.text = "You wipe away the condensation on the window and can see the carpark below but its locked. You wonder if the siringe could be used to pick the lock somehow.\n\n" +
					"Press R to Return to roaming the corridor";
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_1;}
	}
	
	void barricade_1 (){
		text.text = "Couches, chairs, tables...hey, is that a half full bed pan?! There is no chance you can get through here.\n\n" +
					"Press R to Return to roaming the corridor";
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_1;}
	}
	
	void floor_1 (){
		text.text = "You crouch down and rummage through some draws in an overturned desk. You find a hairclip that looks very similar to another part of your lockpicking kit.\n\n" +
					"Press T to Take the hairclip\n" +
					"Press R to Return to roaming the corridor";
		if (Input.GetKeyDown(KeyCode.T)) 			{myState = States.corridor_2;}
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_1;}
	}
	
	void corridor_2 (){
		text.text = "Surely there is a way out of this corridor. You need to keep searching.\n\n" +
				"Press B to look at the Barricade.\n" +
				"Press W to look at the Window.\n" +
				"Press D to look at the Door.\n" +
				"Press F to look at the Floor";
		if (Input.GetKeyDown(KeyCode.B)) 			{myState = States.barricade_2;} 
		if (Input.GetKeyDown(KeyCode.W)) 			{myState = States.window2_2;} 
		if (Input.GetKeyDown(KeyCode.D)) 			{myState = States.door2_2;} 
		if (Input.GetKeyDown(KeyCode.F)) 			{myState = States.floor_2;} 
	}
	
	void barricade_2 (){
		text.text = "Seriously, give up on the barricade!\n\n" +
					"Press R to Return to roaming the corridor";
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_2;}
	}
	
	void floor_2 (){
		text.text = "Nothing useful left down here\n\n" +
					"Press R to Return to roaming the corridor";
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_2;}
	}
	
	void door2_2 (){
		text.text = "The door is locked but with the siringe, the hairclip and some fond memories from lockpicking 101 at the police academy you could probably pick that lock.\n\n" +
					"Press O to Open the door\n" +
					"Press R to Return to roaming the corridor";
		if (Input.GetKeyDown(KeyCode.O)) 			{myState = States.dead;}
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_2;}
	}
	
	void window2_2 (){
		text.text = "The window leads to a ledge above the carpark but its locked. You could use the hairclip and the siringe to pick the lock though.\n\n" +
					"Press O to Open the window\n" +
					"Press R to Return to roaming the corridor";
		if (Input.GetKeyDown(KeyCode.O)) 			{myState = States.ledge;}
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.corridor_2;}
	}
	
	void ledge (){
		text.text = "Wow this ledge is up high and its pretty narrow. It continues to the right and around the corner, to the left is a drain Pipe and there is something below " +
					"you but you were always told if you are affraid of heights, never look down!\n\n" +
					"Press P to look at the Pipe.\n" +
					"Press W to Walk along the Ledge.\n" +
					"Press D to look Down";
		if (Input.GetKeyDown(KeyCode.P)) 			{myState = States.pipe;} 
		if (Input.GetKeyDown(KeyCode.W)) 			{myState = States.walk;} 
		if (Input.GetKeyDown(KeyCode.D)) 			{myState = States.down;} 
	}
	
	void walk (){
		text.text = "You shimmy along the ledge and around the corner only to find that the ledge stops and there is no way down from here.\n\n" +
					"Press R to Return to the window";
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.ledge;}
	}
	
	void down (){
		text.text = "You reluctantly look down but instead of freaking out you see a huge pile of matresses and garbage below. It looks like a pretty soft landing but its a big drop.\n\n" +
					"Press J to Jump down\n" +
					"Press R to Return to the window";
		if (Input.GetKeyDown(KeyCode.J)) 			{myState = States.dead;}
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.ledge;}
	}
	
	void pipe (){
		text.text = "The drain pipe is old and rusty and has started coming away from the wall. You could try to climb down it but would it support your weight?\n\n" +
					"Press C to Climb onto the pipe\n" +
					"Press R to Return to the window";
		if (Input.GetKeyDown(KeyCode.C)) 			{myState = States.carpark;}
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.ledge;}
	}
	
	void carpark (){
		text.text = "You climb down the pipe carefully but quickly and amazingly it holds up! You make it safely to the carpark below and head off down the deserted road towards home. and " +
					"hopefully some answers\n\n" +
					"Congratulations, you got out alive! Press Space if you would like to play again";
		if (Input.GetKeyDown(KeyCode.Space)) 			{myState = States.intro;}
	}
}















