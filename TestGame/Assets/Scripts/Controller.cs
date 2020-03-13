using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    /*
     TODO:
        - Сделать прыжок персонажа более плавным
        - Инверсить спрайт при ходьбе в обратную сторону
     */

    public float speed = 50f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + Vector2.right * x * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(Vector2.up * 8000);
    }
}
