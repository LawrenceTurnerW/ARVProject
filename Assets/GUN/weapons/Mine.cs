using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    //GameObject型で変数myMineを宣言します。
    public GameObject myMine;
    //Exploder型の変数exploderで宣言します。
    Exploder exploder;

    // 地雷をセットするオブジェクト
    [SerializeField]
    private GameObject setMine = null;
    private bool setMineflag = false;


    void Start()
    {
        //GetComponentでExploderコンポーネントにアクセスして、
        //変数exploderで参照します。
        exploder = myMine.GetComponent<Exploder>();
    }



    private void OnCollisionEnter(Collision collision)
    {
        //キャラクターがat_mine_LOD0に接触した時の処理
        if (collision.gameObject.name.Contains("enemy"))
        {
            //キャラクターが接触したらExploderのチェックを有効にして爆発させます。
            exploder.enabled = true;
            //at_main_LOD0を０.２秒後に消滅させます。
            Invoke("MineDisappeard", 0.2f);
        }
    }
    //0,2秒後に消滅させる処理。
    void MineDisappeard()
    {
        // 次の地雷が3秒後に出現するようにセットします
        if (!setMineflag)
        {
            Instantiate(setMine, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            setMineflag = true;
        }
        myMine.SetActive(false);
    }
}