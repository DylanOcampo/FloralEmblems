using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

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
    
    public GameObject MainMenu, FlowerContainer;

    //Test stuff vvvvvvv
    public GameObject GameTest;
    public TextMeshPro messageToPlay;

    public void NextMessage(){
        LanguageProcessingManager.instance.SetNewMessage();
        foreach (Transform child in FlowerContainer.transform)
        {
            Destroy(child.gameObject) ;
        }
    }

    public void OnClick_InitializeGameTest(){
        MainMenu.SetActive(false);
        GameTest.SetActive(true);
        LanguageProcessingManager.instance.SetNewMessage();
    }

}
