using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TW_Menu : NetworkBehaviour
{
    private void Start()
    {
        Destroy(NetworkManager.Singleton.gameObject);
    }


    public void LevelOne()
    {
        SceneManager.LoadScene("Level1");
    }
    public void LevelTwo()
    {
        SceneManager.LoadScene("Level2");
    }
    public void LevelThree()
    {
        SceneManager.LoadScene("Level3");
    }

    public void Exit()
    {
        Application.Quit();
    }

}
