using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public static int ColorNumber;
    public GameObject menu;
    public GameObject smenu;
    public GameObject lvmenu;
    public  GameObject logo;
    Animator animasyon;


    
    void Start()
    {
        animasyon = logo.GetComponent<Animator>();
        animasyon.SetTrigger("Come");

    }

    


    public void PlayGame(string name)
    {
        SceneManager.LoadScene(name);
     
    }

    public void QuitGame()
    {
        Application.Quit();

    }
    public void Options()
    {

        


    }
    public void BallColor(int number)
    {
        ColorNumber = number;

    }
   
    public void Sıfırla()
    {

        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("menu");
        menu.SetActive(false);
        
        smenu.SetActive(false);
        lvmenu.SetActive(true);



    }
}