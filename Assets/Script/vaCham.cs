using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class vaCham : MonoBehaviour
{
    public int hp = 100;
    public Text textHp;

    public int point = 0;

    public Text textPoint;
    public Image healthBarImage;

    // Start is called before the first frame update
    void Start()
    {
        hp = 100;
        UpdateHPText();
        point = PlayerPrefs.GetInt("Point", 0);
        updatePoint();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("vatCan"))
        {
            hp -= 5;
            UpdateHPText();
        }

        if(collision.CompareTag("point")){
            point +=1;
            updatePoint();
        }
    }

    private void UpdateHPText()
    {
        textHp.text = "HP: " + hp.ToString();
        float healthPercentage = (float)hp / 100f; // Chia cho 100 để có giá trị phần trăm
        healthBarImage.fillAmount = healthPercentage;
    }

    private void updatePoint(){
        textPoint.text = "Point: " + point.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("PlayerHP", hp);
        PlayerPrefs.SetInt("Point", point);
        PlayerPrefs.Save();
    }


}
