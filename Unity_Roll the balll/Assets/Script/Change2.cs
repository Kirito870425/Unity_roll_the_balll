using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Change2 : MonoBehaviour
{
    #region 屬性
    public GameObject sphere;
    public GameObject donuts;
    public GameObject cones;
    public GameObject ball2;

    public GameObject passimage;
    public GameObject deadimage;
    public GameObject propsaudio;

    public AudioClip touchaudio;


    #endregion

    #region 方法
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "甜甜圈")
        {
            donuts.SetActive(true);
            sphere.SetActive(false);
            cones.SetActive(false);
            propsaudio.GetComponent<AudioSource>().PlayOneShot(touchaudio);
        }
        else if (collision.gameObject.name == "三角錐")
        {
            cones.SetActive(true);
            donuts.SetActive(false);
            sphere.SetActive(false);
            propsaudio.GetComponent<AudioSource>().PlayOneShot(touchaudio);
        }
        else if (collision.gameObject.name == "終點")
        {
            passimage.SetActive(true);
            ball2.GetComponent<Rigidbody>().isKinematic = true;
        }
        else if (collision.gameObject.name == "死亡判定")
        {
            deadimage.SetActive(true);
            ball2.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
    public void PassButton()
    {
        passimage.SetActive(false);
        SceneManager.LoadScene("關卡三");
    }
    public void DeadButton()
    {
        deadimage.SetActive(false);
        SceneManager.LoadScene("關卡二");
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("選單");
    }
    #endregion

    #region 事件
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    #endregion

}
