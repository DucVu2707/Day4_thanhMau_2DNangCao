using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptManChoi : MonoBehaviour
{

    // Start is called before the first frame update
    public Text textNamePlayer;
    void Start()
    {
     if(PlayerPrefs.HasKey("name")){
        string tenPlayer = PlayerPrefs.GetString("name");
        textNamePlayer.text = tenPlayer;
     }else{
        textNamePlayer.text ="Khong co ten duoc luu";
     }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
