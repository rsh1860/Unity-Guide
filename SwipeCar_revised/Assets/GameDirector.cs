using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{

    GameObject car;
    GameObject flag;
    GameObject distance;

    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");

        position = car.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        if (length >= 0 && length <= 14.5)
            this.distance.GetComponent<Text>().text = "목표 지점까지 " + length.ToString("F2") + "m";
        else if (length > 14.5)
            SceneManager.LoadScene("GameScene");

        else
        {
            this.distance.GetComponent<Text>().text = "Game Over!"+ "\nTouch to restart";
            if (Input.GetMouseButtonDown(0))
                SceneManager.LoadScene("GameScene");
        }

    }
}
