using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIhandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);

    }
    public void Mainpart()
    {
        SceneManager.LoadScene(5);

    }
    public void Setting()
    {
        SceneManager.LoadScene(2);

    }
    public void doller()
    {
        SceneManager.LoadScene(4);

    }
    public void Rules()
    {
        SceneManager.LoadScene(3);

    }

    public void ExitBtn()
    {
        SceneManager.LoadScene(0);

    }
    public void OpenUrl()
    {
        Application.OpenURL("https://www.facebook.com/");
    }



}
