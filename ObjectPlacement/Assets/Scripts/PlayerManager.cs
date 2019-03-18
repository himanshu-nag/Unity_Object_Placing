using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    public GameObject m_sphere;
	private void Start()
	{
        Cursor.visible = false;
	}

	public void SelectObj(GameObject gameObject)
    {
        gameObject.GetComponent<ObjectPlace>().SetObject();
    }

    public void DeselectObj(GameObject gameObject)
    {
        gameObject.GetComponent<ObjectPlace>().PlaceObject();
    }

	private void Update()
	{
        if (Input.GetMouseButton(0))
            SelectObj(m_sphere);
        else if (Input.GetMouseButton(1))
            DeselectObj(m_sphere);
	}
}
