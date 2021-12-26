using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Roulette : MonoBehaviour
{

    [SerializeField] Button btnRoulette;
    [SerializeField] GameObject roulette;

    private float rotspeed = 0;
    bool btnValue = false;
    bool moveValue;

    void Start()
    {
        btnRoulette.onClick.AddListener(OnClickRoulette);
    }

    void Update()
    {
        if (moveValue == true)
        {
            rotspeed = 10;
            btnValue = true;
        }
        else if (moveValue == false)
        {

            rotspeed *= 0.98f;
            btnValue = false;
        }

        roulette.transform.Rotate(0, 0, rotspeed);   
    }

    private void OnClickRoulette()
    {
        if (btnValue == false)
            moveValue = true;

        else if (btnValue == true)
            moveValue = false;

    }

}
