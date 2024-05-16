using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BouquetObjectContainer : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public BoquetObject self;
    public TextMeshPro debugText;
    public bool Debug;


    public void Initialize(BoquetObject _currentObject){
        self = _currentObject;
        spriteRenderer.sprite = self.currentMeaning.image;
        debugText.text = self.currentMeaning.meaningText;
    }
}
