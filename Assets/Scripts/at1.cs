using UnityEngine;
using System.Collections;

public class at1 : MonoBehaviour {

    public GameObject UnityChan2DController;
    UnityChan2DController _unitychan2DController;
    private bool isGround;

    void Start()
    {

        _unitychan2DController = GameObject.Find("ゆにてぃ").GetComponent<UnityChan2DController>();

    }


    void Update()
    {

        isGround = _unitychan2DController.isGround;

        Debug.Log(isGround);



    }





}

   





