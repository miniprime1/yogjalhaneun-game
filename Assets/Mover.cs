using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 5.0f;

     void Update() {
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
        } if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
        } if (Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(new Vector3(0,0,-speed * Time.deltaTime));
        } if (Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(new Vector3(0,0,speed * Time.deltaTime));
        } if (Input.GetKey(KeyCode.Space)) {
            transform.Translate(new Vector3(0,speed * Time.deltaTime,0));
        } if (Input.GetKey(KeyCode.LeftShift)){
            transform.Translate(new Vector3(0,-speed * Time.deltaTime,0));
        }
    }
}
