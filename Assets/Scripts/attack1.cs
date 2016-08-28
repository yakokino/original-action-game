using UnityEngine;
using System.Collections;

public class attack1 : MonoBehaviour
{

    // 攻撃力
    public int power = 1;
    void OnTriggerEnter2D(Collider2D c)
    {

        // レイヤー名を取得
        string layerName = LayerMask.LayerToName(c.gameObject.layer);

        // レイヤー名がEnemy(Player)以外の時は何も行わない
        if (layerName != "Enemy") return;


        GameObject AttackGround1 = GameObject.FindGameObjectWithTag("Attack");
        // コンポーネントを取得
        attack1 id1 = AttackGround1.GetComponent<attack1>();



        Debug.Log("攻撃ヒット！");


      
    }
}

