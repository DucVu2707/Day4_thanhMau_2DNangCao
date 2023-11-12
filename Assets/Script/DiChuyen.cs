using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiChuyen : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Rigidbody2D  rb;

    public Text txtPlayerName;
   // Start is called before the first frame update
   void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 diChuyen = new Vector2(x, y) * moveSpeed;
        rb.velocity = diChuyen;

        Vector3 vector3 = transform.position;
        vector3.y = vector3.y + 1.5f;
        txtPlayerName.transform.position = vector3;
    }
}
