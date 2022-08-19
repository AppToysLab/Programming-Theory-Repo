// ENCAPSULATION
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    [SerializeField]
    bool rotation = false;
    float angle = 0;
    public void MakeItemRotation()
    {
        rotation = !rotation;
        Item item = FindObjectOfType<Item>();
        item.Rotation(rotation, angle);
    }
}
