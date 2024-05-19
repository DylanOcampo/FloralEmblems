using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMouse : MonoBehaviour
{
    public bool Up;

    public bool Book;

    public BookManager _bookManager;
    void OnMouseDown(){

        if(_bookManager != null){
            if(Book){
                _bookManager.OnClick_ChangePage(1);
            }else{
                _bookManager.OnClick_ChangePage(-1);
            }
        }else{
            if(Up){
                GameInterfaceManager.instance.MoveCameraUp();
            }else{
                GameInterfaceManager.instance.MoveCameraDown();
            }
        }

        
        
        


        


    }
}
