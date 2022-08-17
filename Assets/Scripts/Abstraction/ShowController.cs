using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowController : MonoBehaviour
{
    
    public void ToShow(IShow item)
    {
        item.Show(Random.Range(1,5));
    }

    public void StartShow()
    {
        IShow iShow = GameObject.Find("ShowMaker").GetComponent<ShowMaker>();
        ToShow(iShow);
    }
    
}
