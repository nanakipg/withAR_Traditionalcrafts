using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUI : MonoBehaviour
{
    [SerializeField] List<GameObject> uiList = new List<GameObject>();
    private bool isHide;
    public void ChangeUI()
    {
        if (!isHide)
        {
            for (int i = 0; i < uiList.Count; i ++ )
            {
                uiList[i].SetActive(false);
            }
            isHide = true;
        }
        else
        {
            for (int i = 0; i < uiList.Count; i ++ )
            {
                uiList[i].SetActive(true);
            }

            isHide = false;
        }
    }
}
