using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {
    public GameObject cam;
    public Transform player;

    public float smoothTime = 0.3F;
    private Vector2 velocity = Vector2.zero;

    // Use this for initialization
    void Start () {
		
	}
	
	void FixedUpdate () {

        // Define a target position above and behind the target transform
        Vector2 targetPosition = player.TransformVector(new Vector2(0, 0));

        // Smoothly move the camera towards that target position
        transform.position = Vector2.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
