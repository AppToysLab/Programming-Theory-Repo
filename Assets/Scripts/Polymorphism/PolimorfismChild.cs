using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PolimorfismChild : PolimorfismBasic
{
    public int instanceCount;
    void Start()
    {
        Show(instanceCount);
    }

    public override void Show(int count)
    {
        switch (count)
        {
            case 1: Show1(count);
                    
                break;
            case 2:
                Show2(count);
                break;
            case 3:
                Show3(count);
                break;
        }
    }

    

    void Show1(int numberOfShow)
    {
        GetComponentInChildren<Image>().color = Color.green ;
        GetComponentInChildren<TextMeshProUGUI>().text = "Child " + instanceCount;

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

    void Show2(int numberOfShow)
    {
        GetComponentInChildren<Image>().color = Color.yellow;
        GetComponentInChildren<TextMeshProUGUI>().text = "Child " + instanceCount;
        IEnumerator Rotate()
        {
            float i = 1;
            while (true)
            {
                transform.rotation = Quaternion.Euler( transform.rotation.x + i , 1 , 0);
                i += 0.2f;
                yield return null;
            }
        }
        StartCoroutine(Rotate());
    }

    void Show3(int numberOfShow)
    {
        GetComponentInChildren<Image>().color = Color.cyan;
        GetComponentInChildren<TextMeshProUGUI>().text = "Child " + instanceCount;
        RectTransform rt;
        rt = GetComponent<RectTransform>();
        IEnumerator Scaling()
        {
            float i = 0.1f;
            while (true)
            {
                rt.localScale = new Vector3(i, i, 1);
                i += 0.0015f;
                if (i > 0.99f)
                {
                    i = 0;
                }
                yield return null;
            }
        }
        StartCoroutine(Scaling());
    }

}
