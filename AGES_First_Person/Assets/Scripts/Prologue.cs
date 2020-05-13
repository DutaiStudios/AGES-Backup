using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Prologue : MonoBehaviour
{

    [SerializeField] Text maintext;
    [SerializeField] Text ButtonA;
    [SerializeField] Text ButtonB;
    [SerializeField] Text DayText;

    public int choicepick;
    private bool opset = false;
    public bool ChoiceAPick;
    public bool ChoiceBPick;
    private int Day;

    void Start()
    {
        Day = 0;
    }

    void Update()
    {
        DayText.text = "Day " + Day;
        if (Day == 0)
        {
            PrologueText();
        }
        if (Day == 1)
        {
            Day1();
        }

    }

    void PrologueText()
    {
        if (opset == false)
        {
            maintext.text = "You wake up cold. You were dreaming about something, the memory, flickering like an ember, is quickly snuffed by the chill. What were you dreaming about? Something inside of you thinks fondly towards the fleeted fantasy, but your conscious mind has entirely deserted it.\n\nYou shiver. The blankets above you are thin, but there are many of them. The bed beneath you is rigid, but it’s softer than the floor.";
            ButtonA.text = "Check the time.";
            ButtonB.text = "Fall back asleep.";
        }


        if (ChoiceAPick == true && choicepick == 1)
        {
            maintext.text = "	Your trembling fingers fumble beneath your pillow; blankets shift as your palm brushes against a frigid item. The screen light is blinding, your eyes reflexively squint, an iota of moisture forms behind your lids as they adjust to the illumination. It’s barely 1 AM.";
            ButtonA.text = "Check your messages.";
            ButtonB.text = "Fall back asleep.";
            opset = true;

        }

        else if (ChoiceBPick == true)
        {
            Day1();
        }

        if (opset == true && ChoiceAPick == true && choicepick == 2)
        {

            maintext.text = "There is one unread message. Your heartbeat shudders as fingers run against the cold screen.\n\nCOUPON\nCITY GROCER: BUY ONE GET ONE FREE\nALL MARKED ITEMS\n\nThis aside, you have no messages.";
            ButtonA.text = "Fall back asleep";
            ButtonB.text = "Fall back asleep.";
        }

        if (choicepick == 3)
        {
            Day1();
        }


    }
    public void ChoiceA()
    {
        ChoiceAPick = true;
        choicepick += 1;
    }

    public void ChoiceB()
    {
        ChoiceBPick = true;
        choicepick += 1;
    }

    void ChoiceReset()
    {
        ChoiceBPick = false;
        ChoiceAPick = false;
        choicepick = 0;
    }

    void Day1()
    {
        ChoiceReset();
        Day = 1;
        maintext.text = "There is a siren outside. It waxes and wanes throughout the day; moments of silence are scarce. The daytime sun has done nothing to stave the winter chill, the thermostat, a beige box on an empty wall, hung precariously. You don't dare touch it.";
        ButtonA.text = "Watch the news.";
        ButtonB.text = "Call a friend.";

        
    }


}
