using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageProcessingManager : MonoBehaviour
{
	public SO_BouquetList so_bouquetList;
	public SO_MessageList so_messageList;

    //cosas que tienen que ser privadas
	public List<message> messageList= new List<message>();
    public string[] currentMessage;

    //Cosas que si son ppublicas
    public List<BoquetObject>  currentBoquet = new List<BoquetObject>();

	private void Start() {
		messageList = so_messageList.messageObjectContainer;
	}

	public void SetNewMessage(){
		GameManager.instance.messageToPlay.text = messageList[0].userText;
		currentMessage = messageList[0].processingText.Split(" ");
		messageList.RemoveAt(0);
	}

    public void UpdateCurrentMessage(string[] _newMessage){
        currentMessage = _newMessage;
    }

	public void CheckCurrentBoquet(List<BoquetObject> _userBoquet){
		currentBoquet = FormatBoquetMeaning(_userBoquet);

	}

	private List<BoquetObject> FormatBoquetMeaning(List<BoquetObject> _currentBoquet){
		return _currentBoquet;
	}

}
