using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerPlacerSys : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Flower"){
            Debug.Log("b");
            other.gameObject.transform.position = gameObject.transform.position;
            LanguageProcessingManager.instance.currentBoquet.Add(other.gameObject.GetComponent<BouquetObjectContainer>().self);
            //LanguageProcessingManager.instance.CheckCurrentBoquet();
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        Debug.Log("a2");
        if (other.tag == "Flower"){
            Debug.Log("b2");
            LanguageProcessingManager.instance.currentBoquet.Remove(other.gameObject.GetComponent<BouquetObjectContainer>().self);
            
        }
    }
}
