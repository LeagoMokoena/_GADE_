using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class finish_checkpoint : MonoBehaviour
{
    [SerializeField] Text CHECKcount;
    [SerializeField] Text won;

    public GameObject checkpoint1;
    public GameObject checkpoint2;
    public GameObject checkpoint3;
    public GameObject checkpoint4;
    //public float points = 4f;
    Stack check = new Stack();
    float amount;

    // Start is called before the first frame update
    void Start()
    {
        
        check.Push(checkpoint4);
        check.Push(checkpoint3);
        check.Push(checkpoint2);
        check.Push(checkpoint1);
        CHECKcount.text = "Only " + check.Count.ToString() + " to go";
    }

    // Update is called once per frame
    void Update()
    {
       if(check.Count == 0)
        {
            won.text = "You Won";
        }
    }

    /*void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "checkpoint")
        {
            //Destroy(collision.Gameobject);
            checkP.Pop();
        }
    }*/


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "checkPoint")
        {
            //Destroy(collision.Gameobject);
            check.Pop();
            CHECKcount.text = "Only " + check.Count.ToString() + " to go";
            amount = check.Count;
        }
    }

}
