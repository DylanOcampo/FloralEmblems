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
	public SO_BouquetList so_bouquetList;
	public SO_MessageList so_messageList;


    //cosas que tienen que ser privadas
	public List<message> messageList= new List<message>();
    public string[] currentMessage;
	private int currentMessageListPosition;

    //Cosas que si son ppublicas
    public List<BouquetObject>  currentBoquet = new List<BouquetObject>();

	private void Start() {
		currentMessageListPosition = 0;
		messageList = so_messageList.messageObjectContainer;
	}

	public void SetNewMessage(){
		GameManager.instance.messageToPlay.text = messageList[currentMessageListPosition].userText;
		currentMessage = messageList[currentMessageListPosition].processingText.Split(" ");
		currentMessageListPosition++;
	}

	public void AddObjectToBouquet(BouquetObject _BoObject ){
		currentBoquet.Add(_BoObject);
		if(CheckCurrentBoquet()){
			
		}
	}

	public void RemoveObjectToBouquet(BouquetObject _BoObject ){
		currentBoquet.Remove(_BoObject);
	}

    public void UpdateCurrentMessage(string[] _newMessage){
        currentMessage = _newMessage;
    }

	public bool CheckCurrentBoquet(){
		List<string> _text = new List<string>();
		foreach (BouquetObject item in currentBoquet)
		{
			_text.Add(item.currentMeaning.meaningText);
		}

		if(_text.ToArray() == currentMessage){
			return true;
		}else{
			return false;
		}


	}

	private List<BouquetObject> FormatBoquetMeaning(List<BouquetObject> _currentBoquet){

		return _currentBoquet;
	}

}
