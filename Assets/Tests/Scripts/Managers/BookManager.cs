using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BookManager : MonoBehaviour
{
    private static BookManager _instance;

	public static BookManager instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = FindAnyObjectByType<BookManager>();
			}
			return _instance;
		}
	}
    public int PagNumber = 0;
    public GameObject PF_Flower;

    public SpriteRenderer mainFlower;
    public TextMeshPro flowerName;

    public List<SpriteRenderer> FlowerList = new List<SpriteRenderer>();
    public List<TextMeshPro> TextList = new List<TextMeshPro>();

    public bool DebugMode = true;

    private void Start() {
        FlowerPage();
    }

    public void SpawnFlower(int _value){
        BouquetObject _boquetObject = LanguageProcessingManager.instance.so_bouquetList.bouquetObjectContainers[PagNumber];
        _boquetObject.currentMeaning = _boquetObject.meanings[_value];
        GameObject instance = GameObject.Instantiate(PF_Flower);
        instance.transform.SetParent(GameManager.instance.FlowerContainer.transform, false);

        instance.GetComponent<BouquetObjectContainer>().Initialize(_boquetObject);
    }

    private void FlowerPage(){
        BouquetObject _boquetObject = LanguageProcessingManager.instance.so_bouquetList.bouquetObjectContainers[PagNumber];
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

        if(PagNumber > LanguageProcessingManager.instance.so_bouquetList.bouquetObjectContainers.Count-1){
            PagNumber = LanguageProcessingManager.instance.so_bouquetList.bouquetObjectContainers.Count-1;
        }
        FlowerPage();
    }


}
