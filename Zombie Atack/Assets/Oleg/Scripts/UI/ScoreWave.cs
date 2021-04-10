using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreWave : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _timeShowWave;

    private void Awake()
    {
        _text.gameObject.SetActive(false);
    }
    public void UIWave(int wave)
    {
        _text.gameObject.SetActive(true);
        _text.text = "ВОЛНА " + wave;
        Invoke("UIWaveFalse", _timeShowWave);
    }

    private void UIWaveFalse()
    {
        _text.gameObject.SetActive(false);
    }



}
