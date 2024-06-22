using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolContainer : MonoBehaviour
{
    public ToolType toolType;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Flower") {
            ToolProcess(other.GetComponent<BouquetObjectContainer>().self);
        }
    }
    private void ToolProcess(BouquetObject _bouquetObject){
        if(toolType == ToolType.Scissors){
            if(_bouquetObject.currentMeaning.reference == meaningType.UnCut){
                foreach (Meaning item in _bouquetObject.meanings)
                {
                    if(item.reference == meaningType.Cut){
                        _bouquetObject.currentMeaning = item;
                    }
                    
                }
                
            }
        }
        
    }
}
