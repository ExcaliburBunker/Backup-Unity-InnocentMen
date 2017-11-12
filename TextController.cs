using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;

    private enum States { cell, Screwdriver, Paperclip , Paperclip_1, Walk_Out, Examine_Room };
    private States myState;

	// Use this for initialization
	void Start () {
        myState = States.cell;
	}

    // Update is called once per frame
    void Update()
    {
        print(myState);
        if (myState == States.cell)
        {
            state_cell();
        } else if (myState == States.Screwdriver) {
            state_screwdriver();
        } else if (myState == States.Paperclip)
        {
            state_paperclip();
        } else if (myState == States.Paperclip_1)
        {
            state_paperclip_1();
        } else if (myState == States.Walk_Out)
        {
            state_walk_out();
        } else if (myState == States.Examine_Room)
        {
            state_examine_room();
        }
    }

    void state_cell()
    {
        text.text = "The day begins in a cold closet with a massive headache. " +
            "As I head out the door of the closet. " +
            "An image appears in my head of a woman with tears and blood. " +
            "As I look around an ear-piercing bang the door swung open hitting the wall, as I open my eye I'm in a cold cell with no one around. " +
            "As I look around I see a screwdriver and a paperclip. As I tried to pick them up. " +
            "The cell door open and a cop says “someone here to see you”. " +
            "He gives me the phone with a cold shiver I say ”hello” " +
            "and before I ask who is this he say“ hello young sir my name is Stephen and I know why you're here, but first you must find me” " +
            "and the next thing I know the phone dies and a cold buzzing sound is heard.\n\n" +
            "Press S to view the rusty Screwdriver, P to view the small PaperClip";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.Screwdriver;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.Paperclip;
        }
    }
    void state_screwdriver() {
            text.text = "Well, let's see if I still remember how to pick locks with this thing. " +
                "As I try to pick it up, it slips hitting the floor with a thump." +
                " As the vent begins to blast chilly air into the bare jail cell. " +
                "It starts to roll away under the bars on the empty floor of the prison. " +
                "yay, I think in a quiet voice in my head.\n\n" +
                "Press R to Return to your thinking chamber";
            if (Input.GetKeyDown(KeyCode.R))
            {
                myState = States.cell;
            }
        }
    void state_paperclip() {
        text.text = "As I look around the room I see the paperclip staring at me with a sort of need to be picked up and used. " +
            "As I head over there, the cop walks in the room and hand me a cell phone. " +
            "Before I could ask where am I he walks away, faces the wall like a child in timeout." +
            "As I put the phone up to my ear a voice old and stern speaks well" +
            " Mr. what your name again."+
            " As I look puzzled by his repose I say, Iris Hook. Before I could ask his name he says" +
            " Cyou have an hour left and hang up with a cold sound" + 
            "        tick tock tick tock\n\n" +
            "Press C to Continue my boring story";
            
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.Paperclip_1;
        }
    }
    void state_paperclip_1()
    {
        text.text = " As I hand over the phone to the cop, " +
            "he grabs it with a force of power and walks away leaving me to die alone in this sort of cold darkness. " +
            "He walks into the dark door and slams it behind him. " +
            "As I try to remember what I was doing, I look over and on the floor lay my escape from this hell hole. " +
            "I head over there and grab the paper clip. " +
            "As I look around the room to see the lock warm and still." +
            "I head over to the cell door. " +
            "Putting my hand in the crack of the bar to grab the lock. " +
            "turning to face the lock, I straightened out the paperclip up and rake it toward me. " +
            "I listen for the pin to click, “click” as I grab the lock it slips falling with a sort of powerful freedom. " +
            "I push the old cell jail door it opens.\n\n" +
            "Press W to walk your freedom";

        if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.Walk_Out;
        }
    }
    void state_walk_out()
    {
        text.text = "A loud scream echo through the vents. " +
            "Whats going on here I ask out loud in this lonely dark room as the sound echo of the walls. " +
            "Making my stay even more like home I think in the vast empty thought of my mind. " +
            "As I head out the cell looking around, a single light flicks off and on blinding me, " +
            "as I try to look around, as my eye adjusts to the warm darkness, " +
            "a dark figure appears in the corner of my eye. " +
            "I turn quickly but he vanishes in the mist of darkness that cloaks this world and the next. " +
            "music begins to play a quiet jazz, soothing I guess.\n\n" +
            "Press E to Examine the room ";

        if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.Examine_Room;
        }
    }
    void state_examine_room()
    {
        text.text = "As I look around in the underlit room the light flicks on and off. " +
            "As I examine it more closely it looks like their a key inside the light. " +
            "Looks amusing";

        if (Input.GetKeyDown(KeyCode.E))
        {
            myState = States.Screwdriver;
        }
    }
}