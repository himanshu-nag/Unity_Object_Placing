using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlaceManager : MonoBehaviour {

    [Header("Increament in value decrease the cursor movement speed")]
    [Tooltip("Default is 100")]
    [Range(1, 100)]
    public int moveSpeedDivider = 100;
    public Material isHighlighted;
    public KeyCode rotateLeft, rotateRight;
}
