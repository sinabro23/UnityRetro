using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// 게임 오버 상태를 표현하고, 게임 점수와 UI를 관리하는 게임 매니저
// 씬에는 단 하나의 게임 매니저만 존재할 수 있다.
public class GameManager : MonoBehaviour {
    public static GameManager instance;

    public bool isGameover;
    public Text scoreText;
    public GameObject gameoverUI;

    private int score = 0;

    void Awake() {
        if(null == instance)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("이미 게임 매니저가 존재합니다!");
            Destroy(gameObject);
        }
    }

    void Update() {
        // 게임 오버 상태에서 게임을 재시작할 수 있게 하는 처리

        if (isGameover && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    // 점수를 증가시키는 메서드
    public void AddScore(int newScore) {
        if(!isGameover)
        {
            score += newScore;
            scoreText.text = "Score : " + score;
        }

    }

    // 플레이어 캐릭터가 사망시 게임 오버를 실행하는 메서드
    public void OnPlayerDead() {

        isGameover = true;
        gameoverUI.SetActive(true);
    }
}