using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {


    public float speed;
    public float maxZ = 1f;
    public float moveZ = 0f;
    public float moveY = 0f;
    public float radius = 0f;
    public float time;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime * speed;
        moveZ = Mathf.Cos(time) * radius;
        moveY = Mathf.Sin(time) * radius;
        transform.position = new Vector3(moveZ, moveY);

    }
}
