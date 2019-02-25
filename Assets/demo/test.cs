using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject[] _list;
    int _index = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _list.Length; ++i)
        {
            _list[i].SetActive(i == _index);
        }
    }

    public void onClick()
    {
        _index = (_index + 1) % _list.Length;
        for (int i = 0; i < _list.Length; ++i)
        {
            _list[i].SetActive(i == _index);
        }
    }
}
