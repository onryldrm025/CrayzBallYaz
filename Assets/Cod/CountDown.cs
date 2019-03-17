using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour {

    [SerializeField] private Text TextTimer;    //Time yazılan text
    [SerializeField] public float GameTimer;   // Oyun Zaman ayarı
    [SerializeField]public Text StartText;      //Oyun başlatma text
    [SerializeField]private float StartTimer;   // oyun başlatma zamanı
    [SerializeField]private GameObject ball;    // Top Privide olması ball mudahale olmasın
    Rigidbody rbBall;                           // Topun Rigitbodys almak için
    public Text textReady;
    public Canvas a3; // gameover apli3
    public Canvas a2; // youvin apli2
    public GameObject panel;
    Animator animasyon;


    private bool canCount = true;                // Sayabilirmiyim
    private bool cantCount = false;              //Sayamam
    private bool canStarttime = true;            //Sayabilirmiyim balangıc


    public float timer;                        // aktif zaman
    private float timerstart;                   // Başlangıc Sayacım 
    void Start () {
       timer = GameTimer;
       rbBall = ball.GetComponent<Rigidbody>();                     // Topub Rb çekiyorum
        rbBall.constraints = RigidbodyConstraints.FreezePosition;   // Topun Hareketini Donduruyorum Harket yok
        TextTimer.text = timer.ToString("F");                       // Seviye Bitirilicek Text yazılıyor (Unity'den ayar yapılabilir)
        timerstart = StartTimer;
        animasyon = panel.GetComponent<Animator>();
		
	}


    void Update() {


        if (timerstart >= 0 && canStarttime)
        {
            timerstart -= Time.deltaTime;
            StartText.text = timerstart.ToString("F1");

        }
        else
        {
            StartText.GetComponent<Text>().color = new Color(0, 0, 0, 0);       //Sayma işleminden sonra Text görünmez yapılıyor
            canStarttime = false;
            rbBall.constraints = RigidbodyConstraints.None;                     //Topun hareket kısıtı kalkıyor
            timerstart = 0;


        }
        if (timerstart <= 0.2)
        {

            textReady.text = "Go go go!";
            Invoke("noshowready", 0.8f);

        }




        if (timer >= 0.0f && canCount && timerstart==0 )                        //Verilen süre sayımı
        {
            timer -= Time.deltaTime;
            TextTimer.text = timer.ToString("F");
        }
        else if(timer <= 0.0f && !cantCount )
        {
            canCount = false;
            cantCount = true;
            TextTimer.text = "0.00";
            timer = 0.0f;

            gameOver(); // yazılmadı
            
        }
        if(timer <=10.0f)
        {
            TextTimer.GetComponent<Text>().color = Color.red;
            TextTimer.GetComponent<Text>().fontSize = 25;


        }
  


	}
    public void noshowready()
    {
        textReady.enabled = false; 
    }
   
   
   public  void gameOver() {
        if(a2.enabled!=true)
        {
            a3.enabled = true;
            animasyon.SetTrigger("Come");

        }
        

    }
}
