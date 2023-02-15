using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerLASER : MonoBehaviour
{
    void Update()
    {
        if (this.transform.position.y >= 5)
        {
            destroy();
        }
    }
    void destroy()
    {
        Destroy(this.gameObject);
    }
}
