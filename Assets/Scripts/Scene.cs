using UnityEngine;
using System.Collections;

public class Scene : MonoBehaviour
{
    public GameObject[] Scenes;
    private int _scene = 1;

    public bool TriggerEnter;
    public bool TriggerOnce;

    private bool _trigger = true;

    void Start()
    {
        for (int i = Scenes.Length - 1; i > 0; i--)
        {
            Scenes[i].SetActive(false);
        }
        _scene = 0;
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        if (TriggerEnter)
        {
            Trigger();
        }
    }

    void OnTriggerExit()
    {
        if (!TriggerEnter)
        {
            Trigger();
        }
    }

    void Trigger()
    {
        if (TriggerOnce && _trigger)
        {
            _trigger = false;
            TriggerTwo();

        }
        else if (!TriggerOnce)
        {
            TriggerTwo();
        }
    }

    void TriggerTwo()
    {
        _scene--;
        if (_scene < 0)
        {
            _scene = Scenes.Length - 1;
        }
        for (int i = 0; i < Scenes.Length; i++)
        {
            if (_scene == i)
            {
                Scenes[i].SetActive(true);
            }
            else
            {
                Scenes[i].SetActive(false);
            }
        }
    }
}