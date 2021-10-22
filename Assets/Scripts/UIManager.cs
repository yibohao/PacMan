using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //public Button level1, level2;
    public Text score;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(1);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void LoadLevel2()
    {
        Debug.Log("Level 2 button Clicked!");
        //SceneManager.LoadScene(2);
        //SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void QuitGame()
    {
        Debug.Log("Go back to menu");
        SceneManager.LoadScene(0);
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }


    Button quitgame;
    GameObject[] lifeIndicator = new GameObject[3];
    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //add things when level 1 ui control
        if(scene.buildIndex == 1)
        {
            //quit button
            quitgame = GameObject.Find("Quit").GetComponent<Button>();
            quitgame.onClick.AddListener(QuitGame);

            //get life indicator component
            for(int i = 0; i < lifeIndicator.Length; i++)
            {
                lifeIndicator[i] = GameObject.Find("Life-indicator"+i).GetComponent<GameObject>();
            }
        }
    }

    int life = 3;
    public void LifeIndicator(int life)
    {
        //calculate life
    }
}
