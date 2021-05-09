using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectItem : MonoBehaviour
{
    public List<ItemData> itemDataList = new List<ItemData>();
    [SerializeField] private GameObject ItemCanvas;
    [SerializeField] private GameObject SelectButton;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowItemList()
    {
        SelectButton.SetActive(false);
        ItemCanvas.SetActive(true);
    }
}
