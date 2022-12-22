using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleAround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (building)
        {
            Vector3 worldPosM = m_muzzlePos.position;

            target.transform.rotation = m_muzzlePos.transform.rotation;
            target.transform.localScale = new Vector3(worldPosM.x - basePosition.x, worldPosM.y - basePosition.y, worldPosM.z - basePosition.z);
            //target.transform.position = new Vector3(basePosition.x + ((worldPosM.x - basePosition.x) / 2f), basePosition.y + ((worldPosM.y - basePosition.y) / 2f), basePosition.z + ((worldPosM.z - basePosition.z) / 2f));  // x,y,zの中心にポジションをセットする
            target.transform.position = new Vector3(worldPosM.x, worldPosM.y, worldPosM.z);  // x,y,zの中心にポジションをセットする




            //target.transform.rotation = Quaternion.Euler(0f, 0f, m_muzzlePos.transform.rotation.z);
        }
    }

    [SerializeField]
    private GameObject target = null;

    [SerializeField]
    private Transform m_muzzlePos = null;

    private bool building = false;

    Vector3 basePosition = new Vector3(0f, 0f, 0f);
    Quaternion baseRotation = new Quaternion(0f, 0f, 0f, 0f);

    public void ScaleArounde()
    {
        if (!building)
        {
            basePosition = m_muzzlePos.position;
            //baseRotation = m_muzzlePos.transform.rotation;
            //target.transform.rotation = m_muzzlePos.transform.rotation;
            building = true;
        }
        else
        {
            Vector3 worldPosM = m_muzzlePos.position;

            target.transform.rotation = m_muzzlePos.transform.rotation;
            target.transform.position = new Vector3(basePosition.x + ((worldPosM.x - basePosition.x) / 2f), basePosition.y + ((worldPosM.y - basePosition.y) / 2f), basePosition.z + ((worldPosM.z - basePosition.z) / 2f));  // x,y,zの中心にポジションをセットする

            target.transform.localScale = new Vector3(worldPosM.x - basePosition.x, worldPosM.y - basePosition.y, worldPosM.z - basePosition.z);

            building = false;
        }
        //Vector3 newScale = m_muzzlePos.position;
        //Vector3 targetPos = target.transform.localPosition;
        //Vector3 diff = targetPos + pivot;
        //float relativeScale = newScale.x / target.transform.localScale.x;

        //Vector3 resultPos = pivot + diff * relativeScale; 
        //target.transform.localScale = newScale;
        //target.transform.localPosition = resultPos;
    }
}
