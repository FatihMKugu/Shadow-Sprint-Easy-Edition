using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text scoreText;
    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider degen)
    {
        if (degen.gameObject.tag == "Player")
            Destroy(gameObject);
            score++;
    }
    private void Update()
    {
        scoreText.text = "Score: " + Mathf.Round(score);
    }
}
