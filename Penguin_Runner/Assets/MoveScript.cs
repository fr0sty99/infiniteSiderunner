using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using System;

public class MoveScript : MonoBehaviour {
    public Rigidbody2D rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
	}

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector2 posToMove = new Vector2();
            posToMove.x = rigidbody.transform.position.x - 1;
            posToMove.y = rigidbody.transform.position.y;
            rigidbody.MovePosition(posToMove);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector2 posToMove = new Vector2();
            posToMove.y = rigidbody.transform.position.y + 1;
            posToMove.x = rigidbody.transform.position.x;
            rigidbody.MovePosition(posToMove);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector2 posToMove = new Vector2();
            posToMove.y = rigidbody.transform.position.y - 1;
            posToMove.x = rigidbody.transform.position.x;
            rigidbody.MovePosition(posToMove);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Vector2 posToMove = new Vector2();
            posToMove.x = rigidbody.transform.position.x + 1;
            posToMove.y = rigidbody.transform.position.y;
            rigidbody.MovePosition(posToMove);
        }
    }

}
