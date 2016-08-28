using UnityEngine;
using System.Collections;


public class PlayerAttack : MonoBehaviour
{

    public int power;
    public GameObject AttackGround1;
    public GameObject AttackGround2;
    public GameObject UnityChan2DController;
    //ユニティちゃん被ダメージ関係
    UnityChan2DController _unitychan2DController;
    private bool isGround;
    
    

  

    void at1()
    {

        power = 10;
    }

    void at2()
    {

        power = 20;
    }


    // 0

    void Start()
    {
        GameObject ゆにてぃ = GameObject.FindGameObjectWithTag("Player");
        _unitychan2DController = GameObject.Find("ゆにてぃ").GetComponent<UnityChan2DController>();



        // コルーチンを実行  
        StartCoroutine("Sample");
    }

 
  void Update()
    {

        isGround = _unitychan2DController.isGround;
        Debug.Log(isGround);
    }


    // コルーチン  
    public IEnumerator Sample()
    {



        while ( true)
        {

           
            

            if (  Input.GetKeyDown("z") && isGround == true)
            {

                yield return new WaitForSeconds(0.1f);
                AttackGround1.GetComponent<BoxCollider2D>().enabled = true;
                at1();
                yield return new WaitForSeconds(0.05f);

            }


            if (Input.GetKeyDown("x") && isGround == true )
            {

                yield return new WaitForSeconds(0.1f);
                AttackGround2.GetComponent<BoxCollider2D>().enabled = true;
                at2();
                yield return new WaitForSeconds(0.05f);

            }

            else
            {
                AttackGround1.GetComponent<BoxCollider2D>().enabled = false;
                AttackGround2.GetComponent<BoxCollider2D>().enabled = false;

            }





            
            yield return null;



        }

    }
    
}

