using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ball : MonoBehaviour
{
    #region 屬性

    Rigidbody playerRigidbody;
    [Header("X軸速度"), Range(0, 10)]
    public float speedx;
    [Header("水平方向"), Range(1, -1)]
    public float horizontalDirection;

    const string HORIZONTAL = "horizontal"; //打成常數:減少錯誤，字串無提醒
    [Header("前進推力"), Range(0, 500)]
    public float xforce;
    [Header("左右推力"), Range(0, 500)]
    public float yforce;

    #endregion

    #region 方法
    /// <summary>移動</summary>
    void MovementX()
    {
        //horizontalDirection = Input.GetAxis(HORIZONTAL);    //擷取玩家輸入的按鍵
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerRigidbody.AddForce(new Vector2(xforce, 0));   //addforce要給V2的數值 推力*方向
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            playerRigidbody.AddForce(new Vector2(-xforce, 0));   //addforce要給V2的數值 推力*方向
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            playerRigidbody.AddForce(new Vector3(0 ,0 ,yforce));   //addforce要給V2的數值 推力*方向
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            playerRigidbody.AddForce(new Vector3(0 ,0 ,-yforce));
        }
    }
    #endregion

    #region 事件
    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MovementX();
    }
    #endregion

}
