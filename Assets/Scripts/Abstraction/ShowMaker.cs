// ---------------------------------------------- ABSTRACTION
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class ShowMaker : MonoBehaviour, IShow
    {
        public GameObject squre;
        public string Show(int scale)
        {   
            squre.SetActive(true);
            string description = "show is run";
            return description;
        }
        
    }
