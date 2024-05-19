using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BookManager : MonoBehaviour
{
    public int PagNumber = 0;
    private SO_BouquetList so_bouquetList;

    public SpriteRenderer mainFlower;
    public TextMeshPro flowerName;

    public List<SpriteRenderer> FlowerList = new List<SpriteRenderer>();
    public List<TextMeshPro> TextList = new List<TextMeshPro>();

    private void Start() {
        so_bouquetList = GameManager.instance._languageProcessingManager.so_bouquetList;
        FlowerPage();
    }

    private void FlowerPage(){
        BoquetObject _boquetObject = so_bouquetList.bouquetObjectContainers[PagNumber];
        flowerName.text = _boquetObject.name;
        mainFlower.sprite = _boquetObject.currentMeaning.image;

        for (int i = 0; i < _boquetObject.meanings.Count; i++)
        {
            TextList[i].text = _boquetObject.meanings[i].meaningText;
            FlowerList[i].sprite = _boquetObject.meanings[i].image;
        }

        if(_boquetObject.meanings.Count <FlowerList.Count ){
            for (int i = _boquetObject.meanings.Count; i < FlowerList.Count; i++)
            {
                TextList[i].text = "";
                FlowerList[i].sprite = null;
            }
        }

        
    }

    public void OnClick_ChangePage(int _value){
        PagNumber = PagNumber + _value;
        if(PagNumber < 0){
            PagNumber = 0;
        }

        if(PagNumber > so_bouquetList.bouquetObjectContainers.Count-1){
            PagNumber = so_bouquetList.bouquetObjectContainers.Count-1;
        }
        FlowerPage();
    }


}
