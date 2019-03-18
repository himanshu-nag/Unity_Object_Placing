using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectPlace : MonoBehaviour {
    
    internal bool isSelected = false;
    private Material isPlaced;
    private ObjectPlaceManager manager;
    int moveSpeedDivider;
    KeyCode rotateLeft, rotateRight;

	private void Awake()
	{
        manager = FindObjectOfType<ObjectPlaceManager>();
        moveSpeedDivider = manager.moveSpeedDivider;
        rotateLeft = manager.rotateLeft;
        rotateRight = manager.rotateRight;
        isPlaced = GetComponent<Renderer>().material;
	}
	public void SetObject()
    {
        isSelected = true;
        GetComponent<Renderer>().material = manager.isHighlighted;
    }

	void Update () {
        if(isSelected)
        {
            transform.position = new Vector3(Input.mousePosition.x/moveSpeedDivider,transform.position.y,Input.mousePosition.y / moveSpeedDivider);    
            if(Input.GetKey(rotateLeft))
                transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);
            else if(Input.GetKey(rotateRight))
                transform.RotateAround(Vector3.zero, Vector3.down, 20 * Time.deltaTime);
        }
	}

    public void PlaceObject()
    {
        isSelected = false;
        GetComponent<Renderer>().material = isPlaced;
    }
}
