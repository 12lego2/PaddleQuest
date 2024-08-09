using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    
    public void PlayGame()
    {
        Invoke ("BattleLoad", 1);
    }
    public void BattleLoad()
    {
        SceneManager.LoadSceneAsync("Battle");
    }
}
