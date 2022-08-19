using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    bool yellowColor = true;

    private void Start()
    {
      //  Coloring();
    }


    //public void StartRotation(bool rotation, float angle)
    //{
    //   Rotation(rotation, angle);
    //}

    public void Rotation(bool rotation, float angle)
    {
        IEnumerator MakeRotation()
        {
            while (rotation)
            {
                transform.rotation = Quaternion.Euler(0,0,  angle);
                angle += 1f;
                yield return null;
            }
        }
        if (rotation)
        {
            StartCoroutine(MakeRotation());
            Coloring();
        }
        else
        {
            StopCoroutine(MakeRotation());
            StopAllCoroutines();
        }
    }

    private void Coloring()
    {
        IEnumerator ChangeColor()
        {
            while (true)
            {
                yellowColor = !yellowColor;
                if (yellowColor)
                {
                    GetComponent<UnityEngine.UI.Image>().color = Color.yellow;
                }
                else
                {
                    GetComponent<UnityEngine.UI.Image>().color = Color.blue;
                }
                yield return new WaitForSeconds(1);
            }
        }
        StartCoroutine(ChangeColor());
    }

    void Update()
    {
        //   Coloring();
    }

}
