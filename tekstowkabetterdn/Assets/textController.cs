using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class textController : MonoBehaviour
{
    
    public Text text;
    private enum States { cell, door1, cross1, bed, lamp_room, underbed, main_hall, cross2, lab, stairs, understairs, trapdoor, basement, up, room1, room2, }
    int keydiamond = 0;
    int sword = 0;
    int keysilver = 0;
    int lamp = 0;
    // A = opcja jeden , B = opcja dwa , S = powrot//
    States myState;
    void state_cell()
    {
        //States myState = States.cell;

        text.text = "Budzisz się w celi ... Widzisz Drzwi a w oddali pomieszczenie i lozko /A podejdz drzwi /D podejdz dalej";
        if (Input.GetKeyDown(KeyCode.A))
        {
            myState = States.door1;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.cross1;
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        myState = States.cell;
        text.horizontalOverflow = HorizontalWrapMode.Wrap;
        text.fontSize = 24;
        text.fontStyle = FontStyle.Bold;


    }

    // Update is called once per frame
    void Update()
    {
        if (myState == States.cell) { state_cell(); }
        else if (myState == States.door1) { state_door1(); }
        else if (myState == States.cross1) { state_cross1(); }
        else if (myState == States.bed) { state_bed(); }
        else if (myState == States.underbed) { state_underbed(); }
        else if (myState == States.main_hall) { state_mainhall(); }
        else if (myState == States.lamp_room) { state_lamproom(); }








    }

    private void state_lamproom()
    {

    }

    private void state_underbed()
    {

    }

    private void state_bed()
    {

    }

    private void state_cross1()
    {
        text.text = "Jestes na pierwszym skrzyzowaniu /a";
    }
    private void state_door1()
    {
        text.text = "Znajdujesz sie pod drzwiami ..Sa zamkniete /A otworz /S Wroc ";
        if (Input.GetKeyDown(KeyCode.A)) { state_mainhall(); }
        if (Input.GetKeyDown(KeyCode.S)) { state_cell(); }
    }

    private void state_mainhall()
    {
        if (lamp == 0) { text.text = "Jest tu za ciemno potrzebujesz lampy"; }
        if (lamp == 1)
        {
            text.text = "Jestes w hallu /A Podejdz dalej /S powróć";
            if (Input.GetKeyDown(KeyCode.A)) { state_cross2(); }
            if (Input.GetKeyDown(KeyCode.S)) { state_door1(); }
        }

    }

    private void state_cross2()
    {
        
    }
}
