using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MainUIHandler : MonoBehaviour
{
    //ENCAPSULATION
    public static MainUIHandler Instance { get; private set; }
    [SerializeField] private GameObject panel;
    [SerializeField] private TextMeshProUGUI plantName;
    [SerializeField] private TextMeshProUGUI description;
    [SerializeField] private TextMeshProUGUI cost;

    private Plant _selectedPlant;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    //ABSTRACTION
    public void SetUI(string plantName, string description , int cost , Plant plantReference)
    {
        ShowPanel();
        this.plantName.text = new string("Plant: " + plantName);
        this.description.text = new string("Description: " + description);
        this.cost.text = new string("cost: " + cost);
        _selectedPlant = plantReference;
    }

    private void ShowPanel()
    {
        panel.SetActive(true);
    }

    public void PurchaseButtonClicked()
    {
        if (_selectedPlant != null)
        {
            _selectedPlant.Purchase();
        }
    }
}
