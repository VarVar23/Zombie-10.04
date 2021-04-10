using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreBullet : MonoBehaviour
{
    [SerializeField] private Text _txt;
    [SerializeField] private GameObject _gun;


    private void Update()
    {
        _txt.text = _gun.GetComponent<Gun>().MaxScoreBullet + "/" + _gun.GetComponent<Gun>().ScoreBullet;
    }
}
