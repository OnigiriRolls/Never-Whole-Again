using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{//declarari, orice obiect din joc se numeste gameobject
    GameObject player1;
   //in joc exita legile fizicii ca sa para jocul mai real
   //exista un sistem direct instalat care se ocupa cu fortele de frecare, collision intre obiecte
   //numa ca ar fi complicat sa le aplice la fiecare obiect
   //deci s -o facut o componenta , rigidbody, pe care o poti atasa la orice obiect vrei
   //si doar asupra acestui rigidbody se aplica frecarea, intalnirea dintre 2 obiecte, gravitatia
    private Rigidbody2D rb1;
    //viteza de miscare, e cu public sa o putem modifica din unity direct cand vrem noi
    public float speed = 20;
    public VectorValue startingPos;
    public Animator animator;


    void Start()
    {//funtia start se apeleaza atunci cand incepe jocul, o singura data
        // atunci eu ii dau sa mi caute playerul fata si mi l salveaza in player 1 si
        //asa ramane pe tot codul
        player1 = GameObject.Find("Teea");
       //la player imi trebuie si rigidbody pentru ca, ca sa l miscam apar mai multe forte
       //si  nu folosim direct : player.pozitie=(ce am introdus la tastatura).pozitie pentru ca 
       // atunci cand player ul nostru s -ar ciocni de un obiect ar trece prin el
        rb1 = player1.GetComponent<Rigidbody2D>();
        transform.position = startingPos.initialValue;

    }

    void Update()
    {

        float horizontal1 = 0;// sageata stanga dreapta
        float vertical1 = 0 ;//sageata sus jos
        //horizontal1 si vertical1 is nume de variabile in care se memoreaza ce apasam noi la tastatura
         horizontal1 = Input.GetAxis("Horizontal");
         vertical1 = Input.GetAxis("Vertical");
        //input=ce taste apasam la tastatura
        if (Input.GetAxis("Horizontal") == 0)
            animator.SetBool("Hor", false);
        else animator.SetBool("Hor", true);
        if (Input.GetAxis("Vertical") == 0)
            animator.SetBool("Ver", false);
        else animator.SetBool("Ver", true);
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        animator.SetFloat("Vertical", Input.GetAxis("Vertical"));
        //vector 2=(x,y) =adica un vector care imi stocheaza  coordonatele pentru axa x si axa y
        Vector2 position = rb1.position; //aici pun intr-un vector pozitia corpului playerului
        //nu direct a playerului, pentru ca -s diferite, trebe sa ti arat
        position.x = position.x + 0.1f * horizontal1*Time.deltaTime*speed;
        position.y = position.y + 0.1f * vertical1*Time.deltaTime * speed;
        //pozitia.x se refera la pozitia pe axa x la care adaugam: horizontal1=ce am apasat tastatura
        ////////////////////////////////////////////////////////// time.deltatime= ca playerul sa se miste dupa secunde
        ////////////////////////////////////////////////////////si nu dupa frames
        ///////////////////////////////////////////////////////0.1f si speed ii sa dau viteza mai mare,sa fac un numar mai mare

        rb1.MovePosition(position);// aici miscam pozitia corpului cu cat am introdus

        

    }
}
