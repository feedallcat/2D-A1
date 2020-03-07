using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private float backGroundWidth;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        backGroundWidth = (float)boxCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -backGroundWidth * 1.5f)
            transform.position = (Vector2)transform.position + new Vector2(backGroundWidth * 3, 0);
    }
}
