using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summonMine : MonoBehaviour
{
    [SerializeField]
    private GameObject mine = null;

    void Start()
    {
        //Mineを7秒後に召喚
        Invoke(nameof(SummonMineObject), 7.0f);
    }

    void SummonMineObject()
    {
        Vector3 setposition;
        Instantiate(mine, new Vector3(this.transform.position.x, this.transform.position.y + 0.01f, this.transform.position.z), Quaternion.identity);
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
