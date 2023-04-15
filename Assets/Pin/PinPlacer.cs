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
        // �����̃L�[���������ꂽ��
        if (Input.anyKeyDown)
        {
            foreach (KeyCode keycode in System.Enum.GetValues(typeof(KeyCode)))
            {
                // Escape�L�[�͏��O
                if (keycode == KeyCode.Escape) continue;

                // 1�����ȊO�̃L�[�͏��O
                if (keycode.ToString().Length > 1) continue;

                if (Input.GetKeyDown(keycode))
                {
                    // �}�E�X�J�[�\���̃��[���h���W���擾
                    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    // Z���C��
                    mousePosition.z = 0f;

                    // �s�����쐬/�o�^
                    var pinObj = Instantiate(pinPrefab, mousePosition, Quaternion.identity, transform);
                    // �������s���̖��O�ɂ���
                    pinObj.GetComponent<TextMeshPro>().text = keycode.ToString();
                }
            }
        }
    }
}
