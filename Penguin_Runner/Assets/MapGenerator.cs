using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MapGenerator : MonoBehaviour {
    public List<GameObject> boxes;
    public GameObject boxPrefab;
    public Transform playerPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		foreach(GameObject box in boxes)
        {
            if(box.transform.position.x+35 < playerPosition.position.x)
            {
                // remove old box
                boxes.Remove(box);
                Object.Destroy(box);

                // create new box and set position at the "end of the world" :P
                GameObject newBox = Instantiate(boxPrefab);
                newBox.transform.position = new Vector2(box.transform.position.x + 150, box.transform.position.y);
                boxes.Add(newBox);
            }

        }
    }
}
