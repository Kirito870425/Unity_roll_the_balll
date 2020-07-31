using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartScenes : MonoBehaviour
{
    public GameObject ccc;
    public GameObject sss;

    public void StartButton()
    {
        SceneManager.LoadScene("關卡一");
    }
    private void Update()
    {
        ccc.transform.Rotate(0,0,2);
        sss.transform.Rotate(0,0,2);
    }
}
