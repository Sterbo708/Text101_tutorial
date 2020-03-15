using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {beginning, cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, corridor_0,
						stairs_0, floor, closet_door, game_over, corridor_1, floor_0, in_closet, stairs_1,
						floor_1, corridor_7, stairs_2, courtyard
	};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.beginning;
	}

	// Update is called once per frame
	void Update () {
		print (myState);

		if 		(myState == States.beginning) 		{beginning();}
		else if (myState == States.cell) 			{cell();}
		else if (myState == States.sheets_0)		{sheets_0();}
		else if (myState == States.mirror)			{mirror();}
		else if (myState == States.cell_mirror)		{cell_mirror();}
		else if (myState == States.lock_0)			{lock_0();}
		else if (myState == States.sheets_1)		{sheets_1();}
		else if (myState == States.lock_1)			{lock_1();}
		else if (myState == States.corridor_0)		{corridor_0();}
		else if (myState == States.corridor_7)		{corridor_7();}

		else if (myState == States.stairs_0)		{stairs_0();}
		else if (myState == States.floor)			{floor();}
		else if (myState == States.closet_door)		{closet_door();}
		else if (myState == States.game_over)		{game_over();}
		else if (myState == States.corridor_1)		{corridor_1();}
		else if (myState == States.corridor_7)		{corridor_7();}
		else if (myState == States.floor_0)			{floor_0();}
		else if (myState == States.in_closet)		{in_closet();}
		else if (myState == States.stairs_1)		{stairs_1();}
		else if (myState == States.floor_1)			{floor_1();}
		else if (myState == States.stairs_2)		{stairs_2();}
		else if (myState == States.courtyard)		{courtyard();}
		}


	void beginning(){
		text.text = "How in the world did you get put into Prison?!?! " +
					"Your friends are gonna be upset. " +
					"Look around for some stuff. " +
					"You gotta get out of here! " +
					"Press Enter to Continue" ;

		if (Input.GetKeyDown(KeyCode.Return))	{myState = States.cell;}
	}

	void cell() {
		text.text = "So you look around, and you see some items. " +
					"A sheet, a mirror, and a lock. " +
					"Press -S- to look at the sheets. " +
					"Press -M- to look at the mirror. " +
					"Press -L- to look at the lock";

						if (Input.GetKeyDown(KeyCode.S))			{myState = States.sheets_0;}
						else if (Input.GetKeyDown(KeyCode.M))		{myState = States.mirror;}
						else if (Input.GetKeyDown(KeyCode.L))		{myState = States.lock_0;}
	}

	void sheets_0() {
		text.text = "Your sheets are a hint of Blue, like a...Sonic Blue. " +
					"However, it means nothing in your path to escape. " +
					"Press -R- to continue roaming around.";
			if (Input.GetKeyDown(KeyCode.R))					{myState = States.cell;}

	}
	void lock_0() {
		text.text = "This lock...this silly lock. " +
					"It won't budge, no matter how hard you try. " +
					"Press -R- to continue roaming around.";
		if (Input.GetKeyDown(KeyCode.R))						{myState = States.cell;}

	}
	void mirror() {
		text.text = "So the mirror looks like a mirror. But it's hung pretty weird. " +
					"Kinda off-center. Wanna peek around it? Be careful, though. " +
					"Press -P- to peek around the mirror, or press -R- to continue roaming around. ";

		if (Input.GetKeyDown(KeyCode.R))						{myState = States.cell;}
		else if (Input.GetKeyDown(KeyCode.P))					{myState = States.cell_mirror;}

	}
	void cell_mirror() {
		text.text = "Look at you taking chances! Behind the mirror was a key! " +
					"I was just playing when I said 'Be Careful.' " +
					"Now if you wanna go ahead and unlock the door, you can! " +
					"Press -S- to look at the sheets, Press -U- to unlock the door, " +
					"Press -M- to look at the mirror";

		if (Input.GetKeyDown(KeyCode.S))						{myState = States.sheets_1;}
		else if (Input.GetKeyDown(KeyCode.U))					{myState = States.corridor_0;}
		else if (Input.GetKeyDown(KeyCode.M))					{myState = States.lock_1;}
	}
	void sheets_1() {
		text.text = "Look...I know the Sonic Blue sheets look nice, but " +
					"you gotta get out of here. Any longer and you're gonna miss dinner. " +
					"I know how much that means to you. " +
					"Press -R- to go to the previous block of text where you probably should've " +
					"chosen another option. ";

		if (Input.GetKeyDown(KeyCode.R))						{myState = States.cell_mirror;}
	}
	void lock_1() {
		text.text = "You already looked behind the mirror silly! " +
					"I know...I know...you can't believe that such beauty exists on " +
					"this planet. But you should probably try to leave. " +
					"Press -R- to go to the previous block of text where you probably should've " +
					"chosen another option. ";

		if (Input.GetKeyDown(KeyCode.R))						{myState = States.cell_mirror;}
	}
	void corridor_0() {
		text.text = "Freedom!!! " +
					"Or not. You didn't think it was gonna be that easy, did you? " +
					"You thought it was freedom, however, it's a corridor. " +
					"Now you have other options. You see some stairs, a floor rug, and a closet door " +
					"Press -S- to look up the stairs, Press -F- to look at the floor rug, or Press" +
					"-C- to look at the closet door";
		if 		(Input.GetKeyDown(KeyCode.S))					{myState = States.stairs_0;}
		else if (Input.GetKeyDown(KeyCode.F))					{myState = States.floor;}
		else if (Input.GetKeyDown(KeyCode.C))					{myState = States.closet_door;}
	}
	void stairs_0(){
		text.text = "You look up stairs and see a guard sleeping, kinda like a Metal Gear Solid game. " +
					"You could take him out...if you dare. Press -T- to attempt to take the guard out, or " +
					"Press -B- to go back to the corridor. ";
		if (Input.GetKeyDown(KeyCode.T))						{myState = States.game_over;}
		else if (Input.GetKeyDown(KeyCode.B))					{myState = States.corridor_0;}
	}
	void game_over(){
		text.text = "Silly, the guard was just playing. He heard you. " +
					"His skills are that of an actual ninja. Sorry... " +
					"Back to the beginning you go. Press -P- to play again. ";

		if (Input.GetKeyDown(KeyCode.P))						{myState = States.beginning;}
	}
	void floor(){
		text.text = "You see the floor rug, and it has a weird hump. Small, but weird. " +
					"You can look under it (although it might be a beetle or something), or examine it. " +
					"Press -E- to Examine, or Press -B- to go back to exploring. ";
		if 		(Input.GetKeyDown(KeyCode.E))					{myState = States.corridor_7;}
		else if (Input.GetKeyDown(KeyCode.B))					{myState = States.corridor_0;}
	}
	void corridor_7(){
		text.text = "You conquered your fear of beedles, spiders, and other critters you thought were under the rug! " +
					"Your reward is finding keys with a keycard attached! Press -G- to go forth. ";
		if (Input.GetKeyDown(KeyCode.G))						{myState = States.corridor_1;}
	}
	void closet_door(){
		text.text = "Well look at what hwe have here. It's a door! there's a black sensor with a red dot. " +
					"Like you need a keycard or something. Maybe you have to get it from a guard, or look " +
					"around for it. Press -B- to go back to exploring. ";
		if (Input.GetKeyDown(KeyCode.B))						{myState = States.corridor_0;}
	}
	void corridor_1(){
		text.text = "So you've got the keycard. Now what do you do? Press -S- to go up the stairs, " +
					"Press -C- to look at the closet door, or press -F- to look at the floor rug...again. ";
		if (Input.GetKeyDown(KeyCode.S))						{myState = States.stairs_1;}
		else if (Input.GetKeyDown(KeyCode.C))					{myState = States.in_closet;}
		else if (Input.GetKeyDown(KeyCode.F))					{myState = States.floor_0;}
	}
	void stairs_1(){
		text.text = "You look up the stairs and see a guard. But he has his back turned. " +
					"Maybe take him out with some sweet karate skills?. Or leave him be and go back downstairs. "  +
					"Your choice. Press -T- to attempt to take the guard out, or " +
					"Press -B- to go back to the corridor. ";
		if (Input.GetKeyDown(KeyCode.T))						{myState = States.game_over;}
		else if (Input.GetKeyDown(KeyCode.B))					{myState = States.corridor_1;}
	}
	void floor_0(){
		text.text = "The rug looks really nice. But it's not really doing anything for you. " +
					"Maybe just leave it be since you can't take it out. Press -B- to go back and "+
					"choose another option that you should've chosen the first time";
		if (Input.GetKeyDown(KeyCode.B))						{myState = States.corridor_1;}
	}
	void in_closet(){
		text.text = "So the key card opens the door, and you see some clothes. they look kinda big, though. " +
					"You put them on, and they make you look like a professor of sorts. Like... " +
					"a professor who works on super fighting robots or something. Wanna keep them on or take them off? " +
					"Press -D- to contniue to don the costume, or -U- to undress and go back to your normal outfit. ";
		if (Input.GetKeyDown(KeyCode.D))						{myState = States.floor_1;}
		else if (Input.GetKeyDown(KeyCode.U))					{myState = States.corridor_1;}
	}
	void floor_1(){
		text.text = "Now that you look like someone of note, You can walk a little further down the corridor. " +
					"You can go down the hallway some more, or you can look up the stairs........again. " +
					"Press -G- to go further, or press -S- for...you guessed it...the stairs";
	if (Input.GetKeyDown(KeyCode.G))							{myState = States.courtyard;}
	else if (Input.GetKeyDown(KeyCode.S))						{myState = States.stairs_2;}
	}
	void stairs_2(){
		text.text = "Ok...this fascination with stairs is insane. You can't do anything, so just go back. " +
					"Plus if you move any closer the guard is gonna see you, so just make the right choice and " +
					"Press -B- to go back. ";
	if (Input.GetKeyDown(KeyCode.B))							{myState = States.floor_1;}
	}
	void courtyard(){
		text.text = "You see the light! You make your way down the hallway [Looking like a boss I might add], and " +
					"everything works out. People ask questions, but you don't answer any. You just leave. "+
					"Great job! You've finished the game! Press -P- to play again!";
	if (Input.GetKeyDown(KeyCode.P))							{myState = States.beginning;}
	}
}
