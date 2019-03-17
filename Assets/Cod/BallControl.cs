using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

public class BallControl : MonoBehaviour {

    //Top Kontrollerimin olduğu yer 
    Rigidbody rbBall;     //Toplun rigid bodysi
    public float speed;  // Top hız verisi
    private int puan;   // Puanı tutar
    public Text textScore;  //Score texi
    public TextMeshProUGUI TextPro; //Windeki score text
    public TextMeshProUGUI TextProTime; // Wİndeki time text
    public Text time;
    public Canvas a1;   // Start Canvas apli 1
    public Canvas a2;   // YouWin Canvas apli2
    public Canvas a3;   // Game Over apli3
    private GameObject[] gold;         // Tüm gold Al
    private Vector3 startPos;
    public Material[] ChangeMate;       // Top değiştişme
    int jumpcount = 0;
    public GameObject panel; // Score tablosundaki panel
    public GameObject panel2;
    Animator animasyon;      // Panel Anımasyonu
    Animator animasyon2;
    public GameObject fng1;   // Yeni skor ise aktif
    public GameObject fng2;   // Yeni time skor ise aktif
    public Text textTime;
    int goldcount;
    AudioSource sound;
    public AudioClip cpWon;
    public AudioClip cpGover;
   


    void Start () {
       
        a2.enabled = false;
        a3.enabled = false;
        rbBall = this.GetComponent<Rigidbody>();  // Top Kontrolleri sağlanması için RigidBody ekleniyor
        puan = 0;                            // puan 0 la
        gold = GameObject.FindGameObjectsWithTag("Gold");
        startPos = rbBall.position;
        sound = GetComponent<AudioSource>();



        GetComponent<Renderer>().material = ChangeMate[Menu.ColorNumber];
        animasyon = panel.GetComponent<Animator>();
        animasyon2 = panel2.GetComponent<Animator>();
        goldcount = gold.Length;
        
    }
	
	
	void FixedUpdate () {
            float moveHorizontol = Input.GetAxis("Horizontal"); // Top Yatay verisi
           float moveVertical = Input.GetAxis("Vertical");     // Top Dikey verisi

             Vector3 move =new Vector3 (moveHorizontol,0, moveVertical);  // move=Hareket etmesi için yatar ve diker verileri veriyoruz

            rbBall.AddForce(move*speed*Time.deltaTime);     //Top hız*hareket*zaman
        
             if (Input.GetKeyDown("space") && jumpcount==0)
                 {
                 Vector3 jump = new Vector3(moveHorizontol, 300f, moveVertical);
                 GetComponent<Rigidbody>().AddForce(jump);
                 jumpcount = 1;
                 Invoke("jumpreset", 2);

             }
             

        //  transform.Translate(new Vector3(Input.acceleration.x , 0, Input.acceleration.y)* Time.deltaTime * 50 );

        //  rbBall.velocity = (new Vector3(Input.acceleration.x, 0, Input.acceleration.y) * Time.deltaTime * 1000);
        /*
        Vector3 tilt = Input.acceleration;
        if(true)
        {
            tilt = Quaternion.Euler(90, 0, 0) * tilt;

        }
         rbBall.AddForce(tilt * 7);
        */

    }

    void OnTriggerEnter (Collider col) //carpan nesne
    {
        if(col.transform.tag=="Gold")  //çarpan nesnenin tagı eşit mi Cube ??
        {
            col.gameObject.SetActive(false);   // Carptığın nesneyi sil puanı artır
            puan = puan + 10;          //puana +10 ekler
            sound.Play();
            puanUpdate();
           


        }
        else if (col.transform.tag=="Down")
        {
             gameover();
            

        }
        if (col.transform.tag == "Lastgold" & a3.enabled!=true)  //çarpan nesnenin tagı eşit mi Cube ??
        {
            sound.clip = cpWon;
            sound.Play();
            col.gameObject.SetActive(false);   // Carptığın nesneyi görünürlüğünü kapa 
            puan = puan + 10;          //puana +10 ekler

            int nextlevel = int.Parse(Application.loadedLevelName) +1 ; //Bölüm kilit aç
            PlayerPrefs.SetInt(nextlevel.ToString(), 1);                // Bölüm kilit aç


            if(puan > PlayerPrefs.GetInt(Application.loadedLevel+".Score",0))
            {
                PlayerPrefs.SetInt(Application.loadedLevelName + ".Score", puan);
                fng1.SetActive(true);


                //////////////////////////// PUANA GÖRE YILDIZ


                PlayerPrefs.SetInt(Application.loadedLevelName, 2);         /////1 YILDIZ
                Debug.Log("1 yıldız");


                if (puan / 10 >= goldcount * 0.50)
                {


                    PlayerPrefs.SetInt(Application.loadedLevelName, 3);         //////// 2 YILDIZ
                    Debug.Log("2 yıldız");
                }

                if (puan / 10 >= goldcount * 0.75)
                {

                    PlayerPrefs.SetInt(Application.loadedLevelName, 4);      /////////  3 YILDIZ
                    Debug.Log("3 yıldız");
                }



                ///////////////////////////////////////////////////////////////





            }




            if ( float.Parse(time.text)> PlayerPrefs.GetFloat(Application.loadedLevel + ".Time",0) )
            {
                PlayerPrefs.SetFloat(Application.loadedLevelName + ".Time", float.Parse(time.text));
                fng2.SetActive(true);

            }


            
           



            a1.enabled=(false);
            TextPro.text = puan.ToString();
            string FnsTime = time.text;
            TextProTime.text = FnsTime; 
            
            if(a3.enabled!=true)
            {
                a2.enabled = (true);
                animasyon.SetTrigger("Come");

            }
           
            //SceneManager.LoadScene("LevelSelect");




        }

    }

    void gameover()
    {
      
        /*
                for(int i =0;i< cubes.Length; i++)
                {
                    cubes[i].gameObject.SetActive(true);

                }
                */
        //   puan = 0;

        // puanUpdate();
        // rbBall.position = startPos;
        if(a2.enabled!=true)
        {
            sound.clip = cpGover;
            sound.Play();
            rbBall.velocity = Vector3.zero;
            a3.enabled = true;
            animasyon2.SetTrigger("Come");
            rbBall.constraints = RigidbodyConstraints.FreezePosition;
            rbBall.angularVelocity = Vector3.zero;

        }
       


    }
    void jumpreset()
    {
        jumpcount = 0;
    }

    void puanUpdate()
    {

        textScore.text = "Score : " + puan;

    }
  


}
