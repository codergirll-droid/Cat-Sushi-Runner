using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{

    public bool isAxe;
    public bool isSaw;

    private void Start()
    {
        
    }
    public void Update()
    {
        if (isAxe)
        {
            transform.eulerAngles = new Vector3(0, 0, Mathf.PingPong(Time.time * 60, 90) - 45);

        }else if (isSaw)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 200);
        }
    }

}
