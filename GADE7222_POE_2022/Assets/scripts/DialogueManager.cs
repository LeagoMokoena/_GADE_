using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DialogueManager : MonoBehaviour
{
    public GameObject CanvasBox;
    public TMP_Text TextBox;
    public TMP_Text NameBox;
    public Image SpeakerPic;
    public Sprite RacerPic;
    public Sprite ManagerPic;

    private Queue<string> checkpointConvo = new Queue<string>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartDialogue(Queue<string> dialogue)
    {
        checkpointConvo = dialogue;
        PrintDialogue();
    }

    public void ContinueDialogue()
    {
        PrintDialogue();
    }

    public void PrintDialogue()
    {
        if (checkpointConvo.Peek().Contains("EndQueue"))
        {
            checkpointConvo.Dequeue();
            StopDialogue();
        }
        else if (checkpointConvo.Peek().Contains("[NAME="))
        {
            string speakerName = checkpointConvo.Peek();
            speakerName = checkpointConvo.Dequeue().Substring(speakerName.IndexOf('=') + 1, speakerName.IndexOf(']') - (speakerName.IndexOf('=') + 1));
            NameBox.text = speakerName;
            if (speakerName == "RACER")
            {
                SpeakerPic.sprite = RacerPic;
}
            else if (speakerName == "MANAGER")
            {
                SpeakerPic.sprite = ManagerPic;
            }
            PrintDialogue();
        }
        else
        {
            TextBox.text = checkpointConvo.Dequeue();
        }
    }

    public void StopDialogue()
    {
        NameBox.text = "[NAME]";
        TextBox.text = "[Dialogue Text]";
        checkpointConvo.Clear();
    }
}
