using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerPlacerSys : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Flower"){
            other.gameObject.transform.position = gameObject.transform.position;
            LanguageProcessingManager.instance.AddObjectToBouquet(other.gameObject.GetComponent<BouquetObjectContainer>().self, gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        
        if (other.tag == "Flower"){
            
            LanguageProcessingManager.instance.RemoveObjectToBouquet(other.gameObject.GetComponent<BouquetObjectContainer>().self);
            
        }
    }
}
