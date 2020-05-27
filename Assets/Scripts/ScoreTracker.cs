using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    // Start is called before the first frame update
    private float HighestPoint = 0.0f;

    public Player player;
    Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y > HighestPoint)
        {
            HighestPoint = player.transform.position.y;
            text.text = ((int)(10*HighestPoint)).ToString();
        }
    }
}
