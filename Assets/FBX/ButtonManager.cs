using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject panel;


    public void Basla()
    {
        panel.SetActive(false);
       
    }

    public void OyunuKapatma()
    {
        Application.Quit();
        Debug.Log("Oyun Kapandý");
    }
}
