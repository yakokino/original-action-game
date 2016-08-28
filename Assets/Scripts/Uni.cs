using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Uni : MonoBehaviour
{

    private int  UniHP = 30;
    private int Unipower = 10;
    private int unidamage;
    Slider _slider;
    PlayerAttack _playerattack;
    UnityChan2DController unichan;
    





    void Start()
    {
       _slider = GameObject.Find("Slider").GetComponent<Slider>();
       _playerattack =  GameObject.Find("PlayerAttack").GetComponent<PlayerAttack>();
       unichan = GameObject.Find("ゆにてぃ").GetComponent<UnityChan2DController>();

    }


    void Update()
    {

        _slider.value = UniHP;
                unidamage = _playerattack.power;
        Debug.Log(unidamage);
        



    }

   

    void bttle()
    {



        UniHP -= unidamage;
        Debug.Log("Hit");
        if (UniHP <= 0)
        {
            Destroy(gameObject);
        }

    }

   

        void OnTriggerEnter2D(Collider2D c)
    {


            string layerName = LayerMask.LayerToName(c.gameObject.layer);
            if (layerName == "Attack")
        {

            bttle();

        }
            

        if (layerName == "Player" )
        {
            

            unichan.MainHP = unichan.MainHP - Unipower;


        }


       

        }







}