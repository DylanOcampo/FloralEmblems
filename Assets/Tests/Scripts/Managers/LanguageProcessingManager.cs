using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageProcessingManager : MonoBehaviour
{
    private static LanguageProcessingManager _instance;

	public static LanguageProcessingManager instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = FindAnyObjectByType<LanguageProcessingManager>();
			}
			return _instance;
		}
	}

    //cosas que tienen que ser privadas
    public List<string> userMessage = new List<string>();
    public List<string>  currentMessage = new List<string>();

    //Cosas que sin ppublicas
    public List<BoquetObject>  currentBoquet = new List<BoquetObject>();
	
    public void UpdateCurrentMessage(List<string> _newMessage){
        currentMessage = _newMessage;
    }

	public void CheckCurrentBoquet(List<BoquetObject> _userBoquet){
		currentBoquet = FormatBoquetMeaning(_userBoquet);

	}

	private List<BoquetObject> FormatBoquetMeaning(List<BoquetObject> _currentBoquet){
		return _currentBoquet;
	}

}
