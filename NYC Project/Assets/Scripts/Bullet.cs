using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;

    private static int score = 0;
    public Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
        scoreText = GameObject.FindGameObjectWithTag("Counter").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bird")
        {
            Destroy(col.gameObject);
            score += 1;
            scoreText.text = score + "";
        }
    }
}
