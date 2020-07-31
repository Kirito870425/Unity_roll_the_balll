using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{
    #region 屬性
    public GameObject cube;
    public GameObject sphere;
    public GameObject donuts;
    public GameObject cones;
    public GameObject icosphere;
    public GameObject ball;

    public GameObject backimage;
    public GameObject deadimage;
    public GameObject demoimage;

    public GameObject propsaudio;

    public static bool switchShape;
    public AudioClip touchaudio;

    #endregion

    #region 方法
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "方方")
        {
            cube.SetActive(true);
            sphere.SetActive(false);
            icosphere.SetActive(false);
            donuts.SetActive(false);
            cones.SetActive(false);
            propsaudio.GetComponent<AudioSource>().PlayOneShot(touchaudio);
        }
        else if (collision.gameObject.name == "圓圓")
        {
            sphere.SetActive(true);
            cube.SetActive(false);
            icosphere.SetActive(false);
            donuts.SetActive(false);
            cones.SetActive(false);
            propsaudio.GetComponent<AudioSource>().PlayOneShot(touchaudio);
        }
        else if (collision.gameObject.name == "骰骰")
        {
            icosphere.SetActive(true);
            cones.SetActive(false);
            donuts.SetActive(false);
            cube.SetActive(false);
            sphere.SetActive(false);
            propsaudio.GetComponent<AudioSource>().PlayOneShot(touchaudio);
        }
        else if (collision.gameObject.name == "三角錐")
        {
            cones.SetActive(true);
            donuts.SetActive(false);
            icosphere.SetActive(false);
            cube.SetActive(false);
            sphere.SetActive(false);
            propsaudio.GetComponent<AudioSource>().PlayOneShot(touchaudio);
        }
        else if (collision.gameObject.name == "甜甜圈")
        {
            donuts.SetActive(true);
            icosphere.SetActive(false);
            cones.SetActive(false);
            cube.SetActive(false);
            sphere.SetActive(false);
            propsaudio.GetComponent<AudioSource>().PlayOneShot(touchaudio);
        }
        else if (collision.gameObject.name == "終點")
        {
            backimage.SetActive(true);
            ball.GetComponent<Rigidbody>().isKinematic = true;
        }
        else if (collision.gameObject.name == "結束點")
        {
            demoimage.SetActive(true);
            ball.GetComponent<Rigidbody>().isKinematic = true;
        }
        else if (collision.gameObject.name == "死亡判定")
        {
            deadimage.SetActive(true);
            ball.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
    public void PassButton1()
    {
        backimage.SetActive(false);
        SceneManager.LoadScene("關卡二");
    }
    public void PassButton2()
    {
        backimage.SetActive(false);
        SceneManager.LoadScene("關卡三");
    }
    public void DeadButton()
    {
        backimage.SetActive(false);
        SceneManager.LoadScene("關卡一");
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("選單");
    }

    #endregion

    #region 事件

    void Start()
    {
        switchShape = !switchShape;

        if (switchShape)
        {
            sphere.SetActive(false);
            cube.SetActive(true);
        }
        else
        {
            sphere.SetActive(true);
            cube.SetActive(false);
        }
    }

    void Update()
    {
       
    }

    #endregion

}
