using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseItem : MonoBehaviour
{
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
    
    public void CloseItemList()
    {
        SelectButton.SetActive(true);
        ItemCanvas.SetActive(false);
    }
}
