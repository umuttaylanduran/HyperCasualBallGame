using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static MenuManager MenuManagerInstance;
    public bool GameState;
    public GameObject[] menuElement = new GameObject[2];
    void Start()
    {
        GameState = false;
        MenuManagerInstance = this;
        menuElement[3].GetComponent<Text>().text = PlayerPrefs.GetInt("score").ToString();
    }

    void Update()
    {
        
    }
    public void StartTheGame()
    {
        GameState = true;
        menuElement[0].SetActive(false);
        GameObject.FindWithTag("particle").GetComponent<ParticleSystem>().Play();

    }

    public void Retry_Btn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
