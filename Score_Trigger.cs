using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Trigger : MonoBehaviour
{
    public GameManager score;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindObjectOfType<GameManager>().GetComponent<GameManager>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.layer == 3)
        {
          score.addScore(2);
        }
    }
}
