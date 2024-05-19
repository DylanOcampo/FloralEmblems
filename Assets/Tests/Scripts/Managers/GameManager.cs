using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public LanguageProcessingManager _languageProcessingManager;

    private static GameManager _instance;

	public static GameManager instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = FindAnyObjectByType<GameManager>();
			}
			return _instance;
		}
	}
    
    public GameObject MainMenu;

    //Test stuff vvvvvvv
    public GameObject GameTest;
    public TextMeshPro messageToPlay;

    public List<BouquetObjectContainer> BouquetsToSpawn = new List<BouquetObjectContainer>();


    public void InitializeGame(){

    }

    public void OnClick_InitializeGameTest(){
        MainMenu.SetActive(false);
        GameTest.SetActive(true);
        _languageProcessingManager.SetNewMessage();
    }

}
