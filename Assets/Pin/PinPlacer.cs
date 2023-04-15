using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PinPlacer : MonoBehaviour
{
    public GameObject pinPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 何かのキーが押下されたら
        if (Input.anyKeyDown)
        {
            foreach (KeyCode keycode in System.Enum.GetValues(typeof(KeyCode)))
            {
                // Escapeキーは除外
                if (keycode == KeyCode.Escape) continue;

                // 1文字以外のキーは除外
                if (keycode.ToString().Length > 1) continue;

                if (Input.GetKeyDown(keycode))
                {
                    // マウスカーソルのワールド座標を取得
                    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    // Z軸修正
                    mousePosition.z = 0f;

                    // ピンを作成/登録
                    var pinObj = Instantiate(pinPrefab, mousePosition, Quaternion.identity, transform);
                    // 文字をピンの名前にする
                    pinObj.GetComponent<TextMeshPro>().text = keycode.ToString();
                }
            }
        }
    }
}
