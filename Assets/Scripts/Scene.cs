using UnityEngine;
using System.Collections;

public class Scene : MonoBehaviour
{
    private GameObject[] _scenes;
    private int _scene = 1;

    void Start()
    {
        _scenes = GameObject.FindGameObjectsWithTag("Scene");
        for (int i = 0; i < _scenes.Length - 1; i++)
        {
            _scenes[i].SetActive(false);
        }
        _scene = _scenes.Length - 1;
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        _scene--;
        if (_scene < 0)
        {
            _scene = _scenes.Length -1;
        }
        for (int i = 0; i < _scenes.Length; i++)
        {
            if (_scene == i)
            {
                _scenes[i].SetActive(true);
            }
            else
            {
                _scenes[i].SetActive(false);
            }
        }
    }
}