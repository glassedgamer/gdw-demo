using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 10f;

    float hInput;
    float vInput;

    public GameObject ball;
    public Transform bulletSpawn;

    void Update() {
        hInput = Input.GetAxisRaw("Horizontal");
        vInput = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * hInput * speed);
        transform.Translate(Vector3.up * Time.deltaTime * vInput * speed);

        if(Input.GetKeyDown(KeyCode.Space)) {
           Instantiate(ball, bulletSpawn.position, Quaternion.identity);
       }
    }
}
