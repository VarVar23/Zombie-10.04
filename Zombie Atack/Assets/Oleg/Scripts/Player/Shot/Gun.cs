using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _timeCoolDown;
    [SerializeField] private Transform _point;

    public int ScoreBullet;
    public int MaxScoreBullet;

    private void Start()
    {
        ScoreBullet = MaxScoreBullet;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && ScoreBullet > 0)
        {
            ScoreBullet--;
            Instantiate(_bulletPrefab, _point.position, transform.rotation);

            if(ScoreBullet == 0)
            {
                Invoke("CoolDown", _timeCoolDown);
            }
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            ScoreBullet = 0;
            Invoke("CoolDown", _timeCoolDown);
        }
    }

    private void CoolDown()
    {
        ScoreBullet = MaxScoreBullet;
    }
}
