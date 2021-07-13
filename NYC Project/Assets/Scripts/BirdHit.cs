using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class BirdHit : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OntriggerEnter2D(Collider2D col)
    {

        int score = int.Parse(scoreText.text);
        scoreText.text = (score + 1) + "";

    }

}
