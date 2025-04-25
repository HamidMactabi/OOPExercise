using UnityEngine;

public class Apple : Plant
{
    public override void Purchase()
    {
        Debug.Log("+100 to health");
        Debug.Log("Keeps the doctors away");
        base.Purchase();
    }
}
