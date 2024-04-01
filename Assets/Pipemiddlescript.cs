using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pipemiddlescript : MonoBehaviour
{
    // Start is called before the first frame update
    public LogicScript Logic;
    public int Scorenum;
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Bidopia").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.layer == 3){
            Scorenum +=1;
            Destroy(gameObject);
        }
    }
}
