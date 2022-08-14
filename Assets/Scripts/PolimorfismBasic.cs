using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolimorfismBasic : MonoBehaviour
{
    private int countChilds = 1;
    public Transform canvas;
    public GameObject buttonPrefab;

    [SerializeField]
    float leftBound;
    [SerializeField]
    private float stepXPos;
    [SerializeField]
    private List<float> xPosChildObject;

    void Start()
    {
        xPosChildObject = new List<float>(1);
    }

   public void CreateChildClass()
    {
       if(countChilds < 4)
        {
           xPosChildObject.Add(countChilds * stepXPos);
           GameObject polimorfChild = Instantiate(buttonPrefab,
                                   new Vector3( leftBound + xPosChildObject[xPosChildObject.Count - 1], 
                                   canvas.transform.position.y + 50, 0), 
                                   buttonPrefab.transform.rotation);

           polimorfChild.transform.SetParent(canvas);
           polimorfChild.AddComponent<PolimorfismChild>();
           polimorfChild.GetComponent<PolimorfismChild>().instanceCount = countChilds;
           countChilds++;
        }
    }

   public virtual void Show(int count)
    {
        Debug.Log("Parent");
    }

}

