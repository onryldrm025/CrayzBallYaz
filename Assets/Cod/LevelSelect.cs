using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour {
    public GameObject Lock;      // Kilit paneli
    public GameObject unLock;    // Açık Kilit paneli
    public GameObject Star1;     // Yıldız
    public GameObject Star2;     // Yıldız
    public GameObject Star3;     //Yıldız
    

    void Start()

    {
        if (gameObject.name == "1")       //Oyun yeni açıldıysa 1. seviyeyi aktif et Özel durun!!!!!
        {

            if (PlayerPrefs.GetInt(gameObject.name) == 0)
            {
                GetComponent<Button>().interactable = true;
                Lock.SetActive(false);
                unLock.SetActive(true);
                //  GetComponent<Image>().color = new Color(0, 0, 0, 0);

            }
            if (PlayerPrefs.GetInt(gameObject.name) == 1)
            {
                GetComponent<Button>().interactable = true;
                

            }

            if (PlayerPrefs.GetInt(gameObject.name) == 2)
            {
                GetComponent<Button>().interactable = true;
                Lock.SetActive(false);
                unLock.SetActive(true);

                Star1.SetActive(true);


            }

            if (PlayerPrefs.GetInt(gameObject.name) == 3)
            {
                GetComponent<Button>().interactable = true;
                Lock.SetActive(false);
                unLock.SetActive(true);

                Star1.SetActive(true);
                Star2.SetActive(true);

            }

            if (PlayerPrefs.GetInt(gameObject.name) == 4)
            {
                GetComponent<Button>().interactable = true;
                Lock.SetActive(false);
                unLock.SetActive(true);


                Star1.SetActive(true);
                Star2.SetActive(true);
                Star3.SetActive(true);

            }

        }

        // 1. durum hericindeki bütün durunlar
        else
        {
            if (PlayerPrefs.GetInt(gameObject.name) == 0)
            {
                GetComponent<Button>().interactable = false;
                Lock.SetActive(true);
                unLock.SetActive(false);
                GetComponent<Image>().color = new Color(0, 0, 0, 0);

            }
            if (PlayerPrefs.GetInt(gameObject.name) == 1)
            {
                GetComponent<Button>().interactable = true;
                unLock.SetActive(true);
                Lock.SetActive(false);

            }

            if (PlayerPrefs.GetInt(gameObject.name) == 2)
            {
                GetComponent<Button>().interactable = true;
                Lock.SetActive(false);
                unLock.SetActive(true);

                Star1.SetActive(true);


            }

            if (PlayerPrefs.GetInt(gameObject.name) == 3)
            {
                GetComponent<Button>().interactable = true;
                Lock.SetActive(false);
                unLock.SetActive(true);

                Star1.SetActive(true);
                Star2.SetActive(true);

            }

            if (PlayerPrefs.GetInt(gameObject.name) == 4)
            {
                GetComponent<Button>().interactable = true;
                Lock.SetActive(false);
                unLock.SetActive(true);


                Star1.SetActive(true);
                Star2.SetActive(true);
                Star3.SetActive(true);

            }



        }

  


    }


    void update()
    {



    }
}



// if (PlayerPrefs.GetInt(gameObject.name) == 1)
//  GetComponent<Image>().color = new Color(0,0,0,0);
//  GetComponent<Button>().interactable = false;
// panel.SetActive(false);
//  pane2.SetActive(true);
// Debug.Log (gameObject.name);