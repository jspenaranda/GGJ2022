using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIKey : MonoBehaviour
{
    private int keyAmount;
    // private int maxHearts;

    public Image[] keyParts;
    public Sprite keyPart;
    public Sprite emptyKey;

    void Start()
    {
        keyParts = transform.GetComponentsInChildren<Image>();       
    }

}

