using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerLaserEnemy : MonoBehaviour
{
    void Update()
    {
        if (this.transform.position.y <= -7)
        {
            destroy();
        }
    }
    void destroy()
    {
        Destroy(this.gameObject);
    }
}
