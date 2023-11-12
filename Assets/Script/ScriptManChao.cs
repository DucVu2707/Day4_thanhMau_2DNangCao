using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScriptManChao : MonoBehaviour
{


    public InputField namePlayer;
    public string tenPlayer = "";
    public
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("name"))
        {
            tenPlayer = PlayerPrefs.GetString("name");
            namePlayer.text = tenPlayer;
        }
    }

    // Update is called once per frame
    void Update()
    {
        tenPlayer = namePlayer.text;
    }

    public void luuTen(){
        PlayerPrefs.SetString("name", tenPlayer);
    }

    public void chuyenMan()
    {
        SceneManager.LoadScene("ManChoi");
    }
}
