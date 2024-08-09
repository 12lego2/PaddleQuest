using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public Image button;
    public Sprite buttonP;
    public GameObject text;
    //public Text text;

    public void buttonPressed()
    {
        //add in code to make text move down with button press, for now just turning off text works
       
        text.SetActive(false);
        button.sprite = buttonP;
    }
    
    public void PlayGame()
    {
        Invoke ("BattleLoad", 1);
    }
    public void BattleLoad()
    {
        SceneManager.LoadSceneAsync("Battle");
    }
}
