using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public int maxBallAmount;
    public List<GameObject> ballTemplateList;
    public List<GameObject> spawnerList;
    private List<GameObject> ballList;
    private float spacing;
    public int spawnInterval;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        ballList = new List<GameObject>();
        spacing = 5f;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; 

        if (timer > spawnInterval) 
        { 
            GenerateBall(); 
            timer -= spawnInterval; 
        }
    }

    private void GenerateBall()
    {
        if (ballList.Count >= maxBallAmount)
        {
            return;
        }
        int randomSpawner = Random.Range(0, spawnerList.Count);
        // float spawnerRotation = spawnerList[randomSpawner].gameObject.transform.eulerAngles.y;
        // float spawnerRotation = spawnerList[randomSpawner].gameObject.transform.rotation.y;
        // Debug.Log("Spawner "+randomSpawner+" rotation "+spawnerRotation);
        Vector3 forward = spawnerList[randomSpawner].transform.position+spawnerList[randomSpawner].transform.forward*spacing;
        forward = forward + new Vector3(0,-1,0);
        // Debug.Log("Spawner "+randomSpawner+" forward "+forward);

        GameObject ball = Instantiate(ballTemplateList[0], 
        forward,spawnerList[randomSpawner].gameObject.transform.rotation);

        ballList.Add(ball);
    }
}
