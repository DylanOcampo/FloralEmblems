using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSystem : MonoBehaviour
{
    // Start is called before the first frame update    
    public void OnClick_LoadScene(){
        SceneManager.LoadScene("SampleScene");
    }
}
