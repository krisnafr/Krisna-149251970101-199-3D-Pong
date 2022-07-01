using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode keyOne;
    public KeyCode keyTwo;
    public bool isHorizontal;
    private Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePaddle(GetInput());
    }

    private void MovePaddle(Vector3 move)
    {
        rig.velocity = move;
    }
    private Vector3 GetInput()
    {
        if (isHorizontal)
        {
            if (Input.GetKey(keyOne))
            {
                return Vector3.left * speed;
            }
            else if (Input.GetKey(keyTwo))
            {
                return Vector3.left * -speed;
            }
        }
        else
        {
            if (Input.GetKey(keyOne))
            {
                return Vector3.forward * speed;
            }
            else if (Input.GetKey(keyTwo))
            {
                return Vector3.forward * -speed;
            }
        }
        
        return Vector3.zero;
    }
}
