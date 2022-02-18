using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour { 

    public GameObject score;



    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }


}
