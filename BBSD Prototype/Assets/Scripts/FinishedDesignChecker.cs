using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinishedDesignChecker : MonoBehaviour
{
    public List<GameObject> shoeSprites;
    public List<GameObject> shoeUIs;

    public List<bool> completedList;
    public int checkCount;
    public bool designComplete = false;
    public Animator finishedUI;

    public TMP_Text fracText;

    void Start()
    {
        for (int i = 0; i < shoeSprites.Count; i++)
        {
            completedList.Insert(i,false);
        }
    }

   void Update()
    {
        checkCount = 0;

        for (int i = 0; i < shoeSprites.Count; i++)
        {
            if (shoeSprites[i].GetComponent<SpriteRenderer>().color == shoeUIs[i].GetComponent<Image>().color)
            {
                completedList[i] = true;
            }
            else
            {
                completedList[i] = false;
            }
        }

        for (int i = 0; i < completedList.Count; i++)
        {
            if (completedList[i] == true)
            {
                checkCount++;
            }
        }

        fracText.text = checkCount.ToString() + "/" + shoeSprites.Count.ToString();

        if (checkCount == shoeSprites.Count && designComplete == false)
        {
            Debug.Log("DesignFnished");
            designComplete = true;
            finishedUI.SetTrigger("BringIn");            
        }        
    }
}
