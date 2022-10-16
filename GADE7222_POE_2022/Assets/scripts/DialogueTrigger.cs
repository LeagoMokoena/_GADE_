using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public TextAsset checkpointText;
    private Queue<string> dialogue = new Queue<string>();


    void TriggerDialogue()
    {
        ReadTextFile();
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    private void ReadTextFile()
    {
        string text = checkpointText.text;
        string[] lines = text.Split(System.Environment.NewLine.ToCharArray());

        foreach (string line in lines)
        {
            if (!string.IsNullOrEmpty(line))
            {
                if (line.StartsWith("["))
                {
                    string rawText = line.Substring(0, line.IndexOf(']') + 1);
                    string current = line.Substring(line.IndexOf(']') + 1);
                    dialogue.Enqueue(rawText);
                    dialogue.Enqueue(current);
                }
            }
        }
        dialogue.Enqueue("EndQueue");
    }

    public void StartDialogue()
    {
        FindObjectOfType<DialogueManager>().ContinueDialogue();
    }

    public void ExitDialogue()
    {
        FindObjectOfType<DialogueManager>().StopDialogue();
    }

    // Start is called before the first frame update
    void Start()
    {
        TriggerDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
