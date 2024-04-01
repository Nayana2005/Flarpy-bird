using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Birdscript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D myRidigbody;
    public float flapStrength;
    public LogicScript Logic;
    public bool birdIsAlive = true;

    void Start()
    {
        myRidigbody = GetComponent<Rigidbody2D>();
        Logic = GameObject.FindGameObjectWithTag("Bidopia").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true){
            myRidigbody.velocity = Vector2.up*flapStrength;

        }
    }
    void OnCllisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collison detected");
        if(Logic != null){
                Logic.GameOver();
                if(birdIsAlive != false){
                    birdIsAlive = false;
                }
        }
    }
}
