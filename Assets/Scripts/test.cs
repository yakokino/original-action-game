
using UnityEngine;
using System.Collections;

[System.Serializable]
public class test 
{
    public string attackName;
    public int attackId;
    public int attackPower;
    public  AttackType  attackType;
    
    public enum AttackType
    {
        Non,
        Fire,

    }

    public test(string name, int id , int apower,AttackType atype)
    {
        attackName = name;
        attackId = id;
        attackPower = apower;
        attackType = atype;


    }
    


}

