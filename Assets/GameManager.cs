using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public TextMeshPro countDownText;
    public bool isStarted;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDown());
    }

    // Update is called once per frame
    void Update()
    {
        // Esc�{�^���ŃV�[�������[�h
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    // �J�E���g�_�E���X�^�[�g
    private IEnumerator CountDown()
    {
        // 10�b�J�E���g�_�E��
        for (int i = 10; i > 0; i--)
        {
            countDownText.text = i.ToString();
            yield return new WaitForSeconds(1);
        }

        // GO!
        countDownText.text = "GO!";
        isStarted = true;
        ball.BallStart();

        // GO������
        yield return new WaitForSeconds(1);
        countDownText.text = "";
    }
}
