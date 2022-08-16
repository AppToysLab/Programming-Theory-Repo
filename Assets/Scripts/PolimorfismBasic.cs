using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PolimorfismBasic : MonoBehaviour
{
    private int countChilds = 1;
    public Transform canvas;
    public GameObject buttonPrefab;
    public GameObject voidText;

    [SerializeField]
    float leftBound;
    [SerializeField]
    private float stepXPos;
    [SerializeField]
    private List<float> xPosChildObject;

    public char[] text;
    [SerializeField]
    public string textForPrint = "";

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
                                   canvas.transform.position.y -180, 0), 
                                   buttonPrefab.transform.rotation);

           polimorfChild.transform.SetParent(canvas);
           polimorfChild.AddComponent<PolimorfismChild>();
           polimorfChild.GetComponent<PolimorfismChild>().instanceCount = countChilds;
           countChilds++;
        }
    }

   public virtual void Show(int count)
    {
        voidText.SetActive(true);
        SplitString();
    }

    public void SplitString()
    {
        text = new char [1000];
        text = textForPrint.ToCharArray();
        
        IEnumerator PrintToSpell()
        {
            string textForShowing = "";
            foreach (var item in text)
            {
                textForShowing += item;
                GetComponentInChildren<TextMeshProUGUI>().text = textForShowing;

                yield return new WaitForSeconds(0.1f);
                yield return textForShowing;
            }
            
        }
        StartCoroutine(PrintToSpell());
    }

}

