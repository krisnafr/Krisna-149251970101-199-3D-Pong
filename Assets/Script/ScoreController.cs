using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text txtScore1;
    public int score1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txtScore1.text = score1.ToString();
    }
}
