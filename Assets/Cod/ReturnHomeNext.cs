using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnHomeNext : MonoBehaviour {
    int level;
	
	 public void replay()               //replay tusuna basılınca oldugun bölümü yükle
        {
        SceneManager.LoadScene(Application.loadedLevelName);

    } 
public void home()              // Home tuşuna basılınca menuye yükle
        {
        SceneManager.LoadScene("menu");
        }
public void next()                  // seviye atla
        {
        level = int.Parse(Application.loadedLevelName) + 1;

        SceneManager.LoadScene(level.ToString());

    }

}
