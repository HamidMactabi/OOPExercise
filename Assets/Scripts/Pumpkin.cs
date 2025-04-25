using System;
using UnityEngine;

public class Pumpkin : Plant
{
    public override void Purchase()
    {
        Debug.Log("+999 to health");
        base.Purchase();
    }
}