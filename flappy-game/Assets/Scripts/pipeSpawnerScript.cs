using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawnerScript : MonoBehaviour
{
    public float maxtimer;
    private float timer;
    public GameObject pipes;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>maxtimer){
            GameObject newpipe= Instantiate(pipes);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height,height),0);
            Destroy(newpipe,5);
            timer=0;
        }
        timer += Time.deltaTime;
    }
}
