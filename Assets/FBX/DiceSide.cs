using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceSide : MonoBehaviour
{
    bool onGround;
    public int sideValue;

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "ground")
        {
            onGround = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "ground")
        {
            onGround = false;
        }
    }

    public bool OnGround()
    {
        return onGround;
    }

}
