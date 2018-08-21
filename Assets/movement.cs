using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;
    public Text score;
    public int count;

    // Use this for initialization
    void Start()
    {
        speed = 10.0f;
        rotationSpeed = 100.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float vTranslation = speed;
        


        vTranslation *= Time.deltaTime;


        transform.Translate(0, 0, vTranslation);
        
        score.text = "score: " + count.ToString();


    }
        
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "yellowbrick")
        {
            GameObject g = other.gameObject;
            Destroy(g);
            count += 10;
        }
    }
}