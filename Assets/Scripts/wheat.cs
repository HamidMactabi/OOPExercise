using UnityEngine;

public class wheat : Plant
{
    public override void Purchase()
    {
        Debug.Log("+1 to health");
        base.Purchase();
    }
}
