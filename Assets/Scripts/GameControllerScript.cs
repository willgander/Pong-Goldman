using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public string[] levels;
    public GameObject helpPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClickQuit()
    {
        Application.Quit();
        print("Quit button was pressed");
    }

    public void OnClickHelp()
    {
        helpPanel.gameObject.SetActive(true);
    }
    public void OnClickHelpClose()
    {
        helpPanel.gameObject.SetActive(false);
    }

    public void OnClickStart()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
