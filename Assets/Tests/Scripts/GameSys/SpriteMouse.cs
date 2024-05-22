using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum InterfaceType
{
    None,
    CameraMove,
    BookManagerFlower,
    BookManagerSpawn
}
public class SpriteMouse : MonoBehaviour
{
    public bool Up;

    public bool Book;
    public int FlowerValue;

    public InterfaceType _interface;

    void OnMouseDown(){
        if(_interface == InterfaceType.BookManagerFlower){
            if(Book){
                BookManager.instance.OnClick_ChangePage(1);
            }else{
                BookManager.instance.OnClick_ChangePage(-1);
            }
            return;
        }

        if(_interface == InterfaceType.CameraMove){
            if(Up){
                GameInterfaceManager.instance.MoveCameraUp();
            }else{
                GameInterfaceManager.instance.MoveCameraDown();
            }
            return;
        }

        if(_interface == InterfaceType.BookManagerSpawn){
            
            BookManager.instance.SpawnFlower(FlowerValue);
            
            return;
        }


        
        
        


        


    }
}
