using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void GoToScene(int number)
    {
      SceneManager.LoadScene(number);
    }

    //public void GoToScenePolymorphism()
    //{

    //}

    //public void GoToSceneInheritance()
    //{

    //}

    //public void GoToSceneEncapsulation()
    //{

    //}

    //public void GoToSceneAbstraction()
    //{

    //}

    
}
