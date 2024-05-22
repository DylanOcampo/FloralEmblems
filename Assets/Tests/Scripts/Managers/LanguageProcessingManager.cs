using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
		currentBoquet.Clear();
		GameManager.instance.messageToPlay.text = messageList[currentMessageListPosition].userText;
		currentMessage = messageList[currentMessageListPosition].processingText.Split(" ");
		currentMessageListPosition++;
	}

	public void AddObjectToBouquet(BouquetObject _BoObject, GameObject _flower ){
		if(_flower == null){
			return;
		}
		if(currentBoquet.Contains( _BoObject )){
			return;
		}
		
		currentBoquet.Add(_BoObject);
		if(CheckCurrentBoquet()){
			GameManager.instance.NextMessage();
		}
	}

	public void RemoveObjectToBouquet(BouquetObject _BoObject ){
		if(!currentBoquet.Contains( _BoObject )){
			return;
		}
		currentBoquet.Remove(_BoObject);
		if(CheckCurrentBoquet()){
			GameManager.instance.NextMessage();
		}
	}

    public void UpdateCurrentMessage(string[] _newMessage){
        currentMessage = _newMessage;
    }

	public bool CheckCurrentBoquet(){
		if(currentBoquet.Count != currentMessage.Length){
			return false;
		}

		List<string> _text = new List<string>();
		foreach (BouquetObject item in currentBoquet)
		{
			_text.Add(item.currentMeaning.meaningText);
		}



		for (int i = 0; i < _text.Count; i++)
		{
			if(_text[i] != currentMessage[i]){
				return false;
			}
			
		}
		return true;
	}

}
