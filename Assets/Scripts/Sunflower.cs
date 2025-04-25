using UnityEngine;

//INHERITANCE
public class Sunflower : Plant
{
    //POLYMORPHISM
    public override void Purchase()
    {
        Debug.Log("-(-800) to health");
        base.Purchase();
    }
}
