//-------------------------------------------------------------- INHERITANCE
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Parent : MonoBehaviour
{
    private int countChilds = 1;
    public Transform canvas;
    public GameObject childPrefab;
    public GameObject childTextPrefab;
    public GameObject childInputField;
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

    public void SplitString()
    {
        text = new char[1000];
        text = textForPrint.ToCharArray();

        IEnumerator PrintToSpell()
        {
            string textForShowing = "";
            foreach (var item in text)
            {
                textForShowing += item;
                GetComponentInChildren<TextMeshProUGUI>().text = textForShowing;

                yield return new WaitForSeconds(0.06f);
                yield return textForShowing;
            }

        }
        StartCoroutine(PrintToSpell());
    }


    public void CreateChildClass()
    {
        

        if (countChilds < 4)
        {
            GameObject prefab = new GameObject();
            xPosChildObject.Add(countChilds * stepXPos);
            if (countChilds == 1)
            {
                prefab = childPrefab;
            }
            if (countChilds == 2)
            {
                prefab = childTextPrefab;
            }
            if (countChilds == 3)
            {
                prefab = childInputField;
            }
            GameObject child = Instantiate(prefab,
                                    new Vector3(leftBound + xPosChildObject[xPosChildObject.Count - 1],
                                    canvas.transform.position.y - 180, 0),
                                    childPrefab.transform.rotation);

            child.transform.SetParent(canvas);
            child.AddComponent<Child>();
            countChilds++;
        }
    }

    public void Show()
    {
      //  GetComponent<Image>().color = Color.green;

        IEnumerator Rotate()
        {
            float i = 0.1f;
            while (true)
            {
                transform.rotation = Quaternion.Euler(0, 0, transform.rotation.z + i);
                i += 0.2f;
                yield return null;
            }
        }
        StartCoroutine(Rotate());
    }

}
