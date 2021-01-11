using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBtns : MonoBehaviour {

    public void goMainMenu() {
        SceneManager.LoadScene("Menu");
    }
    
    public void goPlayGame() {
        SceneManager.LoadScene("PlayGame");
    }

    public void goRoll() {
        SceneManager.LoadScene("RollCharacter");
    }

    public void goSettings() {
        SceneManager.LoadScene("Settings");
    }

    public void goAbout() {
        SceneManager.LoadScene("About");
    }
    
}
