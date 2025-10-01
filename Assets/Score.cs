using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update

    public Text score;
    public Transform p;
    // Update is called once per frame
    void Update()
    {
        // int a = 1;
        float a = p.transform.position.y - 2;
        score.text = a.ToString();
    }
}
