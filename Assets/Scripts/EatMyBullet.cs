using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatMyBullet : MonoBehaviour {

    public float bulletSpeed = 20f;

    void Update() {
       transform.Translate(Vector3.up * Time.deltaTime * bulletSpeed);
    }
}
