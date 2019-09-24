using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem_Test : MonoBehaviour
{
    /*PURPOSE
    This is a test build of our Event system for Capstone project. 
    This is meant to be placed into a larger script and not exist on its own. 
    This small excerpt is meant to exist as testing cage for our event system.
     */

    //Our event system is built on a section of boolean variables

    //IS THERE AN EVENT CURRENTLY. Initially set to false.
    bool isEvent = false;
    //Can the event happen multiple times or just once? Sing - 1. Mult - 2. Initially set to 0;
    int isMultSing = 0;
    //What season is it occurring in? Summmer - 1. Autumn -2. Winter - 3. Fall - 4. Initially set to 0.
    int whichSeason = 0;
    //How severe is the event?. Minor - 1. Major - 2. Initially set to 0;
    int whichSeverity = 0;
    //Is it a good or bad event? Good - 1. Bad - 2. Initially set to 0;
    int isPosNeg = 0;

    /*This is the most important piece of our event system. 
     Each of the booleans will write to the event string and create a basic binary numeric digit.
     We will use this final digit to decide which event is played.
    */
    string EventString = "00000";

    //Writing the Event String

    //Is an event happenning?
    void Start()
    {
        //SET THE VARIABLES TO YOUR DESIRED EVENT OUTCOME
        //1-2
        isMultSing = 1;
        //1-4
        whichSeason = 1;
        //1-2
        whichSeverity = 1;
        //1-2
        isPosNeg = 1;

        ///////////////////////////////////////////////////////////////////////////////////
        isEvent = true;
        //THIS MASSIVE CHUNK IS THE LOGIC FOR SETTING THE EVENT STRING. DON'T TOUCH UNLESS YOU NEED TO
        if (isEvent)
        {
            //Is Multiple or Single?
            switch (isMultSing) {
                //SINGLE
                case 1:
                    print("SINGLE");
                    //What season is it in?
                    switch(whichSeason)
                    {
                        //SUMMER
                    
                        case 1:
                            print("SUMMER");
                            switch (whichSeverity)
                            {
                                //MINOR
                                case 1:
                                    print("MINOR");
                                    switch (isPosNeg)
                                    {
                                        //POS
                                        case 1:
                                            print("POSITIVE");
                                            EventString = "SING-SUM-MIN-POS";
                                            break;
                                        //NEG
                                        case 2:
                                            print("NEGATIVE");
                                            EventString = "SING-SUM-MIN-NEG";
                                            break;
                                    }

                                    break;
                                    //MAJOR
                                case 2:
                                    print("MAJOR");
                                    switch (isPosNeg)
                                    {
                                        //POS
                                        case 1:
                                            print("POSITIVE");
                                            EventString = "SING-SUM-MAJ-POS";
                                            break;
                                        //NEG
                                        case 2:
                                            print("NEGATIVE");
                                            EventString = "SING-SUM-MAJ-NEG";
                                            break;
                                    }
                                    break;
                            }
                            break;
                            //AUTUMN
                        case 2:
                        print("AUTUMN");
                            switch (whichSeverity)
                            {
                                //MINOR
                                case 1:
                                    print("MINOR");
                                    switch (isPosNeg)
                                    {
                                        //POS
                                        case 1:
                                            print("POSITIVE");
                                            EventString = "SING-AUT-MIN-POS";
                                            break;
                                        //NEG
                                        case 2:
                                            print("NEGATIVE");
                                            EventString = "SING-AUT-MIN-NEG";
                                            break;
                                    }

                                    break;
                                //MAJOR
                                case 2:
                                    print("MAJOR");
                                    switch (isPosNeg)
                                    {
                                        //POS
                                        case 1:
                                            print("POSITIVE");
                                            EventString = "SING-AUT-MAJ-POS";
                                            break;
                                        //NEG
                                        case 2:
                                            print("NEGATIVE");
                                            EventString = "SING-AUT-MAJ-NEG";
                                            break;
                                    }
                                    break;
                            }
                            break;
                            break;
                            //WIN
                        case 3:
                            print("WINTER");
                            switch (whichSeverity)
                            {
                                //MINOR
                                case 1:
                                    print("MINOR");
                                    switch (isPosNeg)
                                    {
                                        //POS
                                        case 1:
                                            print("POSITIVE");
                                            EventString = "SING-WIN-MIN-POS";
                                            break;
                                        //NEG
                                        case 2:
                                            print("NEGATIVE");
                                            EventString = "SING-WIN-MIN-NEG";
                                            break;
                                    }

                                    break;
                                //MAJOR
                                case 2:
                                    print("MAJOR");
                                    switch (isPosNeg)
                                    {
                                        //POS
                                        case 1:
                                            print("POSITIVE");
                                            EventString = "SING-WIN-MAJ-POS";
                                            break;
                                        //NEG
                                        case 2:
                                            print("NEGATIVE");
                                            EventString = "SING-WIN-MAJ-NEG";
                                            break;
                                    }
                                    break;
                            }
                            break;
                            break;
                        //SPRING
                        case 4:
                            print("SPRING");
                            switch (whichSeverity)
                            {
                                //MINOR
                                case 1:
                                    print("MINOR");
                                    switch (isPosNeg)
                                    {
                                        //POS
                                        case 1:
                                            print("POSITIVE");
                                            EventString = "SING-SPR-MIN-POS";
                                            break;
                                        //NEG
                                        case 2:
                                            print("NEGATIVE");
                                            EventString = "SING-SPR-MIN-NEG";
                                            break;
                                    }

                                    break;
                                //MAJOR
                                case 2:
                                    print("MAJOR");
                                    switch (isPosNeg)
                                    {
                                        //POS
                                        case 1:
                                            print("POSITIVE");
                                            EventString = "SING-SPR-MAJ-POS";
                                            break;
                                        //NEG
                                        case 2:
                                            print("NEGATIVE");
                                            EventString = "SING-SPR-MAJ-NEG";
                                            break;
                                    }
                                    break;
                            }
                            break;
                            break;
                    }
                    break;
                    //MULTIPLE
                case 2:
                    print("MULTIPLE");
                    //What season is it in?
                    switch (whichSeason)
                    {
                        //SUMMER
                        case 1:
                            switch (whichSeverity)
                            {
                                //MINOR
                                case 1:
                                    print("MINOR");
                                    switch (isPosNeg)
                                    {
                                        //POS
                                        case 1:
                                            print("POSITIVE");
                                            EventString = "SING-SUM-MIN-POS";
                                            break;
                                        //NEG
                                        case 2:
                                            print("NEGATIVE");
                                            EventString = "SING-SUM-MIN-NEG";
                                            break;
                                    }

                                    break;
                                //MAJOR
                                case 2:
                                    print("MAJOR");
                                    switch (isPosNeg)
                                    {
                                        //POS
                                        case 1:
                                            print("POSITIVE");
                                            EventString = "SING-SUM-MAJ-POS";
                                            break;
                                        //NEG
                                        case 2:
                                            print("NEGATIVE");
                                            EventString = "SING-SUM-MAJ-NEG";
                                            break;
                                    }
                                    break;
                            }
                            break;
                        //AUTUMN
                        case 2:
                            switch (whichSeverity)
                            {
                                //MINOR
                                case 1:
                                    print("MINOR");
                                    switch (isPosNeg)
                                    {
                                        //POS
                                        case 1:
                                            print("POSITIVE");
                                            EventString = "SING-AUT-MIN-POS";
                                            break;
                                        //NEG
                                        case 2:
                                            print("NEGATIVE");
                                            EventString = "SING-AUT-MIN-NEG";
                                            break;
                                    }

                                    break;
                                //MAJOR
                                case 2:
                                    print("MAJOR");
                                    switch (isPosNeg)
                                    {
                                        //POS
                                        case 1:
                                            print("POSITIVE");
                                            EventString = "SING-AUT-MAJ-POS";
                                            break;
                                        //NEG
                                        case 2:
                                            print("NEGATIVE");
                                            EventString = "SING-AUT-MAJ-NEG";
                                            break;
                                    }
                                    break;
                            }
                            break;
                            break;
                        //WIN
                        case 3:
                            switch (whichSeverity)
                            {
                                //MINOR
                                case 1:
                                    print("MINOR");
                                    switch (isPosNeg)
                                    {
                                        //POS
                                        case 1:
                                            print("POSITIVE");
                                            EventString = "SING-WIN-MIN-POS";
                                            break;
                                        //NEG
                                        case 2:
                                            print("NEGATIVE");
                                            EventString = "SING-WIN-MIN-NEG";
                                            break;
                                    }

                                    break;
                                //MAJOR
                                case 2:
                                    print("MAJOR");
                                    switch (isPosNeg)
                                    {
                                        //POS
                                        case 1:
                                            print("POSITIVE");
                                            EventString = "SING-WIN-MAJ-POS";
                                            break;
                                        //NEG
                                        case 2:
                                            print("NEGATIVE");
                                            EventString = "SING-WIN-MAJ-NEG";
                                            break;
                                    }
                                    break;
                            }
                            break;
                            break;
                        //SPRING
                        case 4:
                            switch (whichSeverity)
                            {
                                //MINOR
                                case 1:
                                    print("MINOR");
                                    switch (isPosNeg)
                                    {
                                        //POS
                                        case 1:
                                            print("POSITIVE");
                                            EventString = "SING-SPR-MIN-POS";
                                            break;
                                        //NEG
                                        case 2:
                                            print("NEGATIVE");
                                            EventString = "SING-SPR-MIN-NEG";
                                            break;
                                    }

                                    break;
                                //MAJOR
                                case 2:
                                    print("MAJOR");
                                    switch (isPosNeg)
                                    {
                                        //POS
                                        case 1:
                                            print("POSITIVE");
                                            EventString = "SING-SPR-MAJ-POS";
                                            break;
                                        //NEG
                                        case 2:
                                            print("NEGATIVE");
                                            EventString = "SING-SPR-MAJ-NEG";
                                            break;
                                    }
                                    break;
                            }
                            break;
                            break;
                    }
                    break;
                    
            }
        }
        //This just prints the string so you can see
        print(EventString);
    }
}
