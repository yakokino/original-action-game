using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AttackDataBase : MonoBehaviour
{
    //リスト化をして下のvoid Start内でリストに値を追加、値は適当です  
    public List<test> attacks = new List<test>();

    void Start()
    {
        attacks.Add(new test("攻撃１", 1, 1, test.AttackType.Non));
        attacks.Add(new test("攻撃２", 2, 1, test.AttackType.Non));

    }
}