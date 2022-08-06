using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public static int Score=0;
    public static int RealScore=0;
    // Start is called before the first frame update
    void Start()
    {
        Score=0;
        RealScore=0;
    }

    // Update is called once per frame
    void Update()
    {
        RealScore=Score / 4;
        GetComponent<UnityEngine.UI.Text>().text = RealScore.ToString();
    }
}
