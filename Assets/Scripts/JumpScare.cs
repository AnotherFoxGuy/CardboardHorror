using UnityEngine;
using System.Collections;
using UnityEngine.SocialPlatforms;

public class JumpScare : MonoBehaviour
{
    private float _timer;

    public float ShowTime;

    private GameObject _child;

    public int Times = 1;


    // Use this for initialization
    void Start()
    {
        _child = transform.GetChild(0).gameObject;
        _child.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer > 0)
        {
            _timer -= Time.deltaTime;
        }
        if (_timer < 0 && _timer > -5)
        {
            _timer = -99;
            _child.SetActive(false);
            print(" _child.SetActive(false);");
        }

    }

    void OnTriggerEnter()
    {
        if (Times > 0)
        {
            Times--;
            _timer = ShowTime;
            _child.SetActive(true);
            print(" _child.SetActive(true);");
        }
    }
}
