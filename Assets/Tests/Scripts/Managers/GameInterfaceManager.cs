using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;



public class GameInterfaceManager : MonoBehaviour
{
    public GameObject Camera, PF_Flower;

    public Transform CameraUp, CameraDown;
    
    private static GameInterfaceManager _instance;

	public static GameInterfaceManager instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = FindAnyObjectByType<GameInterfaceManager>();
			}
			return _instance;
		}
	}
    public void MoveCameraUp(){
        Camera.transform.DOMove(CameraUp.position, 1);
    }

    public void MoveCameraDown(){
		Camera.transform.DOMove(CameraDown.position, 1);
    }

}
