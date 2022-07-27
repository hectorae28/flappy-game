using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addScoreScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        score.Score++;
    }
}
