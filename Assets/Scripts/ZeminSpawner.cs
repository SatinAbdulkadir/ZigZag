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
            zemin_olu�tur();
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void zemin_olu�tur()
    {
        Vector3 y�n;
        if (Random.Range(0, 2)==0)
        {
            y�n = Vector3.left;
        }
        else
        {
            y�n = Vector3.forward;
        }
        son_zemin=Instantiate(son_zemin, son_zemin.transform.position + y�n,son_zemin.transform.rotation);
    }
}
