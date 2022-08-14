using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PolimorfismChild : PolimorfismBasic
{
    public int instanceCount;
    void Start()
    {
        Show(instanceCount);
    }

    void Update()
    {
        
    }

    public override void Show(int count)
    {
        switch (count)
        {
            case 1:  Show1(count);
            break;
            case 2:
                Show2(count);
                break;
            case 3:
                Show3(count);
                break;
        }

      //  print("New content of the method Show()");
    }

    void Show1(int numberOfShow)
    {
        print("Show nunber " + numberOfShow);
    }

    void Show2(int numberOfShow)
    {
        print("Show nunber " + numberOfShow);
    }

    void Show3(int numberOfShow)
    {
        print("Show nunber " + numberOfShow);
    }

}
