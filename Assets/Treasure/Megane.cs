using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Megane : MonoBehaviour
{
    void Start()
    {
    }

    private void OnCollisionStay(Collision collision)
    {
        //衝突したオブジェクトがenemyだった場合
        if (collision.gameObject.name.Contains("enemy"))
        {
            // 自分を破壊する.
            //Destroy(this.gameObject);
        }
    }
}