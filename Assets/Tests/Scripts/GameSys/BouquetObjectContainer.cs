using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BouquetObjectContainer : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public BouquetObject self;
    public TextMeshPro debugText;
    public bool Debug = true;


    public void Initialize(BouquetObject _currentObject){
        self = _currentObject;
        spriteRenderer.sprite = self.currentMeaning.image;
        if(Debug){
            debugText.text = self.currentMeaning.meaningText;
        }
        
    }
}
