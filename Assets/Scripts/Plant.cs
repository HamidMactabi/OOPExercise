using UnityEngine;

public class Plant : MonoBehaviour
{
    public string itemName;
    public string description;
    public int cost = 50;

    protected virtual void Awake()
    {
        if (string.IsNullOrEmpty(itemName)) itemName = "item";
        if (string.IsNullOrEmpty(description)) description = "there is no description for this item yet ...";
    }

    protected virtual void OnMouseDown()
    {
        MainUIHandler.Instance.SetUI(itemName,description,cost,this);
    }

    public virtual void Purchase()
    {
        Destroy(gameObject);
    }
}
