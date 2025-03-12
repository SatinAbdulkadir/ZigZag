using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminSpawner : MonoBehaviour
{
    public GameObject son_zemin;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            zemin_oluþtur();
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void zemin_oluþtur()
    {
        Vector3 yön;
        if (Random.Range(0, 2)==0)
        {
            yön = Vector3.left;
        }
        else
        {
            yön = Vector3.forward;
        }
        son_zemin=Instantiate(son_zemin, son_zemin.transform.position + yön,son_zemin.transform.rotation);
    }
}
