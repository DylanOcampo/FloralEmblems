using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouquetObjectContainer : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public BoquetObject self;


    public void Initialize(BoquetObject _currentObject){
        self = _currentObject;
        spriteRenderer.sprite = self.currentMeaning.image;

    }
}
