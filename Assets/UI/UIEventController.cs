using UnityEngine;
using UnityEngine.UI;

public class UIEventController : MonoBehaviour
{
    [SerializeField] private GameObject cube; // 操作対象のキューブ

    public bool start = false;

    // 開始時に呼ばれるメソッド
    void Start()
    {
    }

    // 左ボタン押下時の動作
    public void OnLeftButtonClick()
    {
        start = true;
        Vector3 pos = cube.transform.position;
        pos.x += -0.5f;
        cube.transform.position = pos;
        GameObject UICanvas = GameObject.Find("UICanvas"); //Playerっていうオブジェクトを探す
        UICanvas.SetActive(false);
    }

    // 右ボタン押下時の動作
    public void OnRightButtonClick()
    {
        start = true;
        Vector3 pos = cube.transform.position;
        pos.x += 0.5f;
        cube.transform.position = pos;
        GameObject UICanvas = GameObject.Find("UICanvas"); //Playerっていうオブジェクトを探す
        UICanvas.SetActive(false);
    }

    // 初期ボタン押下時の動作
    public void OnInitButtonClick()
    {
        Vector3 pos = cube.transform.position;
        pos.x = 0f;
        cube.transform.position = pos;
    }

    // チェックボックス押下時の動作
    public void OnToggle(bool value)
    {
        cube.SetActive(value);
    }

    // スクロールバー操作時の動作
    public void OnScrollbar(float value)
    {
        Vector3 scale = cube.transform.localScale;
        scale.x = 1 + value;
        scale.y = 1 + value;
        scale.z = 1 + value;
        cube.transform.localScale = scale;
    }
}