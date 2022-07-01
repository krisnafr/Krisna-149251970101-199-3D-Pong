using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public ScoreController manager;
    // public Collider ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.name == "Ball(Clone)")
        {
            Debug.Log(collision);
            manager.score1+=1;
        }
    }
}
