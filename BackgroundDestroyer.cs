using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundDestroyer : MonoBehaviour
{
    void Update()
    {
        if (this.transform.position.y <= -6)
        {
            destroy();
        }
    }
    void destroy()
    {
        Destroy(this.gameObject);
    }
}
