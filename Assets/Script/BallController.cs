using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public int speed;
    private int minSpeed;
    private Vector3 speeds;
    private Rigidbody rig;
    private int angle;
    // Start is called before the first frame update
    void Start()
    {
        minSpeed = speed * 8/10;
        rig = GetComponent<Rigidbody>();
        angle = (int)transform.eulerAngles.y;
        startVelocity(angle);
    }

    // Update is called once per frame
    void Update()
    {
        BallSpeed();
        // Debug.Log(rig.velocity);
    }

    private void BallSpeed()
    {
        if(rig.velocity.x < minSpeed && rig.velocity.x > -minSpeed)
        {
            if(rig.velocity.x >= 0)
            {
                rig.velocity = new Vector3(minSpeed,0, rig.velocity.z);
            }
            else if(rig.velocity.x < 0)
            {
                rig.velocity = new Vector3(-minSpeed,0, rig.velocity.z);
            }
        }

        if(rig.velocity.z < minSpeed && rig.velocity.z > -minSpeed)
        {
            if(rig.velocity.z >= 0)
            {
                rig.velocity = new Vector3(rig.velocity.x,0, minSpeed);
            }
            else if(rig.velocity.z < 0)
            {
                rig.velocity = new Vector3(rig.velocity.x,0, -minSpeed);
            }
        }
    }

    public void startVelocity(int angle)
    {
        // Debug.Log("Angle "+angle);
        switch (angle)
        {
            case 44:
                speeds.Set(speed,0,speed);
                // Debug.Log("Angle "+angle);
                break;
            case 135:
                speeds.Set(speed,0,-speed);
                // Debug.Log("Angle "+angle);
                break;
            case 214:
                speeds.Set(-speed,0,-speed);
                // Debug.Log("Angle "+angle);
                break;
            case 314:
                speeds.Set(-speed,0,speed);
                // Debug.Log("Angle "+angle);
                break;
            default:
                // Debug.Log("Gak masok "+angle);
                break;
        }
        rig.velocity = speeds;
        // Debug.Log("Speeds "+speeds);
    }

}
